using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5.Вложенные_циклы
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int w = int.Parse(Console.ReadLine());
            int q = 0;
            int a = 0;
            int b = 9;
            if (w < 0 || w > 20)
            {
                Console.Write("Значение W должно быть в интервале [0, 20]");
            }
            else
            {
                while (a <= b)
                {
                    Console.WriteLine(a);
                    a = a + 1;
                    
                    while (q <= w)
                    {
                        Console.Write(a);
                        q = q + 1;
                    }
                }
             
            }*/

            int w = int.Parse(Console.ReadLine());
            int q = 1;
            int a = 0;
            if (w < 0 || w > 20)
            {
                Console.Write("Значение W должно быть в интервале [0, 20]");
            }
            else
            {
                while (a <= 9)
                {
                    while (q <= w)
                    {
                        q = q + 1;
                        Console.Write(a);
                    }
                    Console.WriteLine();
                    q = 1;
                    a = a + 1;
                }
                /*while (q <= w)
                {
                    q = q + 1;
                    Console.Write(a);
                }
                Console.WriteLine();
                q = 1;
                a = a + 1;
                while (q <= w)
                {
                    
                    q = q + 1;
                    Console.Write(a);
                    
                }
                Console.WriteLine();
                q = 1;
                a = a + 1;
                while (q <= w)
                {
                    q = q + 1;
                    Console.Write(a);
                }
                Console.WriteLine();
                a = a + 1;
                q = 1;
                while (q <= w)
                {
                    q = q + 1;
                    Console.Write(a);
                }
                Console.WriteLine();
                a = a + 1;
                q = 1;
                while (q <= w)
                {
                    q = q + 1;
                    Console.Write(a);
                }
                Console.WriteLine();
                a = a + 1;
                q = 1;
                while (q <= w)
                {
                    q = q + 1;
                    Console.Write(a);
                }
                Console.WriteLine();
                a = a + 1;
                q = 1;
                while (q <= w)
                {
                    q = q + 1;
                    Console.Write(a);
                }
                Console.WriteLine();
                a = a + 1;
                q = 1;
                while (q <= w)
                {
                    q = q + 1;
                    Console.Write(a);
                }
                Console.WriteLine();
                a = a + 1;
                q = 1;
                while (q <= w)
                {
                    q = q + 1;
                    Console.Write(a);
                }
                Console.WriteLine();
                a = a + 1;
                q = 1;
                while (q <= w)
                {
                    q = q + 1;
                    Console.Write(a);
                }*/

            }
        }
    }
}
