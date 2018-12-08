using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, i = 1, s = 0;
            int[] c = {1, 3, 5, 7, 11};
            Console.Write("Введите элемент ["+i+"] = ");
            a = Convert.ToInt16(Console.ReadLine());
            if (a == 0)
                Console.WriteLine("Последовательность не может начинатся с символа '0'");
            i += 1;
            if (a != 0)
                do
                {
                    Console.Write("Введите элемент [" + i + "] = ");
                    a = Convert.ToInt16(Console.ReadLine());
                    i += 1;
                    for (int i1 = 0; i1 < 5; i1++)
                        if (c[i1] == i)
                            s += a;
                }
                while (a != 0);
            Console.Write("Сумма чисел порядковые номера которых являются простыми = "+s);
            Console.ReadKey();
        }
    }
}
