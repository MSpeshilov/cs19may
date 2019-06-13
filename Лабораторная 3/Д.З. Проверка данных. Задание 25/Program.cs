using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.Проверка_данных.Задание_25
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double x2 = x * x;
            double sqrt = Math.Sqrt(a * x2 + b * x + c);

            double R = 1 / sqrt;
            if (sqrt < 0)
            {
                Console.WriteLine("Подкоренное выражение должно быть неотрицательным");
                return;
            }
            if (a <= 0)
            {
                Console.WriteLine("Знаменатель не может быть равен нулю");
                return;
            }
            if (b <= 0)
            {
                Console.WriteLine("Знаменатель не может быть равен нулю");
                return;
            }
            if (c <= 0)
            {
                Console.WriteLine("Знаменатель не может быть равен нулю");
                return;
            }
            if (x <= 0)
            {
                Console.WriteLine("Знаменатель не может быть равен нулю");
                return;
            }
            
            Console.WriteLine("{0:F4}", R);
        }
    }
}
