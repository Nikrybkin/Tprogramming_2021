namespace CourseApp
{
    using System;

    public abstract class Player : IPlayer
    {
        private readonly Random random = new Random();
        private string[] arrayOfName = new string[20]
        {
            "Мерлин",
            "Геральт",
            "Эльдайн",
            "Кейра",
            "Мортра",
            "Виллентретенмерт",
            "Алёшка",
            "Шон",
            "Рикки",
            "Кирито",
            "Иоверт",
            "Ширру",
            "Керис",
            "Хьялмар",
            "Имлерих",
            "Эредин",
            "Кольгрим",
            "Весемир",
            "Лидия",
            "Фукусья",
        };

        public Player(string name, double health, int strength)
        {
            health = random.Next(100, 130);
            strength = random.Next(10, 20);
            name = arrayOfName[random.Next(0, 20)];
            this.Name = name;
            this.Health = health;
            this.Strength = strength;
            this.Afk = 0;
            this.Effect = false;
        }

        public int Afk { get; set; }

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

        public int AtTheAttack(Player warrior, Player warriorRival)
        {
            if (warrior.Effect == true)
            {
                warrior.Effect = false;
                return DamageInfo = warrior.Ultimate(warrior, warriorRival);
            }
            else
            {
                return DamageInfo = Strength;
            }
        }

        public virtual string InfoOutput()
        {
            return @$"Имя бойца: {Name} ; Здоровье бойца: {Health} ; Сила бойца: {Strength}";
        }
    }
}