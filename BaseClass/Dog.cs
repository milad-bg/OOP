namespace BaseClass;

public class Dog : Animal
{
    public override void Breath()
    {
        Console.WriteLine("Dog Breaths");
    }

    public override void Move()
    {
        Console.WriteLine("Dog moves by its feet and hands");
    }

    public override void Eat()
    {
        Console.WriteLine("Dog eats and chews by its teeth");
    }

    public void bark()
    {
        Console.WriteLine("Dog poos");
    }
}