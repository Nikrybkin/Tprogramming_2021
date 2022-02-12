namespace CourseApp
{
    using System;

    public class Knight : Player
    {
        public Knight(string name, double health, int strength)
        : base(name, health, strength)
        {
            ClassPlayer = "Рыцарь";
            UltimateName = "Ярость";
        }

        public override int Ultimate(Player player, Player rival)
        {
            Logger.LoggerOutput($"{ClassPlayer} {Name} использовал суперспособность {UltimateName}!");
            return Strength = (int)(Strength * 13);
        }

        public override string Output()
        {
            return $"Класс: {ClassPlayer}; Имя: {Name}; Здоровье: {Health}; Сила {Strength}";
        }
    }
}