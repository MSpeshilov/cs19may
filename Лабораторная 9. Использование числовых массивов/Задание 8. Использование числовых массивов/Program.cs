using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_8.Использование_числовых_массивов
{
    class Program
    {
        static void Main(string[] args)
        {
            String chars = Console.ReadLine();
            String amounts = Console.ReadLine();
            if (String.IsNullOrEmpty(chars))
            {
                Console.Write("Отсутствуют данные о символах");
                return;
            }else if (String.IsNullOrEmpty(amounts))
            {
                Console.Write("Отсутствуют данные о количествах");
                return;
            }
            String[] p = amounts.Split(' ');
            String[] q = chars.Split(' ');
            int[] num = new int[p.Length];
            int a = 0;
            int b = 0;
            int c = 0;
            if (p.Length != q.Length)
            {
                Console.Write("Длины массивов не совпадают");
                return;
            }
            else
            {
                
                while (a < q.Length)
                {
                    num[a] = int.Parse(p[a]);
                    
                    while (b < num[a])
                    {
                        Console.Write(q[a]);
                        
                        b++;
                        
                    }
                    Console.WriteLine();
                    b = 0;
                    a++;
                }
            }
        }
    }
}
