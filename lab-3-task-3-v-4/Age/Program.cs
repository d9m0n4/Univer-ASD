using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите возраст: ");

            if (int.TryParse(Console.ReadLine(), out int age) && age >= 0)
            {
                string occupation;
                if (age < 7)
                    occupation = "Детский сад";
                else if (age >= 7 && age < 18)
                    occupation = "Школа";
                else if (age >= 18 && age < 65)
                    occupation = "Работа";
                else
                    occupation = "Пенсия";

                Console.WriteLine($"Род занятий: {occupation}");
            }
            else
            {
                Console.WriteLine("Ошибка! Введите корректный возраст.");
            }
        }
    }
}
