using System;

namespace Lab2_2
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите координату X = ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату Y = ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату Z = ");
            double z = Convert.ToDouble(Console.ReadLine());
            Console.Write("Результат вычисления по формуле = {0:0.000}" + (x * (Math.Tan(z) + 2 * Math.Cos(y))));
            Console.ReadKey();
        }
    }
}
