using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.Проверка_данных__Задание_16
{
    class Program
    {
        static void Main(string[] args)
        {
            double initialVelocity = double.Parse(Console.ReadLine());
            double time = double.Parse(Console.ReadLine());
            double acceleration = double.Parse(Console.ReadLine());
            if (time <= 0)
            {
                Console.WriteLine("Время должно быть положительным");
                return;
            }
            if (initialVelocity < 0)
            {
                Console.WriteLine("Начальная скорость должна быть неотрицательна");
                return;
            }
            double time2 = time * time;
            double distance = initialVelocity * time + acceleration * time2 / 2;
            Console.WriteLine("{0:F2}", distance);
        }
    }
}
