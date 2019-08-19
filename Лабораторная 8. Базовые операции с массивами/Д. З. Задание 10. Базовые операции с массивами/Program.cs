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
            String[] first;
            first = left.Split(' ');
            String[] second;
            second = right.Split(' ');
            int t = 0;
            int i = 0;
            int a = 0;
            
            int b = 0;
            while (i < first.Length && i < second.Length)
            {
                if(first[a] != second[b])
                {
                    Console.Write("Массивы начинают различаться на индексе {0}",b);
                    
                    return;
                }
                a++;
                b++;
                i++;
            }//dif = 0, если найдено отличие и dif = 1, если массивы одинаковые.
            if (first.Length < second.Length)
            {
                t = second.Length - 1;
                Console.Write("Массивы начинают различаться на индексе {0}", t);
                
                
            }else if (second.Length < first.Length)
            {
                t = first.Length - 1;
                Console.Write("Массивы начинают различаться на индексе {0}", t);
            }
            
            
        }
    }
}
