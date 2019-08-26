using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4.Использование_числовых_массивов
{
    class Program
    {
        static void Main(string[] args)
        {
            String dadata = Console.ReadLine();
            String[] data = dadata.Split(',');
            int[] a = new int[data.Length];
            int i = 0;
            int n = 0;
            int t = 1;
            int num = 19;
            while (i < data.Length)
            {
                a[i] = int.Parse(data[i]);
                if (a[n]<= num && a[t] >= num)
                {
                    Console.Write("От {0} до {1}", a[n], a[t]);
                }

                a[n] = a[n + 2];
                a[t] = a[t + 2];
                i++;
            }
        }
    }
}
