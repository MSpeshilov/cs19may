using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Вычисления.Задание_10
{
    class Program
    {
        static void Main(string[] args)
        {
            String Deg1 = Console.ReadLine();
            double Deg = double.Parse(Deg1);
            double a;
            a = Deg * Math.PI / 180;
            double result;
            result = 5 * Math.Cos(a);
            Console.WriteLine("{0:F4}", result);
        }
    }
}
