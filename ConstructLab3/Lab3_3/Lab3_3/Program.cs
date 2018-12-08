using System;

namespace Lab3_3
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите X начальное = ");
            double xstart = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите X конечное = ");
            double xfinal = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите шаг = ");
            double dx = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите точность = ");
            double e = Convert.ToDouble(Console.ReadLine());
            double n = 0;
            int i = 1;
            if (Math.Abs(xstart) < 1)
                for (double x = xstart; Math.Abs(x) < 1; x += dx)
                {
                    xstart = (Math.Pow(-1, n) * Math.Pow(x, 2 * n + 1)) / (2 * n +1);
                }
            else
                Console.Write("X должен быть меньше единицы.");
        }
    }
}
