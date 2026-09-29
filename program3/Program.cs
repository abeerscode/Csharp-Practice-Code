// Student Result Checker

using System;

namespace program3
{
    class Program
    {
        static void Main(string[] Args)
        {
            Console.WriteLine("Enter Marks: ");
            int mark = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Attendance: ");
            int attendance = int.Parse(Console.ReadLine());

            if(mark > 40)
            {
                Console.WriteLine("Pass");
                
                if(attendance >= 75 && mark >= 80)
                {
                    Console.WriteLine("You got A+");
                }
                else
                {
                    Console.WriteLine("You got B");
                }
            }
            else
            {
                Console.WriteLine("Failed");
            }
        }
    }
}