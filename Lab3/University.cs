namespace Lab3;

internal class University
{
    readonly List<Student> students = new();

    public void AddStudent(Student newStudent)
    {
        students.Add(newStudent); 
    }
    public bool RemoveStudent(Student newStudent)
    {
        return students.Remove(newStudent);
    }
    public int FindStudent(Student student)
    {
        return students.IndexOf(student);
    }

    public List<Student> GetStudents()
    {
        return students;
    }
}