using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Вычисления.Задание_8
{
    class Program
    {
        static void Main(string[] args)
        {
            String aDeg1 = Console.ReadLine();
            double aDeg = double.Parse(aDeg1);
            double result;
            result = aDeg * Math.PI / 180;
            Console.WriteLine("{0:F4}", result);
        }
    }
}
