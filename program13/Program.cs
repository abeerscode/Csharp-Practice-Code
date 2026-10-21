using System;
using System.Collections.Generic;

namespace program13;

class Program
{
    static void Main(string[] args)
    {
        // ---------- 1. List of a simple type ----------

        List<int> num = new List<int> { 1, 2, 3, 4 };
        foreach (int i in num)
        {
            Console.WriteLine(i);
        }


        // ---------- 2. List of objects  -----------
        List<Student> students = new List<Student>();                 // Student = class; students = list

        Student s1 = new Student();                                   // Create object of Student and assign values
        s1.Name = "Ratul";
        s1.Id = 23;

        students.Add(s1);                                             // Add the object to the list

        foreach (Student student in students)
        {
            Console.WriteLine($"{student.Name} {student.Id}");
        }


        // ---------- 3. List of objects (shortcut) ----------
        List<Student> students1 = new List<Student>();

        students1.Add(new Student
        {
            Name = "Abeer",
            Id = 123
        });

        foreach (Student student in students1)
        {
            Console.WriteLine($"{student.Name} {student.Id}");
        }
    }
}

class Student
{
    public string Name { get; set; }
    public int Id { get; set; }
}