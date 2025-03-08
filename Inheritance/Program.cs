namespace Inheritance;

public static class Program
{
    public static void Main(string[] args)
    {
        var newStudent = new Student("ali rezai", 21, 98551235);
        newStudent.GetStudentInfo();

        var newTeacher = new Teacher("ali abdi", 44, 123);
        newTeacher.GetStudentInfo();
    }
}