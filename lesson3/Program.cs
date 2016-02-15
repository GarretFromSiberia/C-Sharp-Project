using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 1;
            //string str = "www";

            // ValueAndRefTypes();
            //ExplicitImplicit();
            //Func();
            //IfThen();
            //ForDoWhile();
            //Zadanie();
            //Methods.Demo - подтягивает из программы metods
            Homework_2();
            Console.ReadLine();
        }
        static void ValueAndRefTypes()
        {
            int a = 5;//stack: [a,5]
            int b = a;//stack: [a,5], [b,5]

            b = 10;

            string str = "abvs";//stack:[ref str] heap[abvs]
            string str1 = str;//stack [ref str], ref[str1], heap[abvs]
            str1 = "aaaaa";
        }

        static void ExplicitImplicit()
        {
            short a = 5; 
            int b = a; // неявное преобразование типов short к int, по факту совпадает с присваиванием. 
                        //Неявное - компилятор делает все за нас
            Add(a, a);
            // short d = b; неявно преобразовать НЕ получится
            short d = (short)b;//явное преобразование
        }

        static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        static void Func()
        {
            int a = 1000;
            long b = a;
            int c = (int)b;
            Console.WriteLine("{0},{1},{2}",a,b,c);
        }

        static void IfThen()
        {
            int d = 5;

            if (d == 4)
            {
                Console.WriteLine("d=4");
            }
            else
            {
                Console.WriteLine("d не равно 5");

            }
          //  if d == 3;
           // Console.WriteLine("d=3"); распространяется только на 1 строчку
        }

        static void ForDoWhile()
        {
            for (int i = 0; i < 10; i++)//включает счетчик который считает от 0 до 10,  i++ - унарная операция инкремента
            //он увеличивает на 1
            {
                Console.WriteLine("i = {0}", i);
            }
            int w = 5;
            while (w == 5)
            {
                Console.WriteLine("w={0}", w);
                w++;
            }

            int d = 10;

            do
            {
                Console.WriteLine("d={0}", d);
            }
            while (d == 11);
        }

        static void Zadanie()
        {
            Console.WriteLine("Введите первое число: ");
            string str1 = Console.ReadLine();
            Console.WriteLine("Введите второе число: ");
            string str2 = Console.ReadLine();
            int a = int.Parse(str1);
            int b = int.Parse(str2);

          /*  for ()
            {
                Console.WriteLine("Пожалуйста, введите число");
            } */

            if (a > b)
            {
                Console.WriteLine("{0} больше {1}", str1, str2);
            }

            if (a < b)
            {
                Console.WriteLine("{0} меньше {1}", str1, str2);
            }
            if (a == b) 
            {
                Console.WriteLine("{0} равно {1}", str1, str2);
            }
          
        }

        static void Homework_2()
        {
            First:
            Console.WriteLine("Задайте радиус окружности: ");
            string str = Console.ReadLine();

            double R;           
            if (double.TryParse(str, out R))
            {
                Console.WriteLine();
            }
           else
            {
                Console.WriteLine("Ошибка ввода");
                goto First;
            } 

            Second:
            Console.WriteLine("Введите координату x: ");
            string str1 = Console.ReadLine();

            double x;              
            if (double.TryParse(str1, out x))
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Ошибка ввода");
                goto Second;
            }

            Third:
            Console.WriteLine("Введите координату y: ");
            string str2 = Console.ReadLine();

            double y;
            if (double.TryParse(str2, out y))
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Ошибка ввода");
                goto Third;
            }         
            
            if ((x*x)+(y*y)==(R*R))
            {
                Console.WriteLine("Точка (x = {0}, y = {1}) лежит на границе окружности с радиусом R = {2}", str1,str2,str);
                Console.WriteLine("Нажмите Enter, чтобы выйти из программы");
            }

            if ((x * x) + (y * y) < (R * R))
            {
                Console.WriteLine("Точка (x = {0}, y = {1}) попадает в круг с радиусом R = {2}", str1, str2, str);
                Console.WriteLine("Нажмите Enter, чтобы выйти из программы");
            }
            if ((x * x) + (y * y) > (R * R))
            {
                Console.WriteLine("Точка (x = {0}, y = {1}) не попадает в круг с радиусом R = {2}", str1, str2, str);
                Console.WriteLine("Нажмите Enter, чтобы выйти из программы");
            }
        }
      
    }
}
/*namespace lesson4
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}*/
    
