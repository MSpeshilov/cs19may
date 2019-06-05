using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проверка_данных.Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            String edge1 = Console.ReadLine();
            String height1 = Console.ReadLine();
            double edge = double.Parse(edge1);
            double height = double.Parse(height1);
            if (edge <= 0)
            {
                Console.WriteLine("Длина основания треугольника должна быть положительна");
                return;
            }
            if (height <= 0)
            {
                Console.WriteLine("Высота треугольника должна быть положительна");
                return;
            }

            double area;
            area = edge * height / 2;
            Console.WriteLine("area = {0:F2}", area);
        }
    }
}
