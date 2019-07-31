using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.Задание_23.Реорганизация_повторяющихся_данных
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int a = 0;
            int b ;
            int q = x / 2;
            if (x <= 0)
            {
                Console.Write("Значение X должно быть положительным");
            }
            else
            {
                while (a <= q)
                {
                    a = a + 1;
                    b = x % a;
                    if (b == 0)
                    {
                        Console.Write("{0} ", a);

                    }
                }Console.Write(x);
            }
            
        }
    }
}
