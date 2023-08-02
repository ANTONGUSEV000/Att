using System;

namespace SumOfNaturalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = 1;
            int N = 15;

            int sum = CalculateSumOfNaturalNumbers(M, N);
            Console.WriteLine($"Сумма натуральных чисел от {M} до {N}: {sum}");
        }

        static int CalculateSumOfNaturalNumbers(int start, int end)
        {
            int sum = 0;
            for (int i = start; i <= end; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}

