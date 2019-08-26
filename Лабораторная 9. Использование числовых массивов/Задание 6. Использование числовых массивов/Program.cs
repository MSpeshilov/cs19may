using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6.Использование_числовых_массивов
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int[] data = new int[] { 11, 13, 17, 19, 10, 12, 14, 15, 16, 18, 20 };
            int i = 0;
            while (i < data.Length)
            {
                Console.Write(data[i]);
                if(data[i] == x)
                {
                    Console.Write("+");
                }
                Console.WriteLine();
                i++;
            }
        }
    }
}
