﻿using System.Text;
namespace Lab3;

internal class Student
{
    const string notSet = "Не задано";
    string _name;
    string _lastName;
    int _age;
    double _averageScore;

    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            if (value == null)
                _name = notSet;
            else
                _name = value;
        }
    }
    public string LastName
    {
        get
        {
            return _lastName;
        }
        set
        {
            if (value == null)
                _lastName = notSet;
            else
                _lastName = value;
        }
    }
    public int Age
    {
        get
        {
            return _age;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Age must be positive");
            }
            else
            {
                _age = value;
            }
        }
    }
    public double AverageScore
    {
        get
        {
            return _averageScore;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Average score must be positive");
            }
            else if (value > 5)
            {
                throw new ArgumentException("Average score must be less than 5");
            }
            else
            {
                _averageScore = value;
            }
        }
    }

    public Student(string name, string lastName, int age)
    {
        Name = name;
        LastName = lastName;
        Age = age;
        AverageScore = 0;
    }
}