using System;

namespace Task_06
{
    class Program6
    {
        static void Main(string[] args)
        {
            const double radius = 10.0;
            do
            {
                double posX;
                do
                {
                    Console.WriteLine("Введите абсциссу точки: ");
                } while (!double.TryParse(Console.ReadLine(), out posX));
                double posY;
                do
                {
                    Console.WriteLine("Введите ординату точки: ");
                } while (!double.TryParse(Console.ReadLine(), out posY));
                if (posX*posX + posY*posY <= radius*radius)
                {
                    Console.WriteLine("Точка внутри круга!");
                }
                else
                {
                    Console.WriteLine("Точка вне круга!");
                }
                Console.WriteLine("Нажмите ESC для завершения программы " +
                    "или любой другой символ для повторного запуска: ");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
