using System;

namespace Lab3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число = ");
            int a = Convert.ToUInt16(Console.ReadLine());
            Console.Write("Введите второе число = ");
            int b = Convert.ToUInt16(Console.ReadLine());
            if (a > b)
                Console.Write("Первое число больше второго и равно = " + a);
            else
            {
                Console.WriteLine("Первое число не больше второго и равно = " + a);
                Console.Write("Второе число = " + b);
            }
            Console.ReadKey();
        }
    }
}
