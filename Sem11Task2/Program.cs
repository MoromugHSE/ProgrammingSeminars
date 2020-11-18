using System;
using Figures;

namespace Sem11Task2
{
    class Program
    {
        private static Random rnd = new Random();
        
        private static double GetDouble()
        {
            return Math.Max(rnd.NextDouble(), double.Epsilon) * 90 + 10;
        }

        private static Point[] FigArray()
        {
            int circleAmount = rnd.Next(11);
            int squareAmount = rnd.Next(11);
            Point[] figArray = new Point[circleAmount + squareAmount];

            int circleCount = 0;
            int squareCount = 0;
            while (squareCount < squareAmount && circleCount < circleAmount)
            {
                double a = GetDouble();
                double b = GetDouble();
                double c = GetDouble();
                if (rnd.Next(2) == 0)
                {
                    figArray[squareCount + circleCount++] = new Circle(a, b, c);
                }
                else
                {
                    figArray[squareCount++ + circleCount] = new Square(a, b, c);
                }
            }

            return figArray;
        }
        static void Main(string[] args)
        {
            Point p = new Point();
            p.Display();
            Console.WriteLine(p.Area);
            p = new Circle(1, 2, 6);
            p.Display();
            Console.WriteLine(p.Area);
            p = new Square(3, 5, 8);
            p.Display();
            Console.WriteLine(p.Area);

            Point[] figs = FigArray();
        }
    }
}
