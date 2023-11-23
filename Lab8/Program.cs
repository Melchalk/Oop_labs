using oop8.Animals;
using System.Text;

Hamster hamster = new();
Rooster rooster = new();
Turtle turtle = new();

Console.WriteLine(GetInfoAnimal(hamster));
Console.WriteLine();

Console.WriteLine(GetInfoAnimal(rooster));
Console.WriteLine();

Console.WriteLine(GetInfoAnimal(turtle));
Console.WriteLine();

string GetInfoAnimal(Animal animal)
{
    StringBuilder infoOfAnimal = new();

    infoOfAnimal.Append($"---Name of animal - {animal.Name}---\n");

    infoOfAnimal.Append($"Voice of animal: {animal.Say()}\n");

    infoOfAnimal.Append($"Animal movement: {animal.Move()}\n");

    if (animal is Hamster hamster)
    {
        infoOfAnimal.Append(hamster.GetDainty());
    }
    else if (animal is Rooster rooster)
    {
        infoOfAnimal.Append(rooster.BecomeAlpha());

        infoOfAnimal.Append('\n');

        infoOfAnimal.Append(rooster.StopBeingAlpha());
    }
    else if (animal is Turtle turtle)
    {
        infoOfAnimal.Append(turtle.Hide());
    }

    return infoOfAnimal.ToString();
}