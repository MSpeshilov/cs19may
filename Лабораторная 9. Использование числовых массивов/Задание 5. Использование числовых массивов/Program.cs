using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5.Использование_числовых_массивов
{
    class Program
    {
        static void Main(string[] args)
        {
            String x = Console.ReadLine();
            String[] data = new String[8] { "a", "b", "c", "d", "e", "f", "g", "h" };
            int i = 0;
            int o = 0;
            while (i < data.Length)
            {
                Console.Write(data[i]);
                if (data[i] == x)
                {
                    Console.Write("+");
                }
                Console.WriteLine();
                i++;
            }
        }
    }
}
