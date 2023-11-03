using System.Text;

namespace Lab2;

internal class Student
{
    string _name;
    string _group;
    List<Exam> _testBook;

    public Student(string name, string group)
    {
        _name = name;
        _group = group;
        _testBook = new List<Exam>();
    }

    public void NewExams(params Exam[] exams)
    {
        foreach (var exam in exams)
        {
            if (_testBook.Contains(exam) || exam.title == null || exam.assessment == 0)
            {
                continue;
            }

            _testBook.Add(exam);
        }
    }

    public void ChangeExam(Exam exam)
    {
        for (int indexExam = 0; indexExam < _testBook.Count; indexExam++)
        {
            if (_testBook[indexExam].title == exam.title)
            {
                _testBook[indexExam] = exam;

                break;
            }
        }
    }

    public Student Copy()
    {
        Student student = new(_name, _group);
        student.NewExams(_testBook.ToArray());

        return student;
    }

    public Student Copy(string change)
    {
        Student student;

        if (char.IsDigit(change[0])) //при условии, что номер группы оформлен так же, как в Московском политехе
        {
            student = new Student(_name, change);
        }
        else
        {
            student = new Student(change, _group);
        }

        student.NewExams(_testBook.ToArray());

        return student;
    }

    public Student Copy(List<Exam> exams)
    {
        Student student = new(_name, _group);
        student.NewExams(exams.ToArray());

        return student;
    }

    public List<Exam> GetExams()
    => _testBook;

    public string InfoOfStudent()
    {
        return $"{_name}\t{_group}\nQuantity exams - {_testBook.Count}\n";
    }

    public string InfoOfExams()
    {
        StringBuilder exams = new StringBuilder();

        exams.AppendLine($"Student's test book {_name}");

        foreach (var exam in _testBook)
        {
            exams.AppendLine($"{exam.title}\t{exam.assessment}");
        }

        return exams.ToString();
    }
}
