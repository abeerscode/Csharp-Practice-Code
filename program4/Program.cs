// Methods and Method Overloading

using System;

namespace program4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Add numbers");
            Console.WriteLine("2. Multiply numbers");
            Console.WriteLine("3. Divide numbers");
            Console.Write("Enter choice: ");

            int choice = int.Parse(Console.ReadLine());

            Console.WriteLine("-------------------------------------------");

            switch (choice)
            {
                case 1:
                {
                    Add();
                    break;
                }

                case 2:
                {
                    Console.Write("Enter number 1: ");
                    int num1 = int.Parse(Console.ReadLine());

                    Console.Write("Enter number 2: ");
                    int num2 = int.Parse(Console.ReadLine());

                    Multiply(num1, num2);
                    break;
                }

                case 3:
                {
                    Console.Write("Enter number 1: ");
                    int num1 = int.Parse(Console.ReadLine());

                    Console.Write("Enter number 2: ");
                    int num2 = int.Parse(Console.ReadLine());

                    int result = Divide(num1, num2);

                    Console.WriteLine("Quotient = " + result);
                    break;
                }

                default:
                {
                    Console.WriteLine("Invalid choice.");
                    break;
                }
            }
        }

        static void Add()
        {
            Console.Write("Enter number 1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter number 2: ");
            int num2 = int.Parse(Console.ReadLine());

            int sum = num1 + num2;

            Console.WriteLine("Sum = " + sum);
        }

        static void Multiply(int num1, int num2)
        {
            int product = num1 * num2;

            Console.WriteLine("Product = " + product);
        }

        static int Divide(int num1, int num2)
        {
            int quotient = num1 / num2;

            return quotient;
        }
    }
}