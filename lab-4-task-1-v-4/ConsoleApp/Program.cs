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
            int[] X = new int[16];
            Random rnd = new Random();

            // Заполнение массива случайными числами от -100 до 100
            for (int i = 0; i < X.Length; i++)
            {
                X[i] = rnd.Next(-100, 101);
            }

            // Вывод исходного массива
            Console.WriteLine("Исходный массив:");
            Console.WriteLine(string.Join(" ", X));

            // Вывод положительных элементов
            Console.WriteLine("\nПоложительные элементы:");
            foreach (int num in X)
            {
                if (num > 0) Console.Write(num + " ");
            }

            // Вывод отрицательных элементов
            Console.WriteLine("\n\nОтрицательные элементы:");
            foreach (int num in X)
            {
                if (num < 0) Console.Write(num + " ");
            }

            Console.WriteLine();
        }
    }
}
