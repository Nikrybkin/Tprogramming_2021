namespace CourseApp
{
    using System;

    public class Mage : Player
    {
        public Mage(string name, double health, int strength)
        : base(name, health, strength)
        {
            ClassPlayer = "Маг гильдии";
            UltimateName = "Превращение в камень";
        }

        public override int Ultimate(Player player, Player rival)
        {
            player.Afk = 2;
            rival.Afk = 2;
            Logger.LoggerOutput($"{ClassPlayer} {Name} использовал имбу {UltimateName}!");
            return 0;
        }

        public override string InfoOutput()
        {
            return $"Призвание: {ClassPlayer} ; Имя бойца: {Name} ; Здоровье бойца: {Health} ; Сила бойца {Strength}";
        }
    }
}