using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.Реорганизация_повторяющихся_данных.Задание_17
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int f = 1;
            
            if (a < b)
            {
                int q = b - a + 1;
                while (f <= q)
                {
                    Console.WriteLine("{0} {1}",a,b);
                    f = f + 1;
                    a = a + 1;
                    b = b - 1;
                    
                }
                Console.WriteLine("Всего строк {0}", q);
            }else
            {
                int q = a - b + 1;
                while (f <= q)
                {
                    Console.WriteLine("{0} {1}", b, a);
                    f = f + 1;
                    a = a - 1;
                    b = b + 1;

                }
                Console.WriteLine("Всего строк {0}", q);
            }
            
        }
    }
}
