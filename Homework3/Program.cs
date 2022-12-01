namespace Homework3;

class Program
{
    static void Main(string[] args)
    {
        #region Task1
        Console.WriteLine("Task 1");
        Console.Write("Enter N : ");
        bool isInteger = int.TryParse(Console.ReadLine(), out int n);
        if (!isInteger)
        {
            Console.WriteLine("Please Enter Integer !!");
            return;
        }

        for (int i = 1; i < 10; i++)
        {
            Console.WriteLine($"{n} * {i} = {n * i}");
        }
        #endregion


        #region Task2
        Console.WriteLine("Task 2");
        Console.Write("Enter N : ");
        isInteger = int.TryParse(Console.ReadLine(), out n);
        if (!isInteger)
        {
            Console.WriteLine("Please Enter Integer !!");
            return;
        }

        for (int i = 1; i < n; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i * i);
            }
        }
        #endregion


        #region Task3
        Console.WriteLine("Task 3");
        Console.Write("Enter N : ");
        isInteger = int.TryParse(Console.ReadLine(), out n);
        if (!isInteger)
        {
            Console.WriteLine("Please Enter Integer !!");
            return;
        }

        int[] inputArray = new int[n];
        for (int i = 0; i < inputArray.Length; i++)
        {
            Console.Write($"A[{i}] = ");
            inputArray[i] = Convert.ToInt32(Console.ReadLine());
        }

        var oddNumbers = inputArray.Where(x => x % 2 != 0);
        var evenNumbers = inputArray.Where(x => x % 2 == 0);
        Console.WriteLine($"Odd Numbers: {string.Join(", ", oddNumbers)}");
        Console.WriteLine($"Even Numbers: {string.Join(", ", evenNumbers)}");
        #endregion


        #region Task4
        Console.WriteLine("Task4");
        Console.Write("Enter N : ");
        isInteger = int.TryParse(Console.ReadLine(), out n);
        if (!isInteger)
        {
            Console.WriteLine("Please Enter Integer !!");
            return;
        }

        int[] ints = new int[n];
        for (int i = 0; i < ints.Length; i++)
        {
            Console.Write($"A[{i}] = ");
            ints[i] = Convert.ToInt32(Console.ReadLine());
        }

        foreach (var item in ints.GroupBy(i => i))
        {
            int key = item.Key;
            int count = item.Count();
            int sum = item.Sum();
            Console.WriteLine($"{key} appears {count} times sum {sum}");
        }
        #endregion


        #region Task5
        Console.WriteLine("Task5");
        Console.Write("Enter N : ");
        isInteger = int.TryParse(Console.ReadLine(), out n);
        if (!isInteger)
        {
            Console.WriteLine("Please Enter Integer !!");
            return;
        }

        int[] array = Enumerable.Range(1, 20).ToArray();

        var topN = array.TakeLast(n);
        foreach (var item in topN)
        {
            Console.WriteLine(item);
        }
        #endregion
    }
}

