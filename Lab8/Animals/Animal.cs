namespace oop8.Animals;

internal abstract class Animal
{
    public abstract string Name { get; set; }
    public abstract string Voice { get; set; }

    public abstract string Say();

    public abstract string Move();
}