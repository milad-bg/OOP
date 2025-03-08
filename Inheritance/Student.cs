namespace Inheritance;

public class Student : Person
{
    public Student(string name, int age, long studentNumber) : base(name, age)
    {
        _studentNumber = studentNumber;
    }

    private readonly long _studentNumber;

    public string GetStudentInfo()
    {
        return $"Name: {Name} Age: {Age} StudentNumber: {_studentNumber}";
    }
}