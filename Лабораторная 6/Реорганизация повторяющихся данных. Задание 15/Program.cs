using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Реорганизация_повторяющихся_данных.Задание_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a == b)
            {
                Console.Write("Границы равны\n{0}", a);
            }
            else if (a < b)
            {
                Console.WriteLine("От A до B");
                while (a <= b)
                {
                    Console.Write("{0} ", a);
                    a = a + 1;
                } 
            }
            else
            {
                Console.WriteLine("От B до A");
                while (b <= a)
                {
                    Console.Write("{0} ", b);
                    b = b + 1;
                } 
            }
        }
    }
}
