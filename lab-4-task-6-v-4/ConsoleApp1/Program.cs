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
            // Инициализация массивов
            int[] Y = new int[14];
            int[,] A = new int[3, 2];
            List<int> tempList = new List<int>();
            Random rnd = new Random();

            // Заполнение массива Y случайными числами (-20 до 20)
            Console.WriteLine("Массив Y(14):");
            for (int i = 0; i < Y.Length; i++)
            {
                Y[i] = rnd.Next(-20, 21);
                Console.Write(Y[i] + " ");
                if (Y[i] < 0) tempList.Add(Y[i]); // Добавление отрицательных элементов
            }

            // Заполнение массива A(3,2) случайными числами (-20 до 20)
            Console.WriteLine("\n\nМассив A(3,2):");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    A[i, j] = rnd.Next(-20, 21);
                    Console.Write(A[i, j] + "\t");
                    if (A[i, j] < 0) tempList.Add(A[i, j]); // Добавление отрицательных элементов
                }
                Console.WriteLine();
            }

            // Проверка на наличие отрицательных элементов
            if (tempList.Count == 0)
            {
                Console.WriteLine("\nОтрицательных элементов нет.");
                return;
            }

            // Преобразование списка в массив и сортировка по убыванию
            int[] C = tempList.ToArray();
            Array.Sort(C);
            Array.Reverse(C);

            // Вывод результата
            Console.WriteLine("\nМассив C (отсортированный по убыванию):");
            foreach (int num in C)
            {
                Console.Write(num + " ");
            }
        }
    }
}
