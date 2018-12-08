using System;

namespace Lab1_1
{
    class Program
    {
        static void Main()
        {
            int i = 3;
            float s = 5.5f;
            Console.WriteLine("i = " + i);
            Console.WriteLine("s = " + s);
            Console.WriteLine("z = {0:0.000}", s/i);
            Console.ReadKey();
        }
    }
}
