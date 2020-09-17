using System;

namespace Task_04
{
    class Program4
    {
        static void Main(string[] args)
        {
            do
            {
                uint charCode;
                do
                {
                    Console.WriteLine("Введите код символа: ");
                } while (!uint.TryParse(Console.ReadLine(), out charCode));
                string isCorrectChar = IsLetter(charCode);
                Console.WriteLine(isCorrectChar);
                Console.WriteLine("Нажмите ESC для завершения программы " +
                    "или любой другой символ для повторного запуска: ");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
        static string IsLetter(uint letterCode)
        {
            string outputString = (letterCode >= '0' && letterCode <= '9') ?
                "Это цифра!" : (letterCode >= 'a' && letterCode <= 'z' ||
                letterCode >= 'A' && letterCode <= 'Z' ||
                letterCode >= 'А' && letterCode <= 'Я' ||
                letterCode >= 'а' && letterCode <= 'я' ||
                letterCode == 'Ё' || letterCode == 'ё' ?
                "Это буква!" : "Это ни буква, ни цифра!");
            return outputString;
        }
    }
}