using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.Интервалы_значений.Задание_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int a = -13;
            int b = -3;
            int c = 5;
            int d = 19;
            if (x >= a && x <= b)
            {
                Console.WriteLine("Красный");
            }else if (x >= c && x <= d)
            {
                Console.WriteLine("Зеленый");
            }
            else
            {
                Console.WriteLine("X не попадает ни в зеленый, ни в красный интервал");
            }
        }
    }
}
