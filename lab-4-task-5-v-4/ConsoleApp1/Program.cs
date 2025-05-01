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
            int[,] B = new int[4, 4];
            Random rnd = new Random();
            int minDiagonal = int.MaxValue;
            int minRow = -1;

            // Заполнение матрицы случайными числами от 0 до 20
            Console.WriteLine("Исходная матрица B(4,4):");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    B[i, j] = rnd.Next(0, 21);
                    Console.Write($"{B[i, j],4}");
                }
                Console.WriteLine();
            }

            // Поиск минимального элемента на главной диагонали
            for (int i = 0; i < 4; i++)
            {
                int diagonalElement = B[i, i];
                if (diagonalElement < minDiagonal)
                {
                    minDiagonal = diagonalElement;
                    minRow = i;
                }
            }

            Console.WriteLine($"\nНаименьший элемент на главной диагонали: {minDiagonal}");

            // Ввод числа K
            Console.Write("\nВведите число K: ");
            int K = int.Parse(Console.ReadLine());

            // Если минимальный элемент < K, прибавляем +1 к строке
            if (minDiagonal < K)
            {
                Console.WriteLine($"\nЭлемент {minDiagonal} < {K}. Модифицируем строку {minRow + 1}:");
                for (int j = 0; j < 4; j++)
                {
                    B[minRow, j] += 1;
                }

                // Вывод измененной матрицы
                Console.WriteLine("Измененная матрица:");
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write($"{B[i, j],4}");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine($"\nЭлемент {minDiagonal} >= {K}. Изменения не требуются.");
            }
        }
    }
}
