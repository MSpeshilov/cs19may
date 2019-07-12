using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.Реорганизация_повторяющихся_данных.Задание_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("фунт  грамм");
            int f = 1;
            int gr = 453;
            int n = 20;
            while (f <= n)
            {
                Console.WriteLine("{0}  {1}", f, gr);
                f = f + 1;
                gr = gr + 453;
            }
        }
    }
}
