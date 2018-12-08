using System;

namespace Lab2_2
{
    class Program
    {
        static void Main()
        {
            double x, z, y;
            Console.Write("Введите координату X = ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату Y = ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату Z = ");
            z = Convert.ToDouble(Console.ReadLine());
            Console.Write("Результат вычисления по формуле = {0:0.000}" + (x * (Math.Tan(z) + (2 * Math.Cos(y)))));
            Console.ReadKey();
        }
    }
}
