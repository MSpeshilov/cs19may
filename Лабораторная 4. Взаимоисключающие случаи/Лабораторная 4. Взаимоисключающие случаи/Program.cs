using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_4.Взаимоисключающие_случаи
{
    class Program
    {
        static void Main(string[] args)
        {
            double P = double.Parse(Console.ReadLine());
            double Q = double.Parse(Console.ReadLine());
            
            if (P >= Q)
            {
                Console.Write("Максимальное {0}, ", P);
            }
            else
            {
                Console.Write("Максимальное {0}, ", Q);

            }
            if (P <= Q)
            {
                Console.Write("Минимальное {0}, ", P);
            }
            else
            {
                Console.Write("Минимальное {0}, ", Q);

            }
            if (P >= Q)
            {
                double t = P-Q;
                Console.Write(t);
            }
            else
            {
                double t = Q-P;
                Console.Write(t);
            }
            
        }
    }
}
