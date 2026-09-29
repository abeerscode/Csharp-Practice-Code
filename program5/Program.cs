// Exception Handling

using System;

namespace program5;

class Program
{
    static void Main(string[] Args)
    {
        try
        {
            Console.Write("Enter number-1 : ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter number-2 : ");
            int num2 = int.Parse(Console.ReadLine());

            int sum = num1 + num2;

            Console.WriteLine("Sum of the number is " + sum);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Invalid input: " + ex.Message);
        }
    }
}