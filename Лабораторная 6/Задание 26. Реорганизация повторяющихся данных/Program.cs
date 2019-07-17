using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_26.Реорганизация_повторяющихся_данных
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = int.Parse(Console.ReadLine());
            int w =  y + 1;

            int q = 1;
            int a = 1;
            if (y < 1 || y > 15)
            {
                Console.Write("Значение Y должно быть в интервале [0, 15]");
            }
            else
            {
                while (q <= y)
                {
                    Console.Write("#");
                    q = q + 1;
                    a = a + 1;
                    if (a == w)
                    {
                        Console.Write(".");
                        a = 1;
                        
                    }
                }
            }
        }
    }
}
