using System;
namespace ConsoleApplication1
{
    interface IComparable
    {
        int CompareTo(object obj);
    }
    class TESTING : IComparable
    {
        public string name;
        public string date;
        public int questions;
        protected void vvod()
        {
            Console.Write("Введите наименование тестирования: ");
            this.name = Console.ReadLine();
            Console.Write("Введите дату сдачи: ");
            this.date = Console.ReadLine();
            Console.Write("Введите количество вопросов: ");
            this.questions = Convert.ToInt16(Console.ReadLine());
        }
        public void vivod()
        {
            Console.WriteLine("Наименование тестирования - " + name);
            Console.WriteLine("Дата сдачи - " + date);
            Console.WriteLine("Количество вопросов - " + questions);
            Console.WriteLine();
        }
        public override bool Equals(object obj)
        {
            TESTING temp = (TESTING)obj;
            if (this.questions == temp.questions)
                return (true);
            else
                return (false);
        }
        public override int GetHashCode()
        {
            return questions.GetHashCode();
        }
    }
    class Test : TESTING
    {
        public Test()
        {
            vvod();
        }
    }
    class Ex : TESTING
    {
        public Ex()
        {
            vvod();
        }
    }
    class FinalEx : TESTING
    {
        public FinalEx()
        {
            vvod();
        }
    }
    class StreathTry : TESTING
    {
        public StreathTry()
        {
            vvod();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int oo = 0;
            int pp = 0;
            string mm = "";
            string p = "";
            TESTING[] d = new TESTING[20];
            int n = 0;
            bool t = false;
            while (t != true)
            {
                Console.Clear();
                Console.WriteLine("1 - добавление нового тестирования");
                Console.WriteLine("2 - вывод всех тестирований");
                Console.WriteLine("3 - сравнить количества вопросов");
                Console.WriteLine("4 - выход");
                string x = Console.ReadLine();
                while (true)
                {
                    if (x == "1" || x == "2" || x == "3" || x == "4")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("нет такого варианта ответа! ");
                        Console.Write("введите значение снова: ");
                        x = Console.ReadLine();
                    }
                }
                int y = Convert.ToInt32(x);
                switch (y)
                {
                    case 1:
                        Console.WriteLine("выберите тип тестирования: ");
                        Console.WriteLine(" 1 - Тест ");
                        Console.WriteLine(" 2 - Экзамен");
                        Console.WriteLine(" 3 - Выпускной экзамен");
                        Console.WriteLine(" 4 - Испытание");
                        x = Console.ReadLine();
                        while (true)
                        {
                            if (x == "1" || x == "2" || x == "3" || x == "4")
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("нет такого варианта ответа! ");
                                Console.Write("введите значение снова: ");
                                x = Console.ReadLine();
                            }
                        }
                        y = Convert.ToInt32(x);
                        switch (y)
                        {
                            case 1:
                                d[n] = new Test();
                                break;
                            case 2:
                                d[n] = new Ex();
                                break;
                            case 3:
                                d[n] = new FinalEx();
                                break;
                            case 4:
                                d[n] = new StreathTry();
                                break;
                        }
                        n++;
                        break;
                    case 2:
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine("#" + (i + 1));
                            d[i].vivod();
                        }
                        Console.Write("Нажмите любую клавишу для продолжения...");
                        Console.ReadKey(); break;
                    case 3:
                        Console.Write("Введите наименование первого тестирования = ");
                        mm = Console.ReadLine();
                        for (int i = 0; i < n; ++i)
                        {
                            if (d[i].name == mm) oo = i;
                        }
                        Console.Write("Ввведите наименование второго тестирования = ");
                        p = Console.ReadLine();
                        for (int i = 0; i < n; ++i)
                        {
                            if (d[i].name == p) pp = i;
                        }

                        if (d[oo].Equals(d[pp])) //Использовать Comp вместо Equals
                            Console.WriteLine("Количество вопросов одинаково");
                        else Console.WriteLine("Количество вопросов различно");

                        Console.Write("Нажмите любую клавишу для продолжения...");
                        Console.ReadKey();
                        break;
                    case 4:
                        t = true;
                        break;
                }
            }
        }
    }
}

