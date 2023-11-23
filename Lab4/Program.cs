using oop4;

User user = new()
{
    Age = 25,
    Name = "Вася"
};

Console.WriteLine(user.GetInfo());

//Возраст не изменится
user.Age = -5;
Console.WriteLine(user.GetInfo());

//Вывод без возраста
Console.WriteLine(user.GetInfo(false));