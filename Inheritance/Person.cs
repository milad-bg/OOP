namespace Inheritance;

public class Person
{
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    protected string Name { get; private set; }
    protected int Age { get; private set; }
}