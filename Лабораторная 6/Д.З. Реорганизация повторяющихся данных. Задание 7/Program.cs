using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.Реорганизация_повторяющихся_данных.Задание_7
{
    class Program
    {
        static void Main(string[] args)
        {int x = int.Parse(Console.ReadLine());
            int i = 1;
            int n = 11;
            int q = x - 40;
            while (i <= n)
            {
                Console.Write("{0} ",x);
                i = i + 1;
                x = x + 3;
            } i = 1;
            Console.Write("\n");
            while (i <= n)
            {
                Console.Write("{0} ", q);
                i = i + 1;
                q = q + 4;
            }
        }
    }
}
