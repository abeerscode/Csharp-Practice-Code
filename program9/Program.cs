// Inheritance 

using System;
using System.Net;

namespace program9;

class Program
{
    static void Main(string [] Args)
    {
        Teacher t1 = new Teacher("Rahim", 101, 50000,"C#");
        t1.DisplayInfo("Teacher");
        t1.Teach();

        Developer d1 = new Developer("Karim", 102, 7000, "Python");
        d1.DisplayInfo("Developer");
        d1.Code();

        Manager m1 = new Manager("Abeer", 103, 9000, "IT");
        m1.DisplayInfo("Manager");
        m1.ManageTeam();
    }
}
class Employee
{
    public string name;
    public int id;
    public int salary;

    public void DisplayInfo(string employeeType)
    {
        Console.WriteLine(employeeType);
        Console.WriteLine("Name : " + name);
        Console.WriteLine("Id : " + id);
        Console.WriteLine("Salary : " + salary);
    }

}
class Teacher : Employee
{
    string subject;

    public Teacher(string name, int id, int salary, string subject)
    {
        this.name = name; 
        this.id = id;
        this.salary = salary;
        this.subject = subject;
    }
    public void Teach()
    {
        Console.WriteLine("Teaching: " + subject);
        System.Console.WriteLine("-----------------------------------------");

    }
}
class Developer : Employee
{
    string programmingLanguage;

    public Developer(string name, int id, int salary, string programmingLanguage)
    {
        this.name = name; 
        this.id = id;
        this.salary = salary;
        this.programmingLanguage = programmingLanguage;
    }
    public void Code()
    {
        Console.WriteLine("Programming Language: " + programmingLanguage);
        System.Console.WriteLine("-----------------------------------------");

    }
}

class Manager : Employee
{
    string department;

    public Manager(string name, int id, int salary, string department)
    {
        this.name = name; 
        this.id = id;
        this.salary = salary;
        this.department = department;
    }
    public void ManageTeam()
    {
        Console.WriteLine("Department: " + department);
        System.Console.WriteLine("-----------------------------------------");
    }
}