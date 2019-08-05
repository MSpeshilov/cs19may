using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.Задание_8.базовые_операции_с_массивами
{
    class Program
    {
        static void Main(string[] args)
        {
            String data = Console.ReadLine();
            String[] q;
            int a = 0;
            int b = 1;
            q = data.Split(' ');
            if (String.IsNullOrEmpty(data))
            {
                Console.Write("Нет данных");
                return;
            } while (b <= q.Length)
            {
                while (a <= q.Length)
                {
                    Console.WriteLine(q[a]);
                    a++;
                }
                Console.WriteLine(q[b]);
                b++;
                
            }
        }
    }
}
