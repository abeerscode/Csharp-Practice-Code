// Inheritance with Base
 
using System;

namespace program9;

class Program
{
    static void Main(string[] args)
    {
        Teacher t1 = new Teacher("Rahim", 101, 50000, "C#");
        t1.DisplayInfo("Teacher");
        t1.Teach();

        Developer d1 = new Developer("Karim", 102, 70000, "Python");
        d1.DisplayInfo("Developer");
        d1.Code();

        Manager m1 = new Manager("Abeer", 103, 90000, "IT");
        m1.DisplayInfo("Manager");
        m1.ManageTeam();
    }
}

class Employee
{
    public string name;
    public int id;
    public int salary;

    public Employee(string name, int id, int salary)
    {
        this.name = name;
        this.id = id;
        this.salary = salary;
    }

    public void DisplayInfo(string employeeType)
    {
        Console.WriteLine(employeeType);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Salary: " + salary);
    }
}

class Teacher : Employee
{
    string subject;

    public Teacher(string name, int id, int salary, string subject)
        : base(name, id, salary)
    {
        this.subject = subject;
    }

    public void Teach()
    {
        Console.WriteLine("Teaching: " + subject);
        Console.WriteLine("-----------------------------------------");
    }
}

class Developer : Employee
{
    string programmingLanguage;

    public Developer(string name, int id, int salary, string programmingLanguage)
        : base(name, id, salary)
    {
        this.programmingLanguage = programmingLanguage;
    }

    public void Code()
    {
        Console.WriteLine("Programming Language: " + programmingLanguage);
        Console.WriteLine("-----------------------------------------");
    }
}

class Manager : Employee
{
    string department;

    public Manager(string name, int id, int salary, string department)
        : base(name, id, salary)
    {
        this.department = department;
    }

    public void ManageTeam()
    {
        Console.WriteLine("Department: " + department);
        Console.WriteLine("-----------------------------------------");
    }
}