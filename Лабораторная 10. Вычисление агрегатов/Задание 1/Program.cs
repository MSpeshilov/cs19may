using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int i = 100;
            Console.Write("Ход решения: ");
            while (i < 501)
            {
                sum = sum + i;
                Console.Write("{0} ",sum);
                i++;
            }
            Console.Write("Ответ: {0}", sum);
        }
    }
}
