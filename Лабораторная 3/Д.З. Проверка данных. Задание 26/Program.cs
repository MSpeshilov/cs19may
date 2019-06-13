using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.Проверка_данных.Задание_26
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double sqrt1 = Math.Sqrt(x + 5);
            double sqrt2 = Math.Sqrt(x - 5);
            double sqrt3 = Math.Sqrt(x);
            if (sqrt1 < 0)
            {
                Console.WriteLine("Подкоренное выражение должно быть неотрицательным");
                return;
            }
            if (sqrt2 < 0)
            {
                Console.WriteLine("Подкоренное выражение должно быть неотрицательным");
                return;
            }
            if (sqrt3 < 0)
            {
                Console.WriteLine("Подкоренное выражение должно быть неотрицательным");
                return;
            }
            double q = 2 * sqrt3;
            double w = sqrt1 + sqrt2;
            double R = w / q;
            Console.WriteLine("{0:F6}",R);
        }
    }
}
