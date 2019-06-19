using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Интервалы_значений.Задание_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double tC = double.Parse(Console.ReadLine());
            double m = 17;
            double c = 4.2E3;
            double tk = tC + 273.15;
            double r = 2.26E6;
            double g = 3.3E5;
            if (tC < -273.15)
            {
                Console.WriteLine("Некорректная температура");
                return;
            } if (tC <= 0)
            {
                double q = m * tk * c;
                Console.WriteLine("Агрегатное состояние: Кристалл\nВнутренняя энергия: {0:F2} Дж",q);
            }
            if (tC >= 100)
            {
                double a = tk * c + r+g;
                double q = m * a;
                Console.WriteLine("Агрегатное состояние: Газ\nВнутренняя энергия {0:F2} Дж",q);
            }
            if ( tC >= 0)
            {
                double a = tk * c + r;
                double q = m * a;
                Console.WriteLine("Агрегатное состояние: Жидкость\nВнутренняя энергия {0:F2}",q);
            }
        }
    }
}
