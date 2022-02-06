namespace CourseApp
{
    using System;

    public class ArcherFactory : Factory
    {
        public override Player FactoryMethod(string name, double health, int strength)
        {
            return new Archer(name, health, strength);
        }
    }
}