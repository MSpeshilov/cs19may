using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.Реорганизация_повторяющихся_данных.Задание_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = int.Parse(Console.ReadLine());
            int i = 1;
            int p = i * v;
            Console.WriteLine("Таблица умножения на {0}", v);
            while (i <= 9)
            {
                Console.WriteLine("{0} x {1} = {2}", i, v, p);
                i = i + 1;
                p = i * v;
            }
        }
    }
}
