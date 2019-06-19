using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.Взаимоисключающие_случаи.Задание_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());
            if (x < 0)
            {
                double b = y * y;
                double c = z * z;
                Console.WriteLine("{0};{1:F4};{2:F4}", x, b, c);
            }else if (y < 0)
            {
                double a = x * x;
                double c = z * z;
                Console.WriteLine("{0:F4};{1};{2:F4}", a, y, c);
            }
            else if (z < 0) 
            {
                double a = x * x;
                double b = y * y;
                Console.WriteLine("{0:F4};{1:F4};{2}", a, b, z);
            }else
            {
                double a = x * x;
                double b = y * y;
                double c = z * z;
                Console.WriteLine("{0:F4};{1:F4};{2:F4}", a, b, c);
            }
        }
    }
}
