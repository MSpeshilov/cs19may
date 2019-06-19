using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.Взаимлисключающие_случаи.Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double K = double.Parse(Console.ReadLine());
            if (K == 0)
            {
                Console.WriteLine("0");
            }else if (K > 0)
            {
                double sqrt = Math.Sqrt(K);
                Console.WriteLine(sqrt);
            }else
            {
                double K2 = K * K;
                Console.WriteLine(K2);
            }
        }
    }
}
