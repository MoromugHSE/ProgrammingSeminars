using System;

namespace Task_05
{
    class Program5
    {
        static void Main(string[] args)
        {
            int wholeInt;
            do
            {
                Console.WriteLine("Введите трёхзначное натуральное число: ");
            } while (!int.TryParse(Console.ReadLine(), out wholeInt) ||
                wholeInt < 100 || wholeInt > 999);
            Console.WriteLine(wholeInt/100);
            Console.WriteLine(wholeInt/10%10);
            Console.WriteLine(wholeInt%10);
        }
    }
}
