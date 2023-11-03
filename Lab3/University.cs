namespace Lab3;

internal class University
{
    readonly List<Student> students = new();

    public void AddStudent(Student newStudent)
    {
        students.Add(newStudent); //если студент уже есть
    }
    public void RemoveStudent(Student newStudent)
    {
        students.Remove(newStudent); //возвращение если студента нет
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