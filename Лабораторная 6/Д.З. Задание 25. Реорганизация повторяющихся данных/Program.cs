using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.Задание_25.Реорганизация_повторяющихся_данных
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int q = 0;
            int w = 0;
            if (a < 0)
            {
                Console.Write("Значение A должно быть неотрицательно");
            }else if (b < 0)
            {
                Console.Write("Значение B должно быть неотрицательно");
            }
            else
            {
                while (q <= a || w <= b)
                {
                    
                    Console.WriteLine("{0} {1}", q, w);
                    q = q + 1;
                    w = w + 1;
                }
            }
        }
    }
}
