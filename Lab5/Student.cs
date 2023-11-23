namespace oop5;

internal class Student : Human
{
    double _averageScore;
    readonly int studentID;

    public double AverageScore
    {
        get
        {
            return _averageScore;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Average score must be positive");
            }
            else if (value > 5)
            {
                throw new ArgumentException("Average score must be less than 5");
            }
            else
            {
                _averageScore = value;
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