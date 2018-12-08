using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static int fun(double a, double b)
        {
            b = Math.Pow(a - b, 2);
            return Convert.ToInt16(b);
        }
        static int fun(double a, double b, double c)
        {
            c = Math.Pow(a-b, 2);
            return Convert.ToInt16(c);
        }
        static void Main(string[] args)
        {
            int a, b, c = 0;
            Console.Write("Введите значение переменной A = ");
            a = Convert.ToInt16(Console.ReadLine());
            Console.Write("Введите значение переменной B = ");
            b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Первый метод = "+fun(a, b));
            Console.WriteLine("Второй метод = "+fun(a, b, c));
            Console.ReadKey();
        }
    }
}
