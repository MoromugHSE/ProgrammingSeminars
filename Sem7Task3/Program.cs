using System;
using System.IO;
using System.Security;
using System.Text;

namespace Sem7Task3
{
    class Program
    {
        static readonly Random random = new Random();
        const int SentenceCount = 6;
        const int MinSentenceLength = 20;
        const int MaxSentenceLength = 50;
        const int WhitespaceFrequency = 8;
        static readonly string OutputPath = string.Format(@"..{0}..{0}..{0}dialog.txt", Path.DirectorySeparatorChar);
        static readonly Encoding FileEncoding = Encoding.UTF8;

        static string GenerateSentence(int minLength, int maxLength)
        {
            int sentenceLength = random.Next(minLength, maxLength + 1);
            char[] sentenceCharByChar = new char[sentenceLength];
            for (int i = 0; i < sentenceLength - 1; ++i)
            {
                if (random.Next(WhitespaceFrequency) == 0)
                {
                    sentenceCharByChar[i] = ' ';
                }
                else
                {
                    sentenceCharByChar[i] = (char)random.Next('а', 'я' + 1);
                }
            }
            sentenceCharByChar[sentenceLength - 1] = '.';
            return new string(sentenceCharByChar);
        }

        private static void ReadSentencesFromFile(string path, out string[] sentences, Encoding encoding)
        {
            sentences = File.ReadAllLines(path, encoding);
        }

        private static void WriteSentencesToFile(string path, string[] sentences, Encoding encoding)
        {
            File.WriteAllLines(path, sentences, encoding);
        }

        private static void PrintSentencesWithoutEndDots(string path, Encoding encoding)
        {
            foreach (var str in File.ReadLines(path, encoding))
                {
                    Console.WriteLine(str.Substring(0, str.Length - 1));
                }
        }

        private static string[] GenerateSentences()
        {
            string[] sentences = new string[SentenceCount];
            for (int i = 0; i < SentenceCount; ++i)
            {
                sentences[i] = GenerateSentence(MinSentenceLength, MaxSentenceLength);
            }
            return sentences;
        }

        private static void PrintArray(string outputPrompt, string[] array)
        {
            Console.WriteLine(outputPrompt);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            string[] sentences = GenerateSentences();
            try
            {
                WriteSentencesToFile(OutputPath, sentences, FileEncoding);
                ReadSentencesFromFile(OutputPath, out sentences, FileEncoding);
                PrintArray("Исходные предложения:", sentences);
                Console.WriteLine("А вот, что получилось:");
                PrintSentencesWithoutEndDots(OutputPath, FileEncoding);
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Caught {ex.GetType()}: {ex.Message}");
            }
            catch (SecurityException ex)
            {
                Console.WriteLine($"Caught {ex.GetType()}: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Caught {ex.GetType()}: {ex.Message}");
            }
        }
    }
}
