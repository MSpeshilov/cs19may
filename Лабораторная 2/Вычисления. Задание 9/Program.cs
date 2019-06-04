using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Вычисления.Задание_9
{
    class Program
    {
        static void Main(string[] args)
        {
            String aDeg1 = Console.ReadLine();
            double aDeg = double.Parse(aDeg1);
            double result1;
            result1 = aDeg * Math.PI / 180;
            double result;
            result = Math.Sin(result1);
            Console.WriteLine("{0:F4}",result);

        }
    }
}
