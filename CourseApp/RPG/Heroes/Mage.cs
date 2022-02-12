namespace CourseApp
{
    using System;

    public class Mage : Player
    {
        public Mage(string name, double health, int strength)
        : base(name, health, strength)
        {
            ClassPlayer = "Маг";
            UltimateName = "Превращение в пепел";
        }

        public override int Ultimate(Player player, Player rival)
        {
            if (player.Effect)
            {
                player.Afk = 10;
                rival.Afk = 20;
            }
            else if (rival.Effect)
            {
                player.Afk = 20;
                rival.Afk = 10;
            }

            Logger.LoggerOutput($"{ClassPlayer} {Name} использовал суперспособность {UltimateName}!");
            return 0;
        }

        public override string Output()
        {
            return $"Призвание: {ClassPlayer}; Имя: {Name}; Здоровье: {Health}; Сила {Strength}";
        }
    }
}