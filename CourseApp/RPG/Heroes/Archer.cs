namespace CourseApp
{
    using System;

    public class Archer : Player
    {
        public Archer(string name, double health, int strength)
        : base(name, health, strength)
        {
            ClassPlayer = "Лучник";
            UltimateName = "Ядовитый выстрел";
        }

        public override int Ultimate(Player player, Player rival)
        {
            UltimateDamage = 20;
            Logger.LoggerOutput($"{ClassPlayer} {Name} использовал суперпособность {UltimateName}!");
            return Strength += UltimateDamage;
        }

        public override string Output()
        {
            return $"Класс: {ClassPlayer}; Имя: {Name}; Здоровье: {Health}; Сила {Strength}";
        }
    }
}