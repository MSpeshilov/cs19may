using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Интервалы_значений.Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            if (x > y && x > z)
            {
                Console.WriteLine(x);
            }
            else if (y > x && y > z)
            {
                Console.WriteLine(y);
            }
            else
            {
                Console.WriteLine(z);
            }
        }
    }
}
