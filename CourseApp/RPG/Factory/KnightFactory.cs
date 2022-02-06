namespace CourseApp
{
    using System;

    public class KnightFactory : Factory
    {
        public override Player FactoryMethod(string name, double health, int strength)
        {
            return new Knight(name, health, strength);
        }
    }
}