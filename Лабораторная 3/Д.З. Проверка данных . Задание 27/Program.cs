using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.Проверка_данных.Задание_27
{
    class Program
    {
        static void Main(string[] args)
        {
            double h = double.Parse(Console.ReadLine());
            if (h < 0)
            {
                Console.WriteLine("Высота над уровнем Земли должна быть неотрицательна");
                return;
            }
            double r = 6350; //d=sqrt((r+h)^2-r^2)
            double r2 = r * r;
            double rh = r + h;
            double rh2 = rh*rh;
            double d = Math.Sqrt(rh2 - r2);
            Console.WriteLine("{0:F4}", d);
        }
    }
}
