using System;

namespace ConsoleApplication1
{
    class Program
    {
        static int overloadmethod(double a, double b)
        {
            b = Math.Pow(a - b, 2);
            return Convert.ToInt16(b);
        }
        static int overloadmethod(double a, double b, double c)
        {
            c = Math.Pow(a - b, 2);
            return Convert.ToInt16(c);
        }
        static void Main(string[] args)
        {
            Console.Write("Введите значение переменной A = ");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.Write("Введите значение переменной B = ");
            int b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Первый метод = " + overloadmethod(a, b));
            int c = 0;
            Console.WriteLine("Второй метод = " + overloadmethod(a, b, c));
            Console.ReadKey();
        }
    }
}
