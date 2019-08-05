using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.Задание_3.Базовые_операции_с_массивами
{
    class Program
    {
        static void Main(string[] args)
        {
            String data = Console.ReadLine();
            String[] q;
            q = data.Split(',');
           
            if (String.IsNullOrEmpty(data))
            {
                Console.Write("Исходная строка пуста");
                return;
            }
            if (q.Length < 6)
            {
                Console.Write("{0}\n{1}\n{2}\nЭлемент на индексе 5 отсутствует ", q[0], q[2], q[3]);
                
            }else if (q.Length <= 4)
            {
                Console.Write("{0}\n{1}\nЭлемент на индексе 3 отсутствует\nЭлемент на индексе 5 отсутствует ", q[0], q[2]);
            }else if (q.Length < 3)
            {
                Console.Write("{0}\nЭлемент на индексе 2 отсутствует\nЭлемент на индексе 3 отсутствует\nЭлемент на индексе 5 отсутствует ", q[0]);
            }
            else
            {
                Console.Write("{0}\n{1}\n{2}\n{3} ", q[0], q[2], q[3], q[5]);
            }
            
        }
    }
}
