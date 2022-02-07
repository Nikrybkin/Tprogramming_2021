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

        public int DamageInfo { get; set; }

        public double Health { get; set; }

        public int Strength { get; set; }

        public virtual int Ultimate(Player player, Player rival)
        {
            return 0;
        }

        public int AtTheAttackWarrior(Player warrior, Player warriorRival)
        {
            if (warrior.Effect)
            {
                warrior.Effect = false;
                return DamageInfo = warrior.Ultimate(warrior, warriorRival);
            }
            else
            {
                return DamageInfo = Strength;
            }
        }

        public int AtTheAttackWarriorRival(Player warrior, Player warriorRival)
        {
            if (warriorRival.Effect)
            {
                warriorRival.Effect = false;
                return DamageInfo = warriorRival.Ultimate(warrior, warriorRival);
            }
            else
            {
                return DamageInfo = Strength;
            }
        }

        public virtual string InfoOutput()
        {
            return $"Имя бойца: {Name} ; Здоровье бойца: {Health} ; Сила бойца: {Strength}";
        }

        public void GetDamage(int damage)
        {
            Health -= damage;
        }

        public void ResetHealth()
        {
            Health = DefaultHealth;
        }
    }
}