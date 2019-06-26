using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.Интервалы_значений.Задание_9
{
    class Program
    {
        static void Main(string[] args)
        {
            double xa = double.Parse(Console.ReadLine());
            double ya = double.Parse(Console.ReadLine());
            double xb = double.Parse(Console.ReadLine());
            double yb = double.Parse(Console.ReadLine());
            double dx = xb - xa;
            double dy = yb - ya;
            double dy2 = dy * dy;
            double dx2 = dx * dx;
            /*double xa2 = xa * xa;
            double xb2 = xb * xb;
            double ya2 = ya * ya;
            double yb2 = yb * yb;
            double xmod = Math.Sqrt(xa2 * xb2);
            double ymod = Math.Sqrt(ya2 * yb2);*/
            double dmod = Math.Sqrt(dy2 / dx2);
            double r = Math.Atan(dmod);
            Console.WriteLine(r);
        }
    }
}
