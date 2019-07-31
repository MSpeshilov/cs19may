using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3.Вложенные_циклы
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine());
            int q = 1;
            if (w <0 || w > 20)
            {
                Console.Write("Значение W должно быть в интервале [0, 20]");
            }
            else
            {
                while (q <= w)
                {
                    q = q + 1;
                    Console.Write("a");
                }Console.WriteLine();
                q = 1;
                while (q <= w)
                {
                    q = q + 1;
                    Console.Write("b");
                }
                Console.WriteLine();
                q = 1;
                while (q <= w)
                {
                    q = q + 1;
                    Console.Write("c");
                }
                Console.WriteLine();
                q = 1;
                while (q <= w)
                {
                    q = q + 1;
                    Console.Write("d");
                }
                Console.WriteLine();
                q = 1;
                while (q <= w)
                {
                    q = q + 1;
                    Console.Write("e");
                }
                Console.WriteLine();
                q = 1;
                while (q <= w)
                {
                    q = q + 1;
                    Console.Write("f");
                }
                Console.WriteLine();
                q = 1;
                while (q <= w)
                {
                    q = q + 1;
                    Console.Write("g");
                }
                Console.WriteLine();
                q = 1;
                while (q <= w)
                {
                    q = q + 1;
                    Console.Write("h");
                }

            }
        }
    }
}
