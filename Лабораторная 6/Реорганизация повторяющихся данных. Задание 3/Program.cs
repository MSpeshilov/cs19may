using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Реорганизация_повторяющихся_данных.Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            String x = Console.ReadLine();
            int q;//счетчик
            q = 1;
            int p;// ограничитель
            p = 7;

            Console.Write("\"");
            while (q <= p)
            {
                Console.Write(x);
                q = q + 1;
            } Console.Write("\"");
        }
    }
}
