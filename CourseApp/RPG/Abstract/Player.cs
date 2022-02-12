namespace CourseApp
{
    using System;

    public abstract class Player : IPlayer
    {
        public Player(string name, double health, int strength)
        {
            Name = name;
            Health = health;
            Strength = strength;
            Afk = 0;
            Effect = false;
            DefaultHealth = health;
        }

        public int Afk { get; set; }

        public double DefaultHealth { get; set; }

        public string Name { get; set; }

        public string ClassPlayer { get; set; }

        public bool Effect { get; set; }

        public string UltimateName { get; set; }

        public int UltimateDamage { get; set; }

        public int InfoAboutDamage { get; set; }

        public double Health { get; set; }

        public int Strength { get; set; }

        public virtual int Ultimate(Player player, Player rival)
        {
            return 0;
        }

        public int Attack(Player soldier, Player soldierRival)
        {
            if (soldier.Effect)
            {
                soldier.Effect = false;
                return InfoAboutDamage = soldier.Ultimate(soldier, soldierRival);
            }
            else
            {
                return InfoAboutDamage = Strength;
            }
        }

        public int AttackAntagonist(Player soldier, Player soldierRival)
        {
            if (soldierRival.Effect)
            {
                soldierRival.Effect = false;
                return InfoAboutDamage = soldierRival.Ultimate(soldier, soldierRival);
            }
            else
            {
                return InfoAboutDamage = Strength;
            }
        }

        public virtual string Output()
        {
            return $"Имя: {Name} ; Здоровье: {Health} ; Сила: {Strength}";
        }

        public void Damage(int damage)
        {
            Health -= damage;
        }

        public void ResetHealth()
        {
            Health = DefaultHealth;
        }
    }
}