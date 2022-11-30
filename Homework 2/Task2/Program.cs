using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter X : ");

            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter y : ");

            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{x} + {y} = {x + y}");

            int min = x > y ? y : x;
            int max = x < y ? y : x;

            Console.WriteLine($"{max} - {min} = {max - min}");
            Console.WriteLine($"{x} * {y} = {x * y}");

            string cannotDivide = "Not Allowed To Divide By Zero";
            Console.WriteLine(min == 0 ? cannotDivide : $"{max} / {min} = {max / min}");
        }
    }
}