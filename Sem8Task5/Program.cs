using System;
using System.Runtime.InteropServices.ComTypes;

namespace Sem8Task5
{
    class Program
    {
        static int GetNumber(string inputPrompt)
        {
            int res;
            do
            {
                Console.WriteLine(inputPrompt);
            } while (!(int.TryParse(Console.ReadLine(), out res) && res > 0));
            return res;
        }

        static void GeneratePascalRow(int rowNumber, int[][] pascalTriangle)
        {
            pascalTriangle[rowNumber] = new int[rowNumber + 1];
            pascalTriangle[rowNumber][0] = 1;
            for (int i = 1; i < rowNumber; ++i)
            {
                pascalTriangle[rowNumber][i] = pascalTriangle[rowNumber - 1][i - 1] +
                    pascalTriangle[rowNumber - 1][i];
            }
            pascalTriangle[rowNumber][rowNumber] = 1;
        }

        static void PrintPascal(int[][] pascalTriangle, int pascalLength)
        {
            for (int row = 0; row <= pascalLength; ++row)
            {
                for (int tab = 0; tab < pascalLength - row; ++tab)
                {
                    Console.Write('\t');
                }
                for (int i = 0; i < pascalTriangle[row].Length; ++i)
                {
                    Console.Write($"{pascalTriangle[row][i]}\t\t");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.WindowHeight = Console.LargestWindowHeight;
            Console.WindowWidth = Console.LargestWindowWidth;
            int pascalLength = GetNumber("Введите количество строк в треугольнике:");
            int[][] pascal = new int[pascalLength + 1][];
            pascal[0] = new int[] { 1 };
            for (int i = 1; i <= pascalLength; ++i)
            {
                GeneratePascalRow(i, pascal);
            }
            PrintPascal(pascal, pascalLength);
        }
    }
}
