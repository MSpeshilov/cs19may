using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.Задание_2.Базовые_операции_с_массивами
{
    class Program
    {
        static void Main(string[] args)
        {
            String data = Console.ReadLine();
            String[] q;
            q = data.Split(';');
            int a = q.Length / 2;
            if (String.IsNullOrEmpty(data))
            {
                Console.Write("Исходная строка пуста");
                return;
            }
            int b = q.Length % 2;
            if (b == 0)
            {
                a = a - 1;
                Console.Write("Индекс :{0}, элемент :{1}", a, q[a]);
            }else
            {
                Console.Write("Индекс :{0}, элемент :{1}", a, q[a]);
            }
            
        }
    }
}
