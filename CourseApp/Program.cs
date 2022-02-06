namespace CourseApp
{
    using System;
    using System.Collections.Generic;
    using Kantaiko.ConsoleFormatting;

    public class Program
    {
        public static void Main(string[] args)
        {
            Function function = new Function();
            var start = new Calculation(function);

            var a = 0.8;
            var b = 0.4;
            var xs = 1.23;
            var xe = 7.23;
            var dx = 1.2;
            var listTaskB = new List<double>() { 1.88, 2.26, 3.84, 4.55, -6.21 };

            var listA = start.CalculationTask(a, b, xs, xe, dx);
            var listB = start.CalculationTask(a, b, listTaskB);

            Console.WriteLine(Colors.FgCyan("-----------Task A-----------").BgMagenta());
            OutputTask(listA);

            Console.WriteLine(Colors.FgCyan("-----------Task B-----------").BgMagenta());
            OutputTask(listB);
        }

        public static void OutputTask(List<double> listTask)
        {
            foreach (var y in listTask)
            {
                Console.WriteLine(Colors.FgCyan($"y = {y}").BgMagenta());
            }
        }
    }
}