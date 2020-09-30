using System;

namespace Sem4Task3
{
    class Program
    {
        static double FindTrianglePerimeter(double x, double y, double z)
        {
            return x + y + z;
        }

        static double FindTriangleArea(double x, double y, double z)
        {
            double trianglePerimeter = FindTrianglePerimeter(x, y, z) / 2;
            return Math.Sqrt(trianglePerimeter / 2 * (trianglePerimeter / 2 - x) *
                (trianglePerimeter / 2 - y) * (trianglePerimeter / 2 - z));
        }

        static bool CheckIfPositive(double x, double y, double z)
        {
            return x > 0.0 && y > 0.0 && z > 0.0;
        }

        static bool ValidateTriangle(double x, double y, double z)
        {
            return x + y > z && x + z > y && y + z > x;
        }

        static bool Triangle(double x, double y, double z, out double trianglePerimeter, out double triangleArea)
        {
            trianglePerimeter = 0.0;
            triangleArea = 0.0;
            if (CheckIfPositive(x, y, z))
            {
                if (ValidateTriangle(x, y, z))
                {
                    trianglePerimeter = FindTrianglePerimeter(x, y, z);
                    triangleArea = FindTriangleArea(x, y, z);
                    return true;
                }
                return false;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine();
        }
    }
}
