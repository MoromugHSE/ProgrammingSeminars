using System;

namespace Sem3Task3
{
    class Program
    {
        static double GetFunctionYWithGivenX(double x)
        {
            return x * x;
        }

        static double GetTrapeciaSquare(double firstBorder, double secondBorder, double trapeciaHeight)
        {
            double trapeciaSquare = (firstBorder + secondBorder) * trapeciaHeight / 2.0;
            return trapeciaSquare;
        }

        static double InputValue(string inputPrompt)
        {
            double inputDouble;
            do
            {
                Console.WriteLine(inputPrompt);
            } while (!double.TryParse(Console.ReadLine(), out inputDouble));
            return inputDouble;
        }

        static bool ValidateDelta(double delta)
        {
            if (delta > 0.0)
            {
                return true;
            }
            return false;
        }

        static bool ValidateIntegrationBorder(double integrationBorder)
        {
            if (integrationBorder < 0.0)
            {
                return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            do
            {
                double delta;
                do
                {
                    delta = InputValue("Введите шаг интегрирования: ");
                } while (!ValidateDelta(delta));
                double integrationBorder;
                do
                {
                    integrationBorder = InputValue("Введите предел интегрирования: ");
                } while (!ValidateIntegrationBorder(integrationBorder));
                //Ответ как бы неточный, поэтому надо юзать децималы
                int trapeciaNumber = (int)(integrationBorder / delta);
                double trapeciaSum = 0.0;
                for (int currentTrapecia = 0; currentTrapecia < trapeciaNumber; ++currentTrapecia)
                {
                    double currentLeftBorder = delta * currentTrapecia;
                    double firstBorder = GetFunctionYWithGivenX(currentLeftBorder);
                    double currentRightBorder = delta * (currentTrapecia + 1);
                    double secondBorder = GetFunctionYWithGivenX(currentRightBorder);
                    double trapeciaSquare = GetTrapeciaSquare(firstBorder, secondBorder, delta);
                    trapeciaSum += trapeciaSquare;
                }
                if (delta * trapeciaNumber < integrationBorder)
                {
                    double currentLeftBorder = delta * trapeciaNumber;
                    double firstBorder = GetFunctionYWithGivenX(currentLeftBorder);
                    double secondBorder = GetFunctionYWithGivenX(integrationBorder);
                    double trapeciaHeight = integrationBorder - currentLeftBorder;
                    double trapeciaSquare = GetTrapeciaSquare(firstBorder, secondBorder, trapeciaHeight);
                    trapeciaSum += trapeciaSquare;
                }
                Console.WriteLine($"Площадь под графиком равна {trapeciaSum:F3}.");
                Console.WriteLine("Нажмите ESC для завершения программы или любую " +
                    "другую клавишу для продолжения:");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

        }
    }
}
