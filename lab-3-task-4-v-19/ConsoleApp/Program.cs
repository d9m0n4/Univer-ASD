using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите x: ");
            double x = GetValidNumber();

            // Часть 1: Цикл while (предусловие)
            Console.Write("Введите ε: ");
            double epsilon = GetValidPositiveNumber();

            double sumWhile = 0;
            int nWhile = 0;
            double factorialWhile = 1;
            double powerOfTwoWhile = 1;
            double currentTermWhile = x * powerOfTwoWhile / factorialWhile;

            while (Math.Abs(currentTermWhile) >= epsilon)
            {
                sumWhile += currentTermWhile;
                nWhile++;
                powerOfTwoWhile *= 2;
                factorialWhile *= (2 * nWhile) * (2 * nWhile + 1);
                currentTermWhile = x * powerOfTwoWhile / factorialWhile;
            }

            Console.WriteLine($"Сумма: {sumWhile:F6}, элементов: {nWhile}");

            // Часть 2: Цикл do-while (постусловие)
            Console.Write("\nВведите V: ");
            double V = GetValidNumber();

            double sumDoWhile = 0;
            int nDoWhile = 0;
            double factorialDoWhile = 1;
            double powerOfTwoDoWhile = 1;
            double currentTermDoWhile = x * powerOfTwoDoWhile / factorialDoWhile;
            int requiredN = -1;

            do
            {
                sumDoWhile += currentTermDoWhile;
                if (sumDoWhile > V && requiredN == -1)
                    requiredN = nDoWhile;

                nDoWhile++;
                powerOfTwoDoWhile *= 2;
                factorialDoWhile *= (2 * nDoWhile) * (2 * nDoWhile + 1);
                currentTermDoWhile = x * powerOfTwoDoWhile / factorialDoWhile;

            } while (sumDoWhile <= V && currentTermDoWhile != 0);

            Console.WriteLine(requiredN != -1
                ? $"Сумма превысила {V} после элемента: {requiredN}"
                : $"Сумма не достигла {V}");
        }

        static double GetValidNumber()
        {
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out double num))
                    return num;
                Console.Write("Ошибка! Введите число: ");
            }
        }

        static double GetValidPositiveNumber()
        {
            while (true)
            {
                double num = GetValidNumber();
                if (num > 0) return num;
                Console.Write("Ошибка! Число должно быть > 0: ");
            }
        }
    }
}

