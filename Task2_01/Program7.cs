using System;

namespace Task2_01
{
    class Program7
    {
        static void Main(string[] args)
        {
            do
            {
                double argumentX;
                do
                {
                    Console.WriteLine("Введите значение x: ");
                } while (!double.TryParse(Console.ReadLine(), out argumentX));
                Console.WriteLine(GetFunctionWithArgumentX(argumentX));
                Console.WriteLine("Нажмите ESC для завершения программы " +
                    "или любой другой символ для повторного запуска: ");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
        static double GetFunctionWithArgumentX (double argumentX)
        {
            double result = (((12 * argumentX + 9) * argumentX - 3) 
                * argumentX + 2) * argumentX - 4;
            return result;
        }
    }
}
