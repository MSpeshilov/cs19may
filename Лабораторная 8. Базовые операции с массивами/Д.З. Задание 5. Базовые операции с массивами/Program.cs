﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.Задание_5.Базовые_операции_с_массивами
{
    class Program
    {
        static void Main(string[] args)
        {
            String data = Console.ReadLine();
            String[] q;
            int a = 0;
            int b = 1;
            q = data.Split(',');
            while (a < q.Length)
            {
                Console.WriteLine("Глава " + b + " " + q[a]);
                a++;
                b++;
            }
        }
    }
}
