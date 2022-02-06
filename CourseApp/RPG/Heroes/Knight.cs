namespace CourseApp
{
    using System;

    public class Knight : Player
{
    public Knight(string name, int health, int strength)
    : base(name, health, strength)
    {
    }

    public override double UseUlt()
    {
        Strength = Math.Floor(Strength * 1.30);
        Console.WriteLine($"{Name} использовал усиление урона на 30%!");
        return Strength;
    }
}
}