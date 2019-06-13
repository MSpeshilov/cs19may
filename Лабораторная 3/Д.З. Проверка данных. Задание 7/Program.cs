﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.Проверка_данных.Задание_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double s = 61 - x;
            if (s < 0)
            {
                Console.WriteLine("Подкоренное выражение должно быть неотрицательным");
                return;
            }
            double sqrt = Math.Sqrt(s);
            double result = 3 * sqrt;
            Console.WriteLine("{0:F4}", result);
        }
    }
}
