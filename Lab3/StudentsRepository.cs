using Lab3;
using System.Text;

namespace DataAccess;

static internal class StudentsRepository
{
    static readonly string _file = Directory.GetCurrentDirectory() + "/Students.txt";

    public static void Save(List<Student> students)
    {
        StringBuilder stringBuilder = new();
        foreach (Student student in students)
            stringBuilder.Append($"{student.Name}\n{student.LastName}\n{student.Age}\n{student.AverageScore}\n");

        File.WriteAllText(_file, stringBuilder.ToString());
    }

    public static List<Student> Read()
    {
        List<Student> students = new();
        var listOfStudent = File.ReadAllText(_file).Split('\n');

        //переделать считывание

        for (int i = 0; i < listOfStudent.Length - 1; i += 4)
        {
            Student student = new(listOfStudent[i], listOfStudent[i + 1], int.Parse(listOfStudent[i + 2]))
            {
                AverageScore = double.Parse(listOfStudent[i + 3])
            };
            students.Add(student);
        }

        return students;
    }
}