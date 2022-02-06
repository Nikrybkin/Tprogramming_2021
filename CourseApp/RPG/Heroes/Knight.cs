namespace CourseApp
{
    using System;

    public class Knight : Player
    {
        public Knight(string name, double health, int strength)
        : base(name, health, strength)
        {
            this.ClassPlayer = "Рыцарь чести";
            this.UltimateName = "Ярость богов";
        }

        public override int Ultimate(Player player, Player rival)
        {
            Console.WriteLine($"{ClassPlayer} {Name} использовал ультимативную способность {UltimateName}!");
            return UltimateDamage = (int)(Strength * 1.3);
        }

        public override string InfoOutput()
        {
            return @$"Призвание: {ClassPlayer} ; Имя бойца: {Name} ; Здоровье бойца: {Health} ; Сила бойца {Strength}";
        }
    }
}