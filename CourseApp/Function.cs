namespace CourseApp
{
    using System;
    using System.Collections.Generic;

    public class Function
    {
        public double CalculateFunction(double a, double b, double x)
        {
            return Math.Round((Math.Pow(Math.Pow(x - a, 2), 1.0 / 3.0) + Math.Pow(Math.Abs(x + b), 1.0 / 5.0)) / Math.Pow(Math.Pow(x, 2) - Math.Pow(a - b, 2), 1.0 / 9.0), 3);
        }
    }
}