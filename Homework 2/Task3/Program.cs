using System;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter X : ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Before Swapping: x = {x} y = {y}");

            x = x + y;
            y = x - y;
            x = x - y;

            Console.WriteLine($"After Swapping x = {x} y = {y}");
       }
    }
}