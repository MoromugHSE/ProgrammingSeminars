using System;
using System.IO;
using System.Text;

namespace ConsoleApp23
{
    class Program
    {
        static Random random = new Random();
        const int ITEMSINROW = 5;
        static void Main(string[] args)
        {
            string path = @"Data.txt";
            // Создаем файл с данными
            if (File.Exists(path))
            {
                string createText = GenerateText();
                File.WriteAllText(path, createText, Encoding.UTF8);
            }

            // Open the file to read from
            if (File.Exists(path))
            {
                string[] stringValues;
                SplitFileText(path, out stringValues);
                int[] arr = StringArrayToIntArray(stringValues);
                foreach (int i in arr)
                {
                    Console.Write(i + " ");
                }

                // обрабатываем элементы массива
                // TODO2: Создать два массива по исходному
                // в первый поместить индексы чётных элементов, во второй - нечётных
                int[] arrOfEvenIndex;
                int[] arrOfOddIndex;
                DivideByOddity(arr, out arrOfEvenIndex, out arrOfOddIndex);

                // TODO3: Заменяем все нечётные числа исходного массива нулями
                foreach (var ind in arrOfOddIndex)
                {
                    arr[ind] = 0;
                }
            }
        } // end of Main()

        public static void SplitFileText(string path, out string[] stringValues)
        {
            try
            {
                stringValues = File.ReadAllLines(path);
            }
            catch (IOException)
            {
                stringValues = new string[0];
            }
        }

        public static void DivideByOddity(int[] arr, out int[] arrOfEvenIndex, out int[] arrOfOddIndex)
        {
            arrOfEvenIndex = new int[arr.Length];
            arrOfOddIndex = new int[arr.Length];
            int evenIndex = 0;
            int oddIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    arrOfEvenIndex[evenIndex++] = i;
                }
                else
                {
                    arrOfOddIndex[oddIndex++] = i;
                }
            }
            Array.Resize(ref arrOfEvenIndex, evenIndex);
            Array.Resize(ref arrOfOddIndex, oddIndex);
        }

        public static string GenerateText()
        {
            StringBuilder createText = new StringBuilder();
            int valuesCount = random.Next(1, 100);
            for (int i = 0; i < valuesCount; i++)
            {
                if (i % ITEMSINROW != 0)
                {
                    createText.Append(' ');
                }
                createText.Append(random.Next(10, 100));
                if ((i + 1) % ITEMSINROW == 0)
                {
                    createText.Append(Environment.NewLine);
                }
            }
            return createText.ToString();
        }

        // преобразование массива строк в массив целых чисел
        public static int[] StringArrayToIntArray(string[] str)
        {
            int[] arr = null;
            if (str.Length != 0)
            {
                arr = new int[0];
                foreach (string s in str)
                {
                    int tmp;
                    if (int.TryParse(s, out tmp))
                    {
                        Array.Resize(ref arr, arr.Length + 1);
                        arr[arr.Length - 1] = tmp;
                    }
                } // end of foreach (string s in str)      
            }
            return arr;
        } // end of StringToIntArray()
    } // end of Program
}
