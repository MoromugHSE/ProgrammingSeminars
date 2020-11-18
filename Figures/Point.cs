using System;

namespace Figures
{
    public class Point
    {
        protected double x;
        protected double y;

        public virtual double Area { get => 0; }

        public virtual void Display()
        {
            Console.WriteLine($"Точка ({x};{y})");
        }
    }
}
