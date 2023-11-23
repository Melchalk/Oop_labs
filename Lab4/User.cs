namespace oop4;

internal class User
{
    string _name;
    int _age;

    Guid ID { get; set; }

    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
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
            if (value >= 0)
            {
                _age = value;
            }
        }
    }

    public bool CorrectAge
    {
        get
        {
            return _age < 25;
        }
    }

    public User()
    {
        ID = Guid.NewGuid();
    }

    public string GetInfo()
    {
        return $"Имя пользователя - {_name}\n" +
            $"ID - {ID}\n" +
            $"Возвраст - {_age}";
    }

    public string GetInfo(bool includeIntProperty)
    {
        string output = $"Имя пользователя - {_name}\n" +
            $"ID - {ID}\n";

        if (includeIntProperty)
        {
            output += $"Возвраст - {_age}";
        }

        return output;
    }

}