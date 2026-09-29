// Add two Numbers

using System;

namespace program2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number-1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter a Number-2: ");
            int num2 = int.Parse(Console.ReadLine());

            int sum = num1 + num2;

            Console.WriteLine($"Sum of the two number is : {sum}");

        }
    }
}