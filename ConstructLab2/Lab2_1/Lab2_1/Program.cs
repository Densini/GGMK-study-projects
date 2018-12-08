using System;

namespace Lab2_1
{
    class Program
    {
        static void Main()
        {
            double s, r, h, v;
            Console.Write("Введите радиус R = ");
            r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите высоту H = ");
            h = Convert.ToDouble(Console.ReadLine());
            s = 3.14 * r * 2;
            v = s * h;
            Console.WriteLine("Площадь основания цилиндра = " + s);
            Console.Write("Объем цилиндра = " + h);
            Console.ReadKey();
        }
    }
}
