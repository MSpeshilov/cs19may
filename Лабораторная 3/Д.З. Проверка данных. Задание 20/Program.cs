using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.Проверка_данных.Задание_20
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("Уравнение y=0x^2+{0}x+{1} не является квадратным", b, c);
                return;

            }
            double discriminant = b * b - 4 * a * c;
            Console.WriteLine("{0:F4}",discriminant);
        }
    }
}
