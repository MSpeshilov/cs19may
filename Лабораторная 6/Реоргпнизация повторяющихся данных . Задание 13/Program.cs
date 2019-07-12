using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Реоргпнизация_повторяющихся_данных.Задание_13
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
                return;
            } while (a <= b)
            {
                Console.Write("{0};", a);
                a = a + 1;
            }
        }
    }
}
