﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.текст.Задание_14
{
    class Program
    {
        static void Main(string[] args)
        {
            String a;
            String b;
            String c;

            a = Console.ReadLine();
            b = Console.ReadLine();
            c = Console.ReadLine();

            Console.WriteLine("Квадратное уравнение {0}*x*x + {1}*x + {2} = 0.\nЕго дискриминант вычисляется по формуле: d = {1}*{1} - 4*{0}*{2}", a, b, c);

        }
    }
}
