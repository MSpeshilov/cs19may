using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Взаимоисключающие_случаи.Задание_11
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if (a <= 0)
            {
                Console.WriteLine("Значение A должно быть неотрицательным");
                return;
            }
            if (b <= 0)
            {
                Console.WriteLine("Значение B должно быть неотрицательным");
                return;
            }
            if (c <= 0)
            {
                Console.WriteLine("Значение C должно быть неотрицательным");
                return;
            }
            if (a == b||b==c||a==c)
            {
                Console.WriteLine("Треугольник является равнобедренным.");
            }else
            {
                Console.WriteLine("Треугольник не является равнобедренным.");
            }
        }
    }
}
