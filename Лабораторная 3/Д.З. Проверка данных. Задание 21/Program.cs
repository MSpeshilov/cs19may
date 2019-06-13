using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.Проверка_данных.Задание_21
{
    class Program
    {
        static void Main(string[] args)
        {
            double mass1 = double.Parse(Console.ReadLine());
            double mass2 = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            if (mass1 <= 0)
            {
                Console.WriteLine("Масса должна быть неотрицательной");
                return;
            }
            if (mass2 <= 0)
            {
                Console.WriteLine("Масса должна быть неотрицательной");
                return;
            }
            if (distance <= 0)
            {
                Console.WriteLine("Дистанция должна быть неотрицательной");
                return;
            }
            double g = 9.8067;
            double q = distance * distance;
            double force = g * mass1 * mass2 / q;
            Console.WriteLine("{0:F4}", force);
        }
    }
}
