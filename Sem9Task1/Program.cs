using System;

namespace Sem9Task1
{
    class Program
    {
        private static Random rnd = new Random();
        static void Main(string[] args)
        {
            int N = rnd.Next(20, 31);
            Student[] students = new Student[N];
            for (int i = 0; i < N; ++i)
            {
                if (i < N / 2)
                {
                    students[i] = new Student(i + 1);
                }
                else
                {
                    students[i] = new Student(i + 1, rnd.Next(2, 6));
                }
            }

            foreach (var student in students)
            {
                if (student.Average < 3.5)
                {
                    student.PrintData();
                }
            }
        }
    }
}
