using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.Интервалы_значений.Задание_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());
            double a = -3;
            double b = 5;
            if (x > a && x < b)
            {
                Console.Write("{0} ", x);
            }
            if (y > a && y < b)
            {
                Console.Write("{0} ", y);
            }
            if (z > a && z < b)
            {
                Console.Write("{0} ", z);
            }
        }
    }
}
