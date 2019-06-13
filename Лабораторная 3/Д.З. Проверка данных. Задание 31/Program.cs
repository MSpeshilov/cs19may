using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.Проверка_данных.Задание_31
{
    class Program
    {
        static void Main(string[] args)
        {
            double yarnDiameterCm = double.Parse(Console.ReadLine());
            double wireCoils = double.Parse(Console.ReadLine());
            if (yarnDiameterCm <= 0)
            {
                Console.WriteLine("Длина проволоки должна быть неотрицательна");
                return;
            }
            if (wireCoils <= 0)
            {
                Console.WriteLine("Количество витков должно быть неотрицательно");
                return;
            }
            double result = Math.Floor(Math.PI * yarnDiameterCm * wireCoils);
            Console.WriteLine("{0} см", result);
        }
    }
}
