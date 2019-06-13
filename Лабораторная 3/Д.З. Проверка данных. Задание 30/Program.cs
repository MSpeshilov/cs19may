using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.Проверка_данных.Задание_30
{
    class Program
    {
        static void Main(string[] args)
        {
            double volume1 = double.Parse(Console.ReadLine());
            double temperature1 = double.Parse(Console.ReadLine());
            double volume2 = double.Parse(Console.ReadLine());
            double temperature2 = double.Parse(Console.ReadLine());
            if (volume1 <= 0)
            {
                Console.WriteLine("Объем должен быть неотрицательным");
                return;
            }
            if (volume2 <= 0)
            {
                Console.WriteLine("Объем должен быть неотрицательным");
                return;
            }
            double volume = volume1 + volume2;
            double ch = temperature1 * volume1 + temperature2 * volume2;
            double temperature = ch / volume;
            Console.WriteLine("Объем смеси: {0} л\nТемпература смеси: {1:F4} ℃", volume, temperature);
        }
    }
}
