using System;

namespace Task2_04
{
    class Program8
    {
        static void Main(string[] args)
        {
            do
            {
                int wholeInt;
                do
                {
                    Console.WriteLine("Введите четырёхзначное натуральное число: ");
                } while (!int.TryParse(Console.ReadLine(), out wholeInt) ||
                    wholeInt < 1000 || wholeInt > 9999);
                while (wholeInt > 0)
                {
                    Console.WriteLine(wholeInt % 10);
                    wholeInt /= 10;
                }
                Console.WriteLine("Нажмите ESC для завершения программы " +
                    "или любой другой символ для повторного запуска: ");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
