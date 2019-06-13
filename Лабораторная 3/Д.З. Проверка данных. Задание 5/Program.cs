using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.Проверка_данных.Задание_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            if (radius <= 0)
            {
                Console.WriteLine("Значение radius должно быть положительным");
                return;
            }
            double cube = radius * radius * radius;
            double volume = 4 * Math.PI * cube / 3;
            Console.WriteLine("{0:F4}", volume);

        }
    }
}
