namespace oop8.Animals;

internal class Hamster : Animal
{
    public override string Name { get; set; } = "Hamster";
    public override string Voice { get; set; } = "Snorting"; //Фырчание
    public string Dainty { get; set; } = "Seeds";

    public override string Move()
    {
        return $"{Name} is running";
    }

    public string HaveFun()
    {
        return $"{Name} is running in the wheel";
    }

    public override string Say()
    {
        return $"{Name} is {Voice.ToLower()}";
    }

    public string GetDainty()
    {
        return $"{Name} got {Dainty.ToLower()}";
    }
}