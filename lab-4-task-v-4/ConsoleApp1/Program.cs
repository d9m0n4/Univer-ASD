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
            int[,] A = new int[5, 4];
            Random rnd = new Random();
            int count = 0;

            // Заполнение матрицы случайными числами
            Console.WriteLine("Матрица A(5,4):");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    A[i, j] = rnd.Next(0, 21);
                    Console.Write($"{A[i, j],4}");
                }
                Console.WriteLine();
            }

            // Ввод K1 и K2
            Console.Write("\nВведите K1: ");
            int K1 = GetValidNumber();
            Console.Write("Введите K2: ");
            int K2 = GetValidNumber();

            // Проверка условия для каждого элемента
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int element = A[i, j];
                    int sumIndices = i + 1 + j + 1; // i и j начинаются с 1 (по условию задачи)
                    bool condition = (element >= K1 && element <= K2) || (element > sumIndices);

                    if (condition)
                        count++;
                }
            }

            Console.WriteLine($"\nКоличество элементов, удовлетворяющих условию: {count}");
        }

        // Метод для безопасного ввода числа
        static int GetValidNumber()
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int num))
                    return num;
                Console.Write("Ошибка! Введите целое число: ");
            }
        }
    
    }
}
