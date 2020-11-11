using System;

namespace Sem10Task1
{
    class ArithmeticSequence
    {
        private double _start;
        private double _increment;

        public ArithmeticSequence() : this(0, 1) { }

        public ArithmeticSequence(double start, double increment)
        {
            this._start = start;
            this._increment = increment;
        }

        public double this[int index]
        {
            get
            {
                if (index < 1)
                {
                    throw new IndexOutOfRangeException();
                }
                return _start + (index - 1) * _increment;
            }
        }

        public override string ToString()
        {
            return $"Первый член: {_start} Разность прогрессии: {_increment}";
        }

        public double GetSum(int n)
        {
            return (this[1] + this[n]) * n / 2;
        }
    }
    class Program
    {
        private static Random rnd = new Random();

        private const int MinStart = 0;
        private const int MaxStart = 1000;
        private const int MinIncrement = 1;
        private const int MaxIncrement = 10;
        private const int MinArrayLength = 5;
        private const int MaxArrayLength = 15;
        private const int MinStep = 3;
        private const int MaxStep = 15;

        static void Main(string[] args)
        {
            ArithmeticSequence soloSequence = new ArithmeticSequence(
                rnd.Next(MinStart, MaxStart+1), 
                rnd.Next(MinIncrement, MaxIncrement+1));

            ArithmeticSequence[] sequences =
                new ArithmeticSequence[rnd.Next(MinArrayLength, MaxArrayLength)];
            for (int i=0; i < sequences.Length; ++i)
            {
                sequences[i] = new ArithmeticSequence(
                rnd.Next(MinStart, MaxStart + 1),
                rnd.Next(MinIncrement, MaxIncrement + 1));
            }

            int step = rnd.Next(MinStep, MaxStep+1);

            Console.WriteLine($"Последовательности, у которых элемент " +
                $"под номером {step} больше, чем у " +
                $"такой последовательности: {soloSequence}");
            foreach (var sequence in sequences)
            {
                if (sequence[step] > soloSequence[step])
                {
                    Console.WriteLine(sequence);
                }
            }

            Console.WriteLine($"Суммы всех последовательностей до " +
                $"элемента под номером {step}:");
            Console.WriteLine($"{soloSequence} Сумма до {step}: " +
                $"{soloSequence.GetSum(step)}");
            foreach (var sequence in sequences)
            {
                Console.WriteLine($"{sequence} Сумма до {step}: " +
                $"{sequence.GetSum(step)}");
            }
        }
    }
}
