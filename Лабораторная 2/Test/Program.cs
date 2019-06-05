using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            String ax1 = Console.ReadLine();
            String ay1 = Console.ReadLine();
            String bx1 = Console.ReadLine();
            String by1 = Console.ReadLine();
            double ax = double.Parse(ax1);
            double ay = double.Parse(ay1);
            double bx = double.Parse(bx1);
            double by = double.Parse(by1);
            double ax2;
            ax2 = ax * ax;
            double ay2;
            ay2 = ay * ay;
            double bx2;
            bx2 = bx * bx;
            double by2;
            by2 = by * by;
            double amod;
            amod = Math.Sqrt(ax2 + ay2);
            double bmod;
            bmod = Math.Sqrt(bx2 + by2);
            double productab;
            productab = ax * bx + ay * by;
            
            double angleab;
            angleab = Math.Acos(productab / amod * bmod);
            double q;
            q = Math.Cos(angleab);
            Console.WriteLine("Модуль вектора а = {0:F4}", amod);
            Console.WriteLine("Модуль вектора b = {0:F4}", bmod);
            Console.WriteLine("Скалярное произведение векторов равно {0:F4}", productab);
            Console.Write("Угол между векторами составляет {0:F4} градусов", q);

        }
    }
}
