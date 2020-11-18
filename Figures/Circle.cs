using System;
using System.Collections.Generic;
using System.Text;

namespace Figures
{
    class Circle : Point
    {
        protected double rad;

        public Circle(double x, double y, double rad)
        {
            this.x = x;
            this.y = y;
            Rad = rad;
        }

        public double Rad
        {
            get => rad;
            protected set
            {
                if (!(rad > 0))
                {
                    throw new ArgumentException("Радиус должен быть положительным!");
                }
                rad = value;
            }
        }

        public override double Area
        {
            get => Math.PI * rad * rad;
        }

        public double Len
        {
            get => 2 * Math.PI * rad;
        }

        public override void Display()
        {
            Console.WriteLine($"Окружность с центром в ({x:F2};{y:F2}) и с радиусом {rad:F2}.");
        }
    }
}
