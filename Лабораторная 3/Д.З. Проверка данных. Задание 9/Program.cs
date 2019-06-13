using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.Проверка_данных.Задание_9
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double sqrt = Math.Sqrt(x + Math.Sqrt(y));
            if (sqrt < 0)
            {
                Console.WriteLine("Подкоренное выражение должно быть неотрицательно");
                return;
            }
            double r = -5 * sqrt;
            Console.WriteLine("{0:F4}", r);
        }
    }
}
