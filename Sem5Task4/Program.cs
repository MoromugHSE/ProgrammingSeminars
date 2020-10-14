using System;

namespace Sem5Task4
{
    class Program
    {
        static int[] ResizeArrayToDoubleSize(int[] integerArray, int currentPosition)
        {
            int[] temporaryIntegerArray = new int[currentPosition * 2];
            Array.Copy(integerArray, temporaryIntegerArray, currentPosition);
            integerArray = (int[])temporaryIntegerArray.Clone();
            return integerArray;
        }

        static int[] GenerateIntegerArray(int firstElement)
        {
            int[] integerArray = { firstElement };
            int currentPosition = 1;
            int currentElement = firstElement;
            while (currentElement != 1)
            {
                if (integerArray.Length == currentPosition)
                {
                    integerArray = ResizeArrayToDoubleSize(integerArray, currentPosition);
                }
                integerArray[currentPosition] = (integerArray[currentPosition - 1] % 2 == 0) ?
                    (integerArray[currentPosition - 1] / 2) : (3 * integerArray[currentPosition - 1] + 1);
                currentElement = integerArray[currentPosition++];
            }
            Array.Resize(ref integerArray, currentPosition);
            return integerArray;
        }
        static void Main(string[] args)
        {
            int length;
            do
            {
                Console.WriteLine();
            } while (!int.TryParse(Console.ReadLine(), out length));
            int[] integerArray = GenerateIntegerArray(length);
            foreach (int i in integerArray)
            {
                Console.WriteLine(i);
            }
        }
    }
}
