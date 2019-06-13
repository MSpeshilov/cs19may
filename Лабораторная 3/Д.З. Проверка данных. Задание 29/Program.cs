using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.Проверка_данных.Задание_29
{
    class Program
    {
        static void Main(string[] args)
        {
            double xa = double.Parse(Console.ReadLine());
            double ya = double.Parse(Console.ReadLine());
            double xb = double.Parse(Console.ReadLine());
            double yb = double.Parse(Console.ReadLine());
            double xba = xb - xa;
            double x2 = xba * xba;
            double yba = yb - ya;
            double y2 = yba * yba;
            double AB = Math.Sqrt(x2 + y2);
            if (AB == 0)
            {
                Console.WriteLine("0");
                return;
            }
            Console.WriteLine("{0:F4}", AB);
        }
    }
}
