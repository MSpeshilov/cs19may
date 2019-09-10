using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Задание_12.Вычисление_агрегатов
{
    class Program
    {
        static void Main(string[] args)
        {
            String dd = Console.ReadLine();
            String[] gg = dd.Split(' ');
            int a = 0;
            int b = gg.Length / 3;
            int[] data = new int[gg.Length];
            while(a < gg.Length)
            {
                data[a] = int.Parse(gg[a]);
                a++;
            }a = 0;
            int s;
            int sum;
            int sum1;
            int sum2;
            sum = data[0] + data[1] + data[2];
            sum1 = data[3] + data[4] + data[5];
            sum2 = data[6] + data[7];
            while (a < 2)
            {
                s = data[0] + data[a];
                a++;
                Console.Write("SUMM {0}", s);
            }
            Console.Write("Группа {0} {1} {2} сумма {3}", data[0], data[1], data[2], sum);
            Console.Write("Группа {0} {1} {2} сумма {3}", data[3], data[4], data[5], sum1);
            Console.Write("Группа {0} {1} сумма {2}", data[6], data[7], sum2);
        }
    }
}
