using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number : ");
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(inputNumber % 5 == 0 ? "YES" : "NO");
        }
    }
}