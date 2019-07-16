using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.Реорганизация_повторяющихся_данных.Задание_16
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a < b)
            {
                Console.WriteLine("По возрастанию");
                while (a <= b)
                {
                    Console.Write("{0} ", a);
                    a = a + 1;
                }
            }else
            {
                Console.WriteLine("По убыванию");
                while (b <= a)
                {
                    Console.Write("{0} ", a);
                    a = a - 1;
                }
            }
        }
    }
}
