using System.Security.Cryptography;
using System.Xml.Linq;

namespace oop5;

internal class Student : Human
{
    double averageScore;
    readonly int studentID;

    public double AverageScore
    {
        get
        {
            return averageScore;
        }
        set
        {
            if (value < 0)
            {
                averageScore = 0;
            }
            else if (value > 5)
            {
                averageScore = 5;
            }
            else
            {
                averageScore = value;
            }
        }
    }

    public Student(Name name, DateOnly date) : base(name, date)
    {
        AverageScore = 0;
        studentID = new Random().Next();
    }

    public Student(Name name, DateOnly date, int id) : base(name, date)
    {
        AverageScore = 0;
        studentID = id;
    }

    public int GetStudentId()
    {
        return studentID;
    }
}