using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Задание_8.Вычисление_агрегатов
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int count = 0;
            int a = 0;
            int b;
            int q = x / 2 ;
            if (x <= 1)
            {
                Console.Write("Простое число должно быть больше 1");
            }
            else
            {
                while (a < q)
                {
                    a = a + 1;
                    b = x % a;
                    if (b == 0)
                    {
                        count++;

                    }
                }count = count + 1;
                if(count == 2)
                {
                    Console.Write("Число {0} без остатка делится на {1} других чисел. Число простое", x, count);
                }
                else
                {
                    Console.Write("Число {0} без остатка делится на {1} других чисел. Число составное",x,count);
                }
            }
        }
    }
}
