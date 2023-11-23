namespace oop5;

internal class University
{
    readonly Dictionary<int, Student> students = new();

    public void AddStudent(Student newStudent)
    {
        students.Add(newStudent.GetStudentId(), newStudent);
    }

    public bool RemoveStudent(Student student)
    {
        int id = students.FirstOrDefault(x => x.Value == student).Key;

        return students.Remove(id);
    }

    public int FindStudent(Student student)
    {
        return students.FirstOrDefault(x => x.Value == student).Key;
    }

    public Dictionary<int, Student> GetStudents()
    {
        return students;
    }
}