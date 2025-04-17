namespace BaseClass;

public class Fish : Animal
{
    public override void Breath()
    {
        Console.WriteLine("Fish breathes");
    }

    public override void Move()
    {
        Console.WriteLine("Fish moves by crawling");
    }

    public override void Eat()
    {
        Console.WriteLine("Fish eats without chewing");
    }

    public void Swim()
    {
        Console.WriteLine("Fish can swim");
    }
}