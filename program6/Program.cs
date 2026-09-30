// Fibonacci Series

using System;

namespace program5;

class Program
{
    static void Main(string[] Args)
    {
        int first = 0;
        int second = 1;

        Console.Write("Fibonacci Series : ");
        Console.Write(first + " " + second + " ");

        for(int i = 0; i < 6; i++)
        {
            int next = first + second;
            first = second;
            second = next;

            Console.Write(next + " ");
        }
    }
}