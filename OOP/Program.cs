using OOP.Encapsulation;

namespace OOP;

public static class Program
{
    public static void Main(string[] args)
    {
        // Encapsulation
        var newCar = new Benz("C200");

        // Internal methods of the Benz class are not visible from outside of the class
        Console.WriteLine($"Car name is: {newCar.Name} which is readOnly");
        newCar.Start();
    }
}