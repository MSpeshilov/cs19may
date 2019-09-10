using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_10.Использование_числовых_массивов
{
    class Program
    {
        static void Main(string[] args)
        {
            String dd = Console.ReadLine();
            String[] data = dd.Split(' ');
            int a = 0;
            int b = data.Length - 1;
            int c = 0;
            int d = 1;
            int e = 0;
            //int f = 0;
            int[] num = new int[data.Length];
            if (String.IsNullOrEmpty(dd))
            {
                Console.Write("Массив пуст");
                return;
            }
            while (a< data.Length)
            {
                num[a] = int.Parse(data[a]);
                a++;
            }a = 0;
            while (e < data.Length)
            {
                Console.Write("шаг {0} ", e);
                

                while (a < b)
                {

                    if (num[a] > num[d])
                    {
                        c = num[d];
                        num[d] = num[a];
                        num[a] = c;
                        Console.Write(" Меняем {0} и {1}", num[a], num[d]);
                    }
                    else
                    {
                        Console.Write(" Оставляем {0} и {1}", num[a], num[d]);
                    }
                    
                    d++;
                    a++;

                }
                Console.WriteLine();
                a = 0;
                while (a < data.Length)
                {
                    Console.Write("{0} ", num[a]);

                    a++;
                }
                d = 1;
                a = 0;
                e++;
                
            }
              
        }
    }
}
