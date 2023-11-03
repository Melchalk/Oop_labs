using Lab3;
using DataAccess;

University university = new();
Student student1 = new("Вася", "Петров", 20)
{
    AverageScore = 4.5
};
university.AddStudent(student1);
Student student2 = new("Максим", "Авраменко", 18);
university.AddStudent(student2);

StudentsRepository.Save(university.GetStudents());


University university2 = new();
foreach (var student in StudentsRepository.Read())
{
    university2.AddStudent(student);
}