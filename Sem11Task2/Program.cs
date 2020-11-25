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
            while (squareCount < squareAmount)
            {
                double a = GetDouble();
                double b = GetDouble();
                double c = GetDouble();
                figArray[squareCount++ + circleCount] = new Square(a, b, c);
            }
            while (circleCount < circleAmount)
            {
                double a = GetDouble();
                double b = GetDouble();
                double c = GetDouble();
                figArray[circleCount++ + squareCount] = new Circle(a, b, c);
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

            Point[] figureArray = FigArray();
            int circleCount = 0;
            double circlePerimeterSum = 0;
            double circleAreaSum = 0;
            int squareCount = 0;
            double squarePerimeterSum = 0;
            double squareAreaSum = 0;
            foreach (var figure in figureArray)
            {
                if (figure is Circle circle)
                {
                    ++circleCount;
                    circlePerimeterSum += circle.Len;
                    circleAreaSum += circle.Area;
                }
                else if (figure is Square square)
                {
                    ++squareCount;
                    squarePerimeterSum += square.Len;
                    squareAreaSum += square.Area;
                }
            }
            Console.WriteLine($"Кругов {circleCount}, а квадратов {squareCount}.");
            Console.WriteLine($"Средняя длина окружностей: {(circleCount != 0 ? circlePerimeterSum / circleCount : 0):.##}");
            Console.WriteLine($"Средняя площадь кругов: {(circleCount != 0 ? circleAreaSum / circleCount : 0):.##}");
            Console.WriteLine($"Средний периметр квадратов: {(squareCount != 0 ? squarePerimeterSum / squareCount : 0):.##}");
            Console.WriteLine($"Средняя площадь квадратов: {(squareCount != 0 ? squareAreaSum / squareCount : 0):.##}");
            double[] areaArray = new double[figureArray.Length];
            for (int i=0; i < figureArray.Length; ++i)
            {
                areaArray[i] = figureArray[i].Area;
            }
            Array.Sort(areaArray, figureArray);
            foreach (var figure in figureArray)
            {
                figure.Display();
                if (figure is Circle circle)
                {
                    Console.WriteLine($"Длина окружности: {circle.Len} Площадь: {circle.Area}");
                }
                else if (figure is Square square)
                {
                    Console.WriteLine($"Периметр: {square.Len} Площадь: {square.Area}");
                }
            }
        }
    }
}
