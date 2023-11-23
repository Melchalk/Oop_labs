namespace oop8.Animals;

internal class Turtle : Animal
{
    public override string Name { get; set; } = "Turtle";
    public override string Voice { get; set; } = "Hissing";
    public bool CanSwim { get; set; }

    public Turtle()
    {
        CanSwim = false;
    }

    public Turtle(bool canSwim)
    {
        CanSwim = canSwim;
    }

    public override string Move()
    {
        return $"{Name} is crawling";
    }

    public override string Say()
    {
        return $"{Name} is {Voice.ToLower()}";
    }

    public string Hide()
    {
        return $"{Name} hid in the shell";
    }
}