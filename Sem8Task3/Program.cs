using System;

namespace Sem8Task3
{
    class Program
    {
        static Random Rnd = new Random();
        const int MinArrayLength = 2;
        const int MaxArrayLength = 4;
        const char FirstChar = 'a';
        const char LastChar = 'z';

        static uint GetNumber(string inputPrompt)
        {
            uint res;
            do
            {
                Console.WriteLine(inputPrompt);
            } while (!uint.TryParse(Console.ReadLine(), out res));
            return res;
        }

        static void NextChar(ref char currentChar)
        {
            ++currentChar;
            // Мне лень придумывать формулу со взятием по модулю и прочим, поэтому так.
            if (currentChar > LastChar)
            {
                currentChar = FirstChar;
            }
        }

        static char[] GenerateThirdLevelArray(ref char currentChar)
        {
            int thirdLevelArrayLength = Rnd.Next(MinArrayLength, MaxArrayLength + 1);
            char[] thirdLevelArray = new char[thirdLevelArrayLength];
            for (int i = 0; i < thirdLevelArrayLength; ++i)
            {
                thirdLevelArray[i] = currentChar;
                NextChar(ref currentChar);
            }
            return thirdLevelArray;
        }

        static char[][] GenerateSecondLevelArray(ref char currentChar)
        {
            int secondLevelArrayLength = Rnd.Next(MinArrayLength, MaxArrayLength + 1);
            char[][] secondLevelArray = new char[secondLevelArrayLength][];
            for (int i = 0; i < secondLevelArrayLength; ++i)
            {
                secondLevelArray[i] = GenerateThirdLevelArray(ref currentChar);
            }
            return secondLevelArray;
        }

        static char[][][] GenerateFirstLevelArray(ref char currentChar)
        {
            uint firstLevelArrayLength = GetNumber("Введите длину главного массива:");
            char[][][] firstLevelArray = new char[firstLevelArrayLength][][];

            for (int i = 0; i < firstLevelArray.Length; ++i)
            {
                firstLevelArray[i] = GenerateSecondLevelArray(ref currentChar);
            }

            return firstLevelArray;
        }

        static void PrintArray(char[][][] array)
        {
            for (int i = 0; i < array.Length; ++i)
            {
                for (int j = 0; j < array[i].Length; ++j)
                {
                    for (int k = 0; k < array[i][j].Length; ++k)
                    {
                        Console.Write($"{array[i][j][k]} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            char currentChar = FirstChar;
            char[][][] array = GenerateFirstLevelArray(ref currentChar);
            PrintArray(array);
        }
    }
}
