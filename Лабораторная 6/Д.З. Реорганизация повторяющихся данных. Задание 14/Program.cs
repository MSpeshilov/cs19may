using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.Реорганизация_повторяющихся_данных.Задание_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            
            if (a > b)
            {
                Console.Write("Значение A должно быть не больше значения B");
            }
            else
            {
                Console.Write("{");
                while (b >= a)
                {
                    Console.Write(" {0} ", b);
                    b = b - 1;
                }Console.Write("}");
            }
        }
    }
}
