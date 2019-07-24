using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.Задание_24.Реорганизация_повторяющихся_данных
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = int.Parse(Console.ReadLine());
            int a = 1;
            int b;
            if (y <= 0)
            {
                Console.Write("Значение Y должно быть положительным");
            }
            else
            {
                while (a <= y)
                {
                    a = a + 1;
                    b = y % 1;
                    b = y % y;
                    if (b == 0)
                    {
                        Console.Write("число простое");
                    }
                    else
                    {
                        Console.Write("число не простое");
                    }
                }
            }
        }
    }
}
