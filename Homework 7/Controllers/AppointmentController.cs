using System.Diagnostics;
using System.Text.Json;
using Homework_7.Middlewares;
using Microsoft.AspNetCore.Mvc;
using Homework_7.Models;

namespace Homework_7.Controllers;

public class AppointmentController : Controller
{
    readonly string _path = "/Users/gigaananidze/Desktop/HomeWorks/Homework 7/Data/appointments.json";
    
    public IActionResult Index()
    {
        var result = new List<AppointmentModel>();
        if (!System.IO.File.Exists(_path)) return View(result);
        string jsonString = new StreamReader(_path).ReadToEnd();
        return View(JsonSerializer.Deserialize<List<AppointmentModel>>(jsonString));
    }

    public IActionResult Create() => View();
    
    [HttpPost]
    public IActionResult Create(AppointmentModel appointment)
    {
        string jsonString = new StreamReader(_path).ReadToEnd();
        var result = JsonSerializer.Deserialize<List<AppointmentModel>>(jsonString);
        result?.Add(appointment);
        System.IO.File.WriteAllText(_path, JsonSerializer.Serialize(result, new JsonSerializerOptions { WriteIndented = true}));
        return RedirectToAction("Index");
    }

    public IActionResult Delete(DateTime id)
    {
        string jsonString = new StreamReader(_path).ReadToEnd();
        var result = JsonSerializer.Deserialize<List<AppointmentModel>>(jsonString);
        result?.RemoveAll(x => x.Date == id);
        System.IO.File.WriteAllText(_path, JsonSerializer.Serialize(result, new JsonSerializerOptions { WriteIndented = true}));
        return RedirectToAction("Index");
    } 
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error() => View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
}
