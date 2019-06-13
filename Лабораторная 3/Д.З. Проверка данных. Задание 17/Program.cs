using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.Проверка_данных.Задание_17
{
    class Program
    {
        static void Main(string[] args)
        {
            double mass = double.Parse(Console.ReadLine());
            double velocity = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double g = 9.8067;
            if (mass < 0)
            {
                Console.WriteLine("Значение mass должно быть положительным");
                return;
            }
            if (velocity < 0)
            {
                Console.WriteLine("Значение velocity должно быть положительным");
                return;
            }
            if (height < 0)
            {
                Console.WriteLine("Значение height должно быть неотрицательным");
                return;
            }
            double kineticEnergy = mass * velocity * velocity / 2;
            double potentialEnergy = mass * g * height;
            Console.WriteLine("Кинетическая энергия составляет: {0:F4} Дж\nПотенциальная энергия составляет: {1:F4} Дж", kineticEnergy, potentialEnergy);


        }
    }
}
