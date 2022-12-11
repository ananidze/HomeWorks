using System.Text.Json;
using Homework_8.Models;
using Homework_8.Validators;
using Microsoft.AspNetCore.Mvc;

namespace Homework_8.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class PersonController : Controller
{
    const string Path = "/Users/gigaananidze/Desktop/HomeWorks/Homework 8/Data/persons.json";

    [HttpGet]
    public ActionResult<IEnumerable<Person>> GetPersons()
    {
        string jsonString = new StreamReader(Path).ReadToEnd();
        var persons = JsonSerializer.Deserialize<List<Person>>(jsonString) ?? new List<Person>();
        return Ok(persons);
    }
    
    [HttpGet("{id:int}")]
    public ActionResult<Person> GetPersonById(int id)
    {
        string jsonString = new StreamReader(Path).ReadToEnd();
        var persons = JsonSerializer.Deserialize<List<Person>>(jsonString) ?? new List<Person>();
        var person = persons.FirstOrDefault(p => p.Id == id);
        if (person == null) return NotFound();
        return Ok(person);
    }
    
    [HttpGet("filter")]
    public ActionResult<Person> FilterPersons([FromQuery] double salary)
    {
        string jsonString = new StreamReader(Path).ReadToEnd();
        var persons = JsonSerializer.Deserialize<List<Person>>(jsonString) ?? new List<Person>();
        var filteredPersons = persons.Where(p => p.Salary > salary);
        return Ok(filteredPersons);
    }
    
    
    [HttpPost]
    public ActionResult<Person> Post([FromBody] Person person)
    {
        var result = new PersonValidator().Validate(person);
        if (!result.IsValid) return BadRequest(result.Errors);
        string jsonString = new StreamReader(Path).ReadToEnd();
        var persons = JsonSerializer.Deserialize<List<Person>>(jsonString) ?? new List<Person>();
        persons.Add(person);
        System.IO.File.WriteAllText(Path, JsonSerializer.Serialize(persons, new JsonSerializerOptions { WriteIndented = true}));
        return Ok(person);
    }
    
    [HttpPut("{id:int}")]
    public ActionResult<Person> Put(int id, [FromBody] Person person)
    {
        string jsonString = new StreamReader(Path).ReadToEnd();
        var persons = JsonSerializer.Deserialize<List<Person>>(jsonString) ?? new List<Person>();
        var personToUpdate = persons.FirstOrDefault(p => p.Id == id);
        if (personToUpdate == null) return NotFound();
        persons[persons.IndexOf(personToUpdate)] = person;
        System.IO.File.WriteAllText(Path, JsonSerializer.Serialize(persons, new JsonSerializerOptions { WriteIndented = true}));
        return Ok(person);
    }

    [HttpDelete("{id:int}")]
    public ActionResult<Person> DeletePersonById(int id)
    {
        string jsonString = new StreamReader(Path).ReadToEnd();
        var persons = JsonSerializer.Deserialize<List<Person>>(jsonString) ?? new List<Person>();
        var personToDelete = persons.FirstOrDefault(p => p.Id == id);
        if (personToDelete == null) return NotFound();
        persons.Remove(personToDelete);
        System.IO.File.WriteAllText(Path, JsonSerializer.Serialize(persons, new JsonSerializerOptions { WriteIndented = true}));
        return Ok(personToDelete);
    }
}
