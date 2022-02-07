namespace CourseApp
{
    using System;

    public class Knight : Player
    {
        public Knight(string name, double health, int strength)
        : base(name, health, strength)
        {
            ClassPlayer = "Рыцарь чести";
            UltimateName = "Ярость богов";
        }

        public override int Ultimate(Player player, Player rival)
        {
            Logger.LoggerOutput($"{ClassPlayer} {Name} использовал ультимативную способность {UltimateName}!");
            return Strength = (int)(Strength * 1.3);
        }

        public override string InfoOutput()
        {
            return $"Призвание: {ClassPlayer} ; Имя бойца: {Name} ; Здоровье бойца: {Health} ; Сила бойца {Strength}";
        }
    }
}