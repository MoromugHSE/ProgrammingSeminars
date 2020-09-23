using System;

namespace Sem3Task2
{
    class Program
    {
        static bool Function(bool p, bool q)
        {
            return !(p & q) & !(p | !q);
        }

        static bool GetInputValue(string inputPrompt)
        {
            bool inputBool;
            do
            {
                Console.WriteLine("Введите булеву переменную: ");
            } while (!bool.TryParse(Console.ReadLine(), out inputBool));
            return inputBool;
        }
        static void UseFirstSolution()
        {
            Console.WriteLine("P\tQ\tF");
            for (int p = 0; p < 2; p++)
            {
                for (int q = 0; q < 2; q++)
                {
                    Console.WriteLine($"{p}\t{q}\t{(Function(p == 1 ? true : false, q == 1 ? true : false) ? 1 : 0)}");
                }
            }
        }
        static void Main(string[] args)
        {
            UseFirstSolution();
            int variableNumber = 3;
            Console.WriteLine("P\tQ\tF");
            for (int binaryCounterInt = 0; binaryCounterInt < 1<<variableNumber; binaryCounterInt++)
            {

            }
        }
    }
}
