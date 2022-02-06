namespace CourseApp
{
    using System;

    public class Mage : Player
    {
        public Mage(string name, double health, double strength)
        : base(name, health, strength)
        {
        }

        public override double UseUlt()
        {
            if (IsFrozen == 0)
            {
                IsFrozen = 1;
            }

            Console.WriteLine($"{Name} заморозил оппонента!");
            return IsFrozen;
        }
    }
}