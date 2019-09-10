using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Задание_6.Вычисление_агрегатов
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int i = 100;
            Console.Write("Ход решения: ");
            while (i < 1000)
            {
                if (i % 13 == 0)
                {
                    count++;
                    Console.Write("+");
                }
                Console.Write("{0} ",i);
                i++;
            }Console.Write("Ответ: {0}", count);
        }
    }
}
