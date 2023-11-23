using DataAccess;
using oop5;

University university = new();

if (!StudentsRepository.IsRepositoryEmpty())
{
    foreach (var student in StudentsRepository.Read())
    {
        university.AddStudent(student);

        Console.WriteLine(HumanRepository.GetInfo(student.ID));
    }
}
else
{
    Name name1 = new("Петров", "Вася", "Андреевич");
    Student student1 = new(name1, new DateOnly(2004, 12, 24))
    {
        AverageScore = 4.5
    };

    university.AddStudent(student1);

    Name name2 = new("Авраменко", "Максим", "Сергеевич");
    Student student2 = new(name2, new DateOnly(2005, 7, 15));

    university.AddStudent(student2);

    StudentsRepository.Save(university.GetStudents());
}