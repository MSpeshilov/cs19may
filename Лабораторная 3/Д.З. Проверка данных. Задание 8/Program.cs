using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.Проверка_данных.Задание_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double sqrt = Math.Sqrt(-7 * b);
            if (sqrt < 0)
            {
                Console.WriteLine("Подкоренное выражение должно быть неотрицательно");
                return;
            }
            double result = a * sqrt;
            Console.WriteLine("{0:F4}", result);
        }
    }
}
