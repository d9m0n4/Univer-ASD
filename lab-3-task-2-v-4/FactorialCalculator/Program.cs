using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long product = 1;

            for (int i = 1; i <= 10; i++)
            {
                product *= i;
            }

            Console.WriteLine($"Произведение первых 10 натуральных чисел: {product:N0}");
        }
    }
}
