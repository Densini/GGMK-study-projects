using System;

namespace Lab4_2
{
    class Program
    {
        static int tickets(string a)
        {
            int a1 = 0, a2 = 0;
            for (int i = 0; i < 3; i++)
                a1 += Convert.ToInt16(a[i]);
            for (int i = 0; i < 3; i--)
                a2 += Convert.ToInt16(a[i]);
            if (a1 == a2)
                return Convert.ToInt16(a);
        }
        static void Main()
        {
            Console.WriteLine("Список счастливых билетов:");
            for (int i = 100000; i < 1000000; i++)
            {
                string a = Convert.ToString(i);
                Console.WriteLine(tickets(a));
            }
        }
    }
}
