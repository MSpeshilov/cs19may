using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.взаимоисключающие_случаи.Задание_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double M = double.Parse(Console.ReadLine());
            double P = double.Parse(Console.ReadLine());
            if (M % P == 0)
            {
                double res = M / P;
                Console.WriteLine(res);
            }
            else
            {
                Console.WriteLine("{0} не делится нацело на {1}", M, P);
            }
        }
    }
}
