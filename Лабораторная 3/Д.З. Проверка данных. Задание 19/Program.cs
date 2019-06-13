using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.Проверка_данных.Задание_19
{
    class Program
    {
        static void Main(string[] args)
        {
            double mass = double.Parse(Console.ReadLine());
            double aDeg = double.Parse(Console.ReadLine());
            if (mass <= 0)
            {
                Console.WriteLine("Масса должна быть положительной");
                return;
            }
            double aRad = aDeg * Math.PI / 180;
            double g = 9.8067;
            double result = mass * g * Math.Cos(aRad);
            if (result == 0)
            {
                Console.WriteLine("{0:F0}",result);
                return;
            }
            Console.WriteLine("{0:F6}",result);
        }
    }
}
