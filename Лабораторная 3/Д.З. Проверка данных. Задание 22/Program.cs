using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.Проверка_данных.Задание_22
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double clnDeg = double.Parse(Console.ReadLine());
            double clnRad = clnDeg * Math.PI / 180;
            double a2 = a * a;
            double b2 = b * b;
            double result = Math.Sqrt(a2 + b2 - 2 * a * b * Math.Cos(clnRad));
            Console.WriteLine("{0:F4}", result);
        }
    }
}
