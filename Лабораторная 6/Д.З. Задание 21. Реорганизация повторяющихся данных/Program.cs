using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.Задание_21.Реорганизация_повторяющихся_данных
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int q = 1;
            int a = 1;
            if (n < 0)
            {
                Console.WriteLine("Значение N должно быть неотрицательным");
            }
            else
            {
                while (q <= n)
                {
                    Console.Write("#");
                    q = q + 1;
                    a = a + 1;
                    if (a == 21)
                    {
                        Console.WriteLine();
                        a = 1;
                    }
                }
            }
        }
    }
}
