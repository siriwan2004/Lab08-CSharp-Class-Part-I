using System;

class Program
{
    static void Main()
    {
        Person p = new Person();
        p.Name = "Rambo";  // Using properties
        p.Id = "1987";
        p.Income = 2500;

        Console.WriteLine($"Type of p is {p.GetType()}");
        Console.WriteLine($"p.Name = {p.Name}\ttype = {p.Name.GetType()}");
        Console.WriteLine($"p.Id = {p.Id}\ttype = {p.Id.GetType()}");
        Console.WriteLine($"p.Income = {p.Income}\ttype = {p.Income.GetType()}");
    }
}

class Person
{
    // Use public properties with get and set
    public string Name { get; set; }
    public string Id { get; set; }
    public int Income { get; set; }

    // Constructor to initialize fields (optional)
    public Person()
    {
        Name = "";
        Id = "";
        Income = 0;
    }
}
