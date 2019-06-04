using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.Вычисления.Задание_12
{
    class Program
    {
        static void Main(string[] args)
        {
            String aDeg1 = Console.ReadLine();
            String bDeg1 = Console.ReadLine();
            double aDeg = double.Parse(aDeg1);
            double bDeg = double.Parse(bDeg1);
            double aRad;
            aRad = aDeg * Math.PI / 180;
            double bRad;
            bRad = bDeg * Math.PI / 180;
            double result;
            result = 3 * Math.Sin(2 * aRad) * Math.Cos(3 * bRad);
            Console.WriteLine("{0:F4}", result);
        }
    }
}
