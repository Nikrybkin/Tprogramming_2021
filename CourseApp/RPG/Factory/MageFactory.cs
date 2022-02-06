namespace CourseApp
{
    using System;

    public class MageFactory : Factory
    {
        public override Player FactoryMethod(string name, double health, int strength)
        {
            return new Mage(name, health, strength);
        }
    }
}