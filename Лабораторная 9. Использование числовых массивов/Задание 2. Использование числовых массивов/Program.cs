using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2.Использование_числовых_массивов
{
    class Program
    {
        static void Main(string[] args)
        {
            String data = Console.ReadLine();
            if (String.IsNullOrEmpty(data))
            {
                Console.Write("Нет данных");
                return;
            }
            String[] q = data.Split(';');
            int[] num = new int[q.Length];
            int a = 0;
            int b = 0;
            while (a < num.Length)
            {
                num[a] = int.Parse(q[a]);
                
                while (b < num[a])
                {
                    Console.Write("#");
                    b++;
                }
                
                if (num[a] < 0)
                {
                    Console.Write("Элемент массива на индексе {0} меньше нуля", a);
                }
                Console.WriteLine();
                b = 0;
                a++;
            }
        }
    }
}
