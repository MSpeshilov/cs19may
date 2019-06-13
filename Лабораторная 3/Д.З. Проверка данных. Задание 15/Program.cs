using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.Проверка_данных.Задание_15
{
    class Program
    {
        static void Main(string[] args)
        {
            double velocity1 = double.Parse(Console.ReadLine());
            double velocity2 = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            if (velocity1< 0){
                Console.WriteLine("Скорость должна быть неотрицательна");
                return;
            }
            if (velocity2 < 0)
            {
                Console.WriteLine("Скорость должна быть неотрицательна");
                return;
            }
            if (distance < 0)
            {
                Console.WriteLine("Расстояние должно быть неотрицательно");
                return;
            }
            double vv = velocity1 + velocity2;
            double time = distance / vv;
            Console.WriteLine("{0:F4}", time);
        }
    }
}
