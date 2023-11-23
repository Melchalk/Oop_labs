using oop5;
using System.Text;

namespace DataAccess;

static internal class StudentsRepository
{
    static string _file = Directory.GetCurrentDirectory() + "/Students.txt";

    public static void Save(Dictionary<int, Student> students)
    {
        StringBuilder stringBuilder = new();

        for (int indexStudent = 0; indexStudent < students.Count; indexStudent++)
        {
            Student student = students[indexStudent];

            stringBuilder.Append($"{student.Fullname.LastName}\t" +
                $"{student.Fullname.FirstName}\t" +
                $"{student.Fullname.MiddleName}\t" +
                $"{student.Birthday}\n" +
                $"{student.AverageScore}\t" +
                $"{student.GetStudentId()}");

            if (indexStudent != students.Count - 1)
            {
                stringBuilder.Append('\n');
            }
        }

        File.WriteAllText(_file, stringBuilder.ToString());
    }

    public static List<Student> Read()
    {
        List<Student> students = new();

        var listOfStudent = File.ReadAllText(_file).Split('\n');

        for (int i = 0; i < listOfStudent.Length; i++)
        {
            var infoStudent = listOfStudent[i].Split('\t');

            Name name = new(infoStudent[0], infoStudent[1], infoStudent[2]);
            DateOnly dateOnly = DateOnly.Parse(infoStudent[3]);
            int id = int.Parse(infoStudent[5]);

            Student student = new(name, dateOnly, id)
            {
                AverageScore = double.Parse(infoStudent[4])
            };

            students.Add(student);
        }

        return students;
    }

    public static bool IsRepositoryEmpty()
    {
        return File.ReadAllText(_file).Length == 0;
    }

    public static void Clear()
    {
        File.Delete(_file);
    }
}