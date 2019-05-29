using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Вычисления.Задание_5
{
    class Program
    {
        static void Main(string[] args)
        {
            String x1 = Console.ReadLine();
            double num = double.Parse(x1);
            double x;
            x = num * num;
            double result;
            result = 7 * x - 3 * num + 6;
            Console.WriteLine(result);
            
        }
    }
}
