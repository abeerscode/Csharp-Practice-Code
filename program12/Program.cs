// get; set; in C# 

using System;
using System.Dynamic;

namespace program12;

class Program
{
    static void Main(string [] Args)
    {
        Student student = new Student();
        student.Name = "Abeer";
        student.Id = 2310;
        student.Display();
    }
}

class Student
{
    public int Id {get; set;}
    public string Name {get; set;}

    public void Display()
    {
        Console.WriteLine($"Name: {Name}, Id: {Id}");
    }
}