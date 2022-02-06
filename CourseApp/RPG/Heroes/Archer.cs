namespace CourseApp
{
    using System;

    public class Archer : Player
    {
        public Archer(string name, double health, int strength)
        : base(name, health, strength)
        {
            this.ClassPlayer = "Лучник";
            this.UltimateName = "Ядовитый выстрел";
        }

        public override int Ultimate(Player player, Player rival)
        {
            UltimateDamage = 2;
            Console.WriteLine($"{ClassPlayer} {Name} использовал ультимативную способность {UltimateName}!");
            return Strength + UltimateDamage;
        }

        public override string InfoOutput()
        {
            return @$"Призвание: {ClassPlayer} ; Имя бойца: {Name} ; Здоровье бойца: {Health} ; Сила бойца {Strength}";
        }
    }
}