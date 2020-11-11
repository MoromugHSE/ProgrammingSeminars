using System;


namespace Sem9Task1
{
    class Student
    {
        private int id;
        private int marksNumber;
        private int[] marks;
        private const int MinMark = 0;
        private const int MaxMark = 10;
        private static Random rnd = new Random();

        public Student(int id) : this(id, 4)
        {
        }
        public Student(int id, int N)
        {
            this.Id = id;
            this.MarksNumber = N;
            this.marks = new int[marksNumber];
            for (int i=0; i < marks.Length; ++i)
            {
                marks[i] = rnd.Next(MinMark, MaxMark + 1);
            }
        }

        public double Average
        {
            get
            {
                double sum = 0;
                foreach (var mark in marks)
                {
                    sum += mark;
                }
                return sum / marks.Length;
            }
        }

        private int MarksNumber
        {
            get => marksNumber;
            set
            {
                if (marksNumber <= 0)
                {
                    throw new ArgumentException();
                }
                marksNumber = value;
            }
        }

        private int Id
        {
            get => id;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }
                id = value;
            }
        }

        public void PrintData()
        {
            Console.WriteLine($"Порядковый номер студента: {id}.");
            Console.WriteLine("Оценки студента:");
            foreach (var mark in marks)
            {
                Console.Write($"{mark}\t");
            }
            Console.WriteLine();
        }
    }
}
