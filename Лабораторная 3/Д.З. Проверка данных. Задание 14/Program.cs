using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.Проверка_данных.Задание_14
{
    class Program
    {
        static void Main(string[] args)
        {
            double temperatureC = double.Parse(Console.ReadLine());
            if (temperatureC < -273.15)
            {
                Console.WriteLine("Температура должна быть выше абсолютного нуля");
                return;
            }
            double temperatureF = temperatureC * 1.8 + 32;
            Console.WriteLine("{0:F4}", temperatureF);
        }
    }
}
