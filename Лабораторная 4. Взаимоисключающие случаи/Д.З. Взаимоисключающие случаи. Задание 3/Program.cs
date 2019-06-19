using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.Взаимоисключающие_случаи.Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine());
            if (A >= 0)
            {
                Console.WriteLine(A);
            }else
            {
                double abs = Math.Abs(A);
                Console.WriteLine(abs);
            }
        }
    }
}
