using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Вычисления.Задание_4
{
    class Program
    {
        static void Main(string[] args)
        {
            String x1s = Console.ReadLine();
            String x2s = Console.ReadLine();
            String x3s = Console.ReadLine();

            double x1 = double.Parse(x1s);
            double x2 = double.Parse(x2s);
            double x3 = double.Parse(x3s);

            double result;
            result = x1 * x2 + x1 * x3 + x2 * x3;
            Console.WriteLine(result);
        }
    }
}
