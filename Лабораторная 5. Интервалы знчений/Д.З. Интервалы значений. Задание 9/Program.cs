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
            double dxabs = Math.Abs(dx);
            double dyabs = Math.Abs(dy);
            double r = Math.Atan(dyabs/dxabs);
            double rr = r * 180 / Math.PI;
            double xba = xb - xa;
            double yba = yb - ya;
            double x2 = xba * xba;
            double y2 = yba * yba;
            double q = Math.Sqrt(x2 +y2);

            if (dx >= 0 && dy > 0)
            {
                Console.WriteLine("Угол в 1 четверти\nГоризонтальное проложение {0:F4}\nДирекционный угол {1:F4}", q, rr);
            }
            
        }
    }
}
