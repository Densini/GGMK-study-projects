using System;

namespace Lab1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            double s, z;
            i = 3;
            s = 5.5;
            z = s / i;
            Console.WriteLine("i=" + i);
            Console.WriteLine("s=" + s);
            Console.WriteLine("z={0:0.000}", z);
            Console.ReadLine();
        }
    }
}
