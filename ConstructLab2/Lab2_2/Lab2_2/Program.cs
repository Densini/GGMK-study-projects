using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, z, y, b;
            Console.Write("Введите координату X = ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату Y = ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату Z = ");
            z = Convert.ToDouble(Console.ReadLine());
            b = x * (Math.Tan(z) + (2 * Math.Cos(y)));
            Console.Write("Результат вычисления по формуле = {0:0.000}", b);
            Console.ReadKey();
        }
    }
}
