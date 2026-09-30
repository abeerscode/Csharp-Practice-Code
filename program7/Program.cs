// Class and Objects
// Class - Car
// Object - car1
// Fields - model, year, color
// Methods - display()

using System;

namespace program7;

class Program
{
    static void Main(string [] Args)
    {
        Car car1 = new Car();
        car1.model = "Ford";
        car1.year = 2021;
        car1.color = "Red";

        car1.display();
    }
}
class Car
{
    public string model;
    public int year;
    public string color;
    public void display()
    {
        Console.WriteLine(color + " " + model + " was launched in " + year);
    }
}