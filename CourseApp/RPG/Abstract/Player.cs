namespace CourseApp
{
    using System;

    public abstract class Player : IPlayer
    {
        private double health;
        private double strength;
        private Random random = new Random();
        private double isFire = 0;
        private double isFrozen = 0;

        public Player(string name, double health, double strength)
        {
            health = random.Next(30, 50);
            strength = random.Next(5, 10);
            this.Name = name;
            this.Health = health;
            this.Strength = strength;
            this.IsFrozen = isFrozen;
            this.IsFire = isFire;
        }

        public string Name { get; set; }

        public double Health
        {
            get
            {
                return health;
            }

            set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("Не верное значение");
                }
                else
                {
                    health = value;
                }
            }
        }

        public double Strength
        {
            get
            {
                return strength;
            }

            set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("Не верное значение");
                }
                else
                {
                    strength = value;
                }
            }
        }

        public virtual double IsFrozen { get; set; }

        public virtual double IsFire { get; set; }

        public virtual double UseUlt()
        {
            return strength;
        }
    }
}