namespace oop5;

internal struct Name
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MiddleName { get; set; }

    public Name(string lastName, string firstName, string patronymic)
    {
        LastName = lastName;
        FirstName = firstName;
        MiddleName = patronymic;
    }
}