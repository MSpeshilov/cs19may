using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_7.Вложенные_циклы
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = int.Parse(Console.ReadLine());
            int t = int.Parse(Console.ReadLine());
            int q = 1;
            if (r < 0)
            {
                Console.Write("Значение R должно быть неотрицательно");
            }else if (t < 0)
            {
                Console.Write("Значение T должно быть неотрицательно");
            }
            else
            {
                while (q <= r)
                {
                    q = q + 1;
                    Console.Write("#");
                }Console.WriteLine();
                q = 1;
                while (q <= t)
                {
                    q = q + 1;
                    Console.Write("#");
                }
            }
        }
    }
}
