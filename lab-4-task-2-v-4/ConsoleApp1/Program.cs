using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[12];
            int maxOdd = int.MinValue; // Инициализация минимальным значением
            bool hasOdd = false;

            // Ввод элементов массива
            Console.WriteLine("Введите 12 целых чисел:");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write($"A[{i}] = ");
                while (!int.TryParse(Console.ReadLine(), out A[i]))
                {
                    Console.Write("Ошибка! Введите целое число: ");
                }
            }

            // Поиск наибольшего нечетного элемента
            foreach (int num in A)
            {
                if (num % 2 != 0) // Проверка на нечетность
                {
                    if (num > maxOdd)
                    {
                        maxOdd = num;
                        hasOdd = true;
                    }
                }
            }

            // Вывод результата
            Console.WriteLine("\nИсходный массив:");
            Console.WriteLine(string.Join(" ", A));

            if (hasOdd)
                Console.WriteLine($"Наибольший нечетный элемент: {maxOdd}");
            else
                Console.WriteLine("В массиве нет нечетных элементов.");
        }
    }
}
