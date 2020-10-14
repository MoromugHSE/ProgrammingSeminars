using System;

namespace Sem5Task2
{
    class Program
    {
        static Random random = new Random();
        static int InputInteger()
        {
            int inputtedInteger;
            do
            {
                Console.WriteLine();
            } while (!int.TryParse(Console.ReadLine(), out inputtedInteger));
            return inputtedInteger;
        }
        static int InputArrayLength()
        {
            int arrayLength;
            do
            {
                arrayLength = InputInteger();
            } while (arrayLength <= 0);
            return arrayLength;
        }

        static void GenerateCharArray(int arrayLength, ref char[] charArray)
        {
            for (int i = 0; i < arrayLength; i++)
            {
                charArray[i] = (char)('A' + random.Next(0, 26));
            }
        }

        static void Main(string[] args)
        {
            int k = InputArrayLength();
            char[] charArray = new char[k];
            GenerateCharArray(k, ref charArray);
            foreach (char ch in charArray)
            {
                Console.Write(ch);
            }
            Console.WriteLine();
            char[] charArrayCopy = new char[k];
            Array.Copy(charArray, charArrayCopy, k);
            Array.Sort(charArrayCopy);
            foreach (char ch in charArrayCopy)
            {
                Console.Write(ch);
            }
            Console.WriteLine();
            Array.Reverse(charArrayCopy);
            foreach (char ch in charArrayCopy)
            {
                Console.Write(ch);
            }
        }
    }
}
