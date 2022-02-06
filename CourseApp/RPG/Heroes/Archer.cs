namespace CourseApp
{
    using System;

    public class Archer : Player
    {
        public Archer(string name, double health, double strength)
        : base(name, health, strength)
        {
        }

        public override double UseUlt()
        {
            if (IsFire == 0)
            {
                IsFire = 1;
            }

            Console.WriteLine($"{Name} запустил огненные стрелы!");
            return IsFire;
        }
    }
}