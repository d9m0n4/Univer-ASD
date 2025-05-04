using System;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int positive = 0, negative = 0, zero = 0;

            Console.WriteLine("Введите два числа:");
            for (int i = 0; i < 2; i++)
            {
                if (double.TryParse(Console.ReadLine(), out double num))
                {
                    if (num > 0) positive++;
                    else if (num < 0) negative++;
                    else zero++;
                }
            }

            Console.WriteLine($"Положительных: {positive}\nОтрицательных: {negative}\nНулей: {zero}");
            Console.ReadKey();
        }
    }
}
