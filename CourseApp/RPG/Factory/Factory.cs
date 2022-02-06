namespace CourseApp
{
    public abstract class Factory
    {
        public abstract Player FactoryMethod(string name, double health, int strength);
    }
}