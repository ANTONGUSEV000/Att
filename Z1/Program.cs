using System;

namespace RecursionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задаем значение N
            int N = 10;

            Console.WriteLine("Натуральные числа от N до 1:");
            PrintNaturalNumbers(N);
        }

        static void PrintNaturalNumbers(int num)
        {
            if (num >= 1)
            {
                Console.Write(num + " ");
                PrintNaturalNumbers(num - 1);
            }
        }
    }
}


