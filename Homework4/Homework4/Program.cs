using Newtonsoft.Json;

namespace Homework4;

static class Program {

    static(int min, int max, int power) GetInputFromUser() {
        Console.Write("Enter Starting Range : ");
        int start = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Range End : ");
        int end = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Power: ");
        int power = Convert.ToInt32(Console.ReadLine());

        return (start, end, power);
    }

    static (string textOne, string textTwo) InputFromUser()
    {
        Console.Write("Enter String One : ");
        string textOne = Console.ReadLine();

        Console.Write("Enter String two: ");
        string textTwo = Console.ReadLine();

        return (textOne, textTwo);
    }

    static int CountPowersInRange(int min, int max, int power) 
    {
        return Enumerable.Range(min, max - min).Count(x => Math.Pow(x, 1.0 / power) % 1 == 0);
    }

    static int HelpNikusha(string pairs)
    {
        return pairs.GroupBy(e => e).Count(e => e.Count() / 2 % 1 == 0);
    }

    static string LongestCommonEnding(string textOne, string textTwo)
    {
        for (int i = 0; i < textOne.Length; i++)
        {
            string end = textOne.Substring(i);
            if (textTwo.EndsWith(end))
            {
                return end;
            }
        }
        return "";
    }

    static void GenericFunction<T>(List<T> values)
    {
        Console.WriteLine(typeof(T).Name);
        switch (typeof(T).Name)
        {
            case "Int32":
                Console.WriteLine(values.Sum(s => s.GetHashCode()));
                break;
            case "String":
                List<string> strings = values.ConvertAll(e => e.ToString().ToUpper());
                Console.WriteLine(string.Join("\r\n", strings));
                break;
            case "Boolean":
                Console.WriteLine($"First Element is {values[0]}");
                Console.WriteLine($"Middle Element is {values[values.Count / 2]}");
                Console.WriteLine($"Last Element is {values[values.Count - 1]}");
                break;
        }
    }
    

    static void Main(string[] args) {
        #region Task 1
        Console.WriteLine("Task 1");
        var userInputs = GetInputFromUser();
        Console.WriteLine(CountPowersInRange(userInputs.min, userInputs.max, userInputs.power));
        #endregion


        #region Task 2
        Console.WriteLine("Task 2");
        Console.Write("Enter Pairs : ");
        string pairs = Console.ReadLine();
        Console.WriteLine(HelpNikusha(pairs));
        #endregion


        #region Task 3
        Console.WriteLine("Task 3");
        var userInput = InputFromUser();
        Console.WriteLine(LongestCommonEnding(userInput.textOne, userInput.textTwo));
        #endregion


        #region Task 4
        Console.WriteLine("Task 4");
        GenericFunction(new List<int>{1, 2, 3, 4});
        GenericFunction(new List<string>{"test", "random", "word"});
        GenericFunction(new List<bool>{true, false, true, false, true, false, false});
        #endregion


        #region Task 5 
        Console.WriteLine("Task 5");
        var reader = new StreamReader(@"/Users/gigaananidze/Desktop/HomeWorks/Homework4/Homework4/db.json");
        var data = JsonConvert.DeserializeObject<Item>(reader.ReadToEnd());
        Console.WriteLine((data.birthday - data.currentDate).TotalDays);
        #endregion
    }
    
    public class Item
    {
        public DateTime currentDate;
        public DateTime birthday;
    }
}

