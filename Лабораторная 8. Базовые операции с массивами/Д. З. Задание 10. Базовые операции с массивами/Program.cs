using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.Задание_10.Базовые_операции_с_массивами
{
    class Program
    {
        static void Main(string[] args)
        {
            String left = Console.ReadLine();
            String right = Console.ReadLine();
            String[] q;
            q = left.Split(' ');
            String[] w;
            w = right.Split(' ');
            int i = 0;
            int a = 0;
            
            int b = 0;
            while (i < 5)
            {
                if(q[a] != w[b])
                {
                    Console.Write("Массивы начинают различаться на индексе {0}",b);
                    break;
                }/*else if (left.Length< right.Length)
                {
                    
                    Console.Write("Массивы начинают различаться на индексе {0}", left.Length);
                    break;
                }*/
                
                a++;
                b++;
                i++;
            }
        }
    }
}
