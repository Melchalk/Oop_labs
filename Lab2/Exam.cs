namespace Lab2;

internal struct Exam
{
    public string title;
    public int assessment;

    public Exam(string title, int assessment)
    {
        this.title = title;
        this.assessment = assessment;
    }

    public Exam Copy()
    {
        Exam exam = this;

        return exam;
    }

    public Exam Copy(int assessment)
    {
        Exam exam = this with { assessment = assessment };

        return exam;
    }

    public Exam Copy(string title)
    {
        Exam exam = this with { title = title };

        return exam;
    }

    public string InfoOfExam()
    {
        return $"Title of exam- {title}\t Assessment - {assessment}\n";
    }
}