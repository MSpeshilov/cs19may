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
            int rr = data.Length / 2;
            int qwer = data.Length % 2;
            if (qwer == 0)
            {
                while (i < data.Length)
                {
                    a[i] = int.Parse(data[i]);

                    i++;
                }
                i = 0;
                while (i < rr)
                {
                    if (a[n] <= num && a[t] >= num)
                    {
                        Console.WriteLine("От {0} до {1}<--", a[n], a[t]);

                    }
                    else
                    {
                        Console.WriteLine("От {0} до {1}", a[n], a[t]);
                    }

                    n = n + 2;
                    t = t + 2;
                    i++;
                }
            }
            else
            {
                Console.Write("У последнего интервала отсутствует одна из границ");
            }
            
        }
    }
}
