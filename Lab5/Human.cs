namespace oop5;

internal class Human
{
    static int commonID = 0; //условие лабораторной
    Name _fullname;
    DateOnly _birthday;
    int _id;

    public Name Fullname { get { return _fullname; } }
    public DateOnly Birthday { get { return _birthday; } }
    public int ID { get { return _id; } }

    public Human(Name name, DateOnly birthday)
    {
        _fullname = name;
        _birthday = birthday;
        _id = ++commonID;

        HumanRepository.AddHuman(this);
    }
}