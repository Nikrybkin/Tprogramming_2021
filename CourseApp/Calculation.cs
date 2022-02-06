namespace CourseApp
{
    using System;
    using System.Collections.Generic;

    public class Calculation
    {
        private Function _mainFunc;

        public Calculation(Function function)
        {
            _mainFunc = function;
        }

        public List<double> CalculationTask(double a, double b, double xs, double xe, double dx)
        {
            var listA = new List<double>();
            for (double x = xs; x <= xe; x += dx)
            {
                listA.Add(_mainFunc.CalculateFunction(a, b, x));
            }

            return listA;
        }

        public List<double> CalculationTask(double a, double b, List<double> listTaskB)
        {
            var listB = new List<double>();
            foreach (var x in listTaskB)
            {
                listB.Add(_mainFunc.CalculateFunction(a, b, x));
            }

            return listB;
        }
    }
}