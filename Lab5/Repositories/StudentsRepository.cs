using oop5;
using System.Text;
using System.Xml.Linq;

namespace DataAccess;

static internal class StudentsRepository
{
    static string file = Directory.GetCurrentDirectory() + "/Students.txt";

    public static void Save(Dictionary<int, Student> students)
    {
        StringBuilder stringBuilder = new();
        foreach (Student student in students.Values)
        {
            stringBuilder.Append($"{student.Fullname.LastName}\n" +
                $"{student.Fullname.FirstName}\n" +
                $"{student.Fullname.Patronymic}\n" +
                $"{student.Birthday}\n" +
                $"{student.AverageScore}\n" +
                $"{student.GetStudentId()}\n");
        }

        File.WriteAllText(file, stringBuilder.ToString());
    }

    public static List<Student> Read()
    {
        List<Student> students = new();
        var listOfStudent = File.ReadAllText(file).Split('\n');
        for (int i = 0; i < listOfStudent.Length - 1; i += 6)
        {
            Name name = new(listOfStudent[i], listOfStudent[i + 1], listOfStudent[i + 2]);
            DateOnly dateOnly = DateOnly.Parse(listOfStudent[i + 3]);
            int id = int.Parse(listOfStudent[i + 5]);
            Student student = new(name, dateOnly, id)
            {
                AverageScore = double.Parse(listOfStudent[i + 4])
            };
            students.Add(student);
        }

        return students;
    }

    public static bool IsRepositoryEmpty()
    {
        if (File.ReadAllText(file).Length == 0)
            return true;

        return false;
    }

    public static void Clear()
    {
        File.Delete(file);
    }
}