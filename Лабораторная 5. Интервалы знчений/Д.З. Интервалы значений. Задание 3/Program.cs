using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.Интервалы_значений.Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("Некорректный интервал. Левая граница должна быть меньше правой.");
                return;
            }
            if (x >= a && b >= x)
            {
                Console.WriteLine("{0} попадает в интервал от {1} до {2}", x, a, b);
            }
            else
            {
                Console.WriteLine("{0} за пределами интервала от {1} до {2}", x, a, b);
            }
            
        }
    }
}
