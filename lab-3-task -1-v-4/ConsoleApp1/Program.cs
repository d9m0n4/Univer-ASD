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
            const double A = -6.0;
            const double B = 6.0;
            const double H = 0.5;

            Console.WriteLine("Вычисление функции Y = sqrt(6x² - x) на интервале [{0}, {1}] с шагом {2}", A, B, H);
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("   X      |      Y");
            Console.WriteLine("----------------------------------------------");

            for (double x = A; x <= B; x += H)
            {
                double currentX = Math.Round(x, 2);
                double expression = 6 * Math.Pow(currentX, 2) - currentX;

                if (expression >= 0)
                {
                    double y = Math.Sqrt(expression);
                    Console.WriteLine("{0,8:F2} | {1,8:F4}", currentX, y);
                }
                else
                {
                    Console.WriteLine("{0,8:F2} | Невозможно вычислить", currentX);
                }
            }

            Console.WriteLine("----------------------------------------------");
            Console.ReadKey();
        }
    }
}
