using System;

namespace Sem4Task2
{
    class Program
    {

        const int SHIFTVALUE = -4;

        static char ShiftChar(char firstCharInRange, char lastCharInRange, char shiftingChar)
        {
            int rangeLength = lastCharInRange - firstCharInRange + 1;
            shiftingChar = (char)((shiftingChar - firstCharInRange + rangeLength + SHIFTVALUE) % rangeLength + firstCharInRange);
            return shiftingChar;
        }

        static bool Shift(ref char letter)
        {
            if (letter >= 'a' && letter <= 'z')
            {
                letter = ShiftChar('a', 'z', letter);
                return true;
            }
            if (letter >= 'A' && letter <= 'Z')
            {
                letter = ShiftChar('A', 'Z', letter);
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            char letter;
            do
            {
                Console.WriteLine("Введите латинскую букву: ");
            } while (!char.TryParse(Console.ReadLine(), out letter));
            if (Shift(ref letter))
            {
                Console.WriteLine(letter);
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}
