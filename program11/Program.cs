// Polymorphism

using System;

namespace program11;

class Program
{
    static void Main (string [] Args)
    {
        Animal a1 = new Animal();
        Animal a2 = new Dog();
        Animal a3 = new Cat();
        a1.Speak();
        a2.Speak();
        a3.Speak();


    }
}

class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal speaks");
    }
}

class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Dog says Woof");
    }
}

class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Cat says Meow");
    }
}
