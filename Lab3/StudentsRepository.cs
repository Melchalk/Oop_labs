using Lab3;
using System.Text;

namespace DataAccess;

static internal class StudentsRepository
{
    static readonly string _file = Directory.GetCurrentDirectory() + "/Students.txt";

    public static void Save(List<Student> students)
    {
        StringBuilder stringBuilder = new();

        for (int indexStudent = 0; indexStudent < students.Count; indexStudent++)
        {
            Student student = students[indexStudent];

            stringBuilder.Append($"{student.Name}\t{student.LastName}\t{student.Age}\t{student.AverageScore}");

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


        for (int i = 0; i < listOfStudent.Length; i += 1)
        {
            var infoStudent = listOfStudent[i].Split('\t');

            Student student = new(infoStudent[0], infoStudent[1], int.Parse(infoStudent[2]))
            {
                AverageScore = double.Parse(infoStudent[3])
            };

            students.Add(student);
        }

        return students;
    }
}