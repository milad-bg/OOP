namespace BaseClass;

public static class Program
{
    public static void Main(string[] args)
    {
        var fish = new Fish();
        fish.Breath();
        fish.Swim();


        var dog = new Dog();
        dog.Breath();
        dog.bark();
    }
}