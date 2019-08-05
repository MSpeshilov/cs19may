using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace авопившг
{
    class Program
    {
        static void Main(string[] args)
        {
            if (q.Length > 6)
            {
                //должно работать при: значениях от 1 до 5
                Console.Write("{0}\n{1}\n{2}\nЭлемент на индексе 5 отсутствует ", q[0], q[2], q[3]);

            }
            else if (q.Length <= 4)
            {
                Console.Write("{0}\n{1}\nЭлемент на индексе 3 отсутствует\nЭлемент на индексе 5 отсутствует ", q[0], q[2]);
            }
            else if (q.Length < 3)
            {
                Console.Write("{0}\nЭлемент на индексе 2 отсутствует\nЭлемент на индексе 3 отсутствует\nЭлемент на индексе 5 отсутствует ", q[0]);
            }
        }
    }
}
