// Constructors and Constructors Overloading
// Class - Car
// Objects - car1, car2
// Fields - model, year, color
// Constructors - Car(string, int, string), Car(string, string)

using System;

namespace program7;

class Program
{
    static void Main(string [] Args)
    {
        Car car1 = new Car("Ford",2021,"Red");
        Car car2 = new Car("Bugatti", "Purple");
    }
}
class Car
{
    public string model;
    public int year;
    public string color;
    public Car(string model, int year, string color)         // Constructors doesn't have any return type
    {
        this.model = model;
        this.year = year;
        this.color = color;

        Console.WriteLine(color + " " + model + " was launched in " + year);
    }

    public Car(string model, string color)        
    {
        this.model = model;
        this.color = color;

        Console.WriteLine("That's a " + color + " color " + model);
    }
    
}