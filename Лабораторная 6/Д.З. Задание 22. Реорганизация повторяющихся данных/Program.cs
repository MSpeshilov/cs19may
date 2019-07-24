using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.Задание_22.Реорганизация_повторяющихся_данных
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int a = 30;
            int b = 40;
            if (x < a || x > b)
            {
                while (a <= b)
                {
                    Console.WriteLine("{0}-", a);
                    a = a + 1;
                }
            }
            else
            {
                while (a <= b)
                {

                    Console.Write(a);
                    if (a == x)
                    {
                        Console.Write("+");

                    }else if (x < b || x > a)
                    {
                        Console.Write("-");
                    }
                    Console.WriteLine();
                    a = a + 1;

                }
            }
        }
    }
}
