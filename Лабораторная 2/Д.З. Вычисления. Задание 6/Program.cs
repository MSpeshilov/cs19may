using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.Вычисления.Задание_6
{
    class Program
    {
        static void Main(string[] args)
        {
            String a1 = Console.ReadLine();
            double num = double.Parse(a1);
            double a;
            a = num * num;
            double result;
            result = 12 * a + 7 * num - 16;
            Console.WriteLine("{0:F4}", result);
        }
    }
}
