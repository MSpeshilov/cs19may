using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_11.Базовые_операции_с_массивами
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            int a = 0;
            String data = Console.ReadLine();
            String[] x;
            x = data.Split(' ');
            if (p < 0 || p > x.Length)
            {
                Console.Write("Число P должно быть в интервале [0, размер массива)");
                return;
            }
            else if (q < 0 || q > x.Length)
            {
                Console.Write("Число Q должно быть в интервале [0, размер массива)");
                return;
            }
            String t;
            String m;
            t = x[p];
            m = x[q];
            x[p] = m;
            x[q] = t;
            
            
                Console.Write("меняю {0} на {1}\n", t, m);
                a = 0;
                while (a < x.Length)
                {
                    Console.Write(x[a] + " ");
                    a++;
                }
            
            
        }
    }
}
