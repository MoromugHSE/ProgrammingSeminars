using System;

namespace Array_methods_with_Delegates
{
    class Program
    {
        const int ArrayLength = 5;

        static void Main(string[] args)
        {
            string[] inputArr = new string[ArrayLength];
            double[] valueArr = new double[ArrayLength];
            bool areAllValuesCorrect;

            do
            {
                areAllValuesCorrect = true;
                valueArr = Array.ConvertAll(
                    inputArr,
                    x =>
                    {
                        double res;
                        areAllValuesCorrect &= double.TryParse(
                            Console.ReadLine(), out res);
                        return res;
                    });
            } while (!areAllValuesCorrect);

            double maxValue = double.NegativeInfinity;
            Array.ForEach(
                valueArr, 
                x => maxValue = Math.Max(maxValue, Math.Abs(x)));

            valueArr = Array.ConvertAll(
                valueArr,
                x => x / maxValue);

            Array.ForEach(valueArr, Console.WriteLine);
        }
    }
}
