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
            if ((Math.Abs(xstart)) < 1)
                for (double x = xstart; x < xfinal; x += dx)
                {
                    int n = 0;
                    double sum = 0;
                    while (Math.Abs((Math.Pow(-1, n) * Math.Pow(x, 2 * n + 1)) / (2 * n + 1)) > e)
                    {
                        sum += (Math.Pow(-1, n) * Math.Pow(x, 2 * n + 1)) / (2 * n + 1);
                        n++;
                    }
                    Console.WriteLine(" x = " + x + " arth(x) = " + sum + " n = " + n);
                }
            else
                Console.Write("X должен быть меньше единицы.");
            Console.ReadKey(); 
        } 
    }
}
