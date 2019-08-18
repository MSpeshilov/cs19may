using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.Задание_13.Базовые_операции_с_массивами
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = int.Parse(Console.ReadLine());
            String data = Console.ReadLine();
            String[] q;
            q = data.Split(' ');
            int b = 1;
            int x = 1;
            int i = q.Length - 1;
            int o = q.Length - 2;
            if (s < 1 || s > i)
            {
                Console.Write("Количество позиций при сдвиге должно быть в интервале [1, длина массива)");
            }
            else
            {
                while (b <= s)
                {
                    x = 1;
                    i = q.Length - 1;
                    o = q.Length - 2;
                    String a = q[i];
                    while (x < q.Length)
                    {
                        q[i] = q[o];
                        i--;
                        o--;
                        x++;
                    }
                    q[0] = a;
                    x = 0;
                    while (x < q.Length)
                    {
                        Console.Write(q[x] + " ");

                        x++;
                    }
                    Console.WriteLine();
                    b++;

                }
            }
            
        }
    }
}
