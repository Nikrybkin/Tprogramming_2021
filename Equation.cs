namespace CourseApp
{
    using System;

    public class Equation // вариант 19
    {
        public double Function(double x = 0, double a = 2.0)
        {
            return Math.Pow(Math.Log10(a + x), 2) / Math.Pow(a + x, 2);
        }

        public double[] TaskA(double xn, double xk, double dx)
        {
            double[] results = new double[(int)(((xk - xn) / dx) + 1)];
            int i = 0;
            while (xn <= xk)
            {
                results[i] = Function(xn);
                i++;
                xn = xn + dx;
            }

            return results;
        }

        public double[] TaskB(double[] numbers)
        {
            double[] results = new double[numbers.Length];
            int g = 0;
            foreach (double i in numbers)
            {
                results[g] = Function(i);
                g++;
            }

            return results;
        }
    }
}