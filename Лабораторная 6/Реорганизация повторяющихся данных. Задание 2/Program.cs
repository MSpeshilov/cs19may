using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Реорганизация_повторяющихся_данных.Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int n;
            n = a + 9;

            while (a <= n)
            {
                Console.WriteLine("{0}\n---", a);
                a = a + 1;
            }
        }
    }
}
