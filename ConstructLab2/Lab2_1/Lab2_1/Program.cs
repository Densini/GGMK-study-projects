using System;

namespace Lab2_1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите радиус R = ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите высоту H = ");
            double h = Convert.ToDouble(Console.ReadLine());
            double s = 3.14 * r * 2;
            Console.WriteLine("Площадь основания цилиндра = " + s);
            Console.Write("Объем цилиндра = " + (s * h));
            Console.ReadKey();
        }
    }
}
