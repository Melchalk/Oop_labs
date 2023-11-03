namespace Lab1;

internal class Person
{
    public string Name { get; set; }
    public string Lastname { get; set; }
    public int Age { get; set; }
    public long PhoneNumber { get; set; }

    public Person() { }

    public Person(string name, string lastname, int age)
    {
        Name = name;
        Lastname = lastname;
        Age = age;
    }

    public void WhatIsPhoneNumber()
    {
        string inStr = (Name != null ? $" {Name} " : "");

        if (PhoneNumber > 0)
        {
            Console.WriteLine($"Номер телефона{inStr}: {PhoneNumber}");
        }
        else
        {
            Console.WriteLine($"Номер телефона{inStr}отсутствует.");
        }
    }
}