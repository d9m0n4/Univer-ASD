using System;

class Program
{
    static void Main(string[] args)
    {
        
        double a = 3;
        double b = 5;
        Console.WriteLine("Введите x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        double Y = a * Math.Pow(x, 5) * (
            Math.Atan(a + x) - Math.Sqrt(Math.Abs(x - a)) + Math.Pow(Math.Log(x + 1), 2)
        );

        double F = x * Math.Sqrt(
            a * Math.Pow(x, 2) + b * x + Math.Exp(-x) + Math.Log(x - a + 1)

        );
        

        Console.WriteLine($"Y = {Y}");
        Console.WriteLine($"F = {F}");
    }
}
