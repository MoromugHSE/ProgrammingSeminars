using System;
using System.Collections.Generic;
using System.Text;

namespace Figures
{
    class Square : Point
    {
        internal double side;

        public Square(double x, double y, double side)
        {
            this.x = x;
            this.y = y;
            Side = side;
        }

        public double Side
        {
            get => side;
            protected set
            {
                if (!(value > 0))
                {
                    throw new ArgumentException("Сторона должна быть положительна!");
                }
                side = value;
            }
        }

        public override double Area
        {
            get => side * side;
        }

        public double Len
        {
            get => 4 * side;
        }

        public override void Display()
        {
            Console.WriteLine($"Квадрат с центром в ({x:F2};{y:F2}) и со стороной {side:F2}.");
        }
    }
}
