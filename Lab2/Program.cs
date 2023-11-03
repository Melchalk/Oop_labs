using Lab2;

Student student1 = new("Vasya", "221-345");
student1.NewExams(new Exam("Databases", 3), new Exam("Conflictology", 5));

Console.WriteLine(student1.InfoOfStudent());
Console.WriteLine(student1.InfoOfExams());

//exam will not add
Exam exam = new()
{ assessment = 3 };

student1.NewExams(exam);
Console.WriteLine(student1.InfoOfStudent());

Exam databases1 = new("Databases", 4);
Console.WriteLine(databases1.InfoOfExam());

student1.ChangeExam(databases1);
Console.WriteLine(student1.InfoOfExams());

Student student2 = student1.Copy("Max");
Console.WriteLine(student2.InfoOfExams());

//Copied student of the class without changes to the old instance
Exam databases2 = databases1.Copy(5);
Console.WriteLine(databases2.InfoOfExam());

student2.ChangeExam(databases2);
Console.WriteLine(student2.InfoOfExams());