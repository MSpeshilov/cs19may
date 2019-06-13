using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.Проверка_данных.Задание_10
{
    class Program
    {
        static void Main(string[] args)
        {
            double xa = double.Parse(Console.ReadLine());
            double ya = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double angleDeg = double.Parse(Console.ReadLine());
            if (distance <= 0)
            {
                Console.WriteLine("Горизонтальное проложение линии должно быть положительно");
                return;
            }
            if (angleDeg < 0)
            {
                Console.WriteLine("Угол должен быть неотрицательным");
                return;
            }
            double angleRad = angleDeg * Math.PI / 180;
            double dx = distance * Math.Cos(angleRad);
            double dy = distance * Math.Sin(angleRad);
            double bx = xa + dx;
            double by = ya + dy;
            Console.WriteLine("Прирацение координат: dX = {0:F4}; dY = {1:F4}\nКоординаты второй точки ({2:F4}; {3:F4})", dx, dy, bx, by);
        }
    }
}
