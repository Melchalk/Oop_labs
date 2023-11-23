namespace oop8.Animals;

internal class Rooster : Animal
{
    public override string Name { get; set; } = "Rooster";
    public override string Voice { get; set; } = "Crowing"; //кукарекань
    public bool IsAlpha { get; set; }

    public Rooster()
    {
        IsAlpha = false;
    }

    public Rooster(bool isAlpha)
    {
        IsAlpha = isAlpha;
    }

    public override string Move()
    {
        return $"{Name} is goes";
    }

    public override string Say()
    {
        return $"{Name} is {Voice.ToLower()}";
    }

    public string BecomeAlpha()
    {
        if (IsAlpha)
        {
            return "It is already alpha";
        }
        else
        {
            IsAlpha = true;

            return "Now it is alpha";
        }
    }

    public string StopBeingAlpha()
    {
        if (!IsAlpha)
        {
            return "It is not alpha";
        }
        else
        {
            return "Now it is not alpha";
        }
    }
}