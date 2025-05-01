using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] M = new int[3, 4];
            Random rnd = new Random();
            int count = 0;

            // Заполнение матрицы случайными числами от -5 до 5
            Console.WriteLine("Матрица M(3,4):");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    M[i, j] = rnd.Next(-5, 6);
                    Console.Write($"{M[i, j],4}");
                }
                Console.WriteLine();
            }

            // Проверка элементов третьей строки (индекс 2)
            Console.WriteLine("\nЭлементы третьей строки:");
            for (int j = 0; j < 4; j++)
            {
                int element = M[2, j];
                Console.Write($"{element,4}");
                if (element > -2 && element < 2)
                {
                    count++;
                }
            }

            Console.WriteLine($"\n\nКоличество чисел в третьей строке (-2 < x < 2): {count}");
        }
    }
}
