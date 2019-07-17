using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Реорганизация_повторяющихся_данных.Задание_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n < 0)
            {
                Console.Write("Значение N должно быть неотрицательным");
            }
            else
            {
                int a = 0;
                int q= 0;
                
                while (q <= n)
                {
                    Console.WriteLine("{0} - {1}",q,a);
                    q = q + 1;
                    a = a + 1;
                    if (a == 4)
                    {
                        a = 0;
                    }
                }/*
                Console.WriteLine("{0} - {1}",q,a);
                q = q + 1;
                a = a + 1;
                Console.WriteLine("{0} - {1}", q, a);
                q = q + 1;
                a = a + 1;
                Console.WriteLine("{0} - {1}", q, a);
                q = q + 1;
                a = a + 1;
                Console.WriteLine("{0} - {1}", q, a);
                q = q + 1;
                a = a + 1;
                a = 0;
                Console.WriteLine("{0} - {1}", q, a);
                q = q + 1;
                a = a + 1;
                Console.WriteLine("{0} - {1}", q, a);
                q = q + 1;
                a = a + 1;
                Console.WriteLine("{0} - {1}", q, a);
                q = q + 1;
                a = a + 1;
                
                Console.WriteLine("{0} - {1}", q, a);
                q = q + 1;
                a = a + 1;
                a = 0;
                Console.WriteLine("{0} - {1}",q,a);
                q = q + 1;
                a = a + 1;
                Console.WriteLine("{0} - {1}", q, a);
                q = q + 1;
                a = a + 1;
                Console.WriteLine("{0} - {1}", q, a);
                q = q + 1;
                a = a + 1;
                Console.WriteLine("{0} - {1}", q, a);
                q = q + 1;
                a = a + 1;
                a = 0;
                Console.WriteLine("{0} - {1}", q, a);
                q = q + 1;
                a = a + 1;*/
            }
        }
    }
}
