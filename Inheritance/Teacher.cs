namespace Inheritance;

public class Teacher : Person
{
    public Teacher(string name, int age, long teacherNumber) : base(name, age)
    {
        _teacherNumber = teacherNumber;
    }

    private readonly long _teacherNumber;

    public string GetStudentInfo()
    {
        return $"Name: {Name} Age: {Age} StudentNumber: {_teacherNumber}";
    }
}