using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.Проверка_данных.Задание_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            if (x < 0)
            {
                Console.WriteLine("Значение X должно быть неотрицательным");
                return;
            }
            double result = Math.Sqrt(x);
            Console.WriteLine("{0:F4}", result);
        }
    }
}
