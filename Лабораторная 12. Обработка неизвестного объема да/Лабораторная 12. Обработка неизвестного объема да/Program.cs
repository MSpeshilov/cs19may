using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_12.Обработка_неизвестного_объема_да
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = 0;
            int a;
            bool b = false;
            int i = 0;
            while (b == false)
            {
                a = int.Parse(Console.ReadLine());
                res = res + a;
                i = i + 1;
                if (a == 0)
                {
                    b = true;
                    
                }
            }
            
            Console.Write("Сумма чисел: {0}, Колличество чисел: {1}",res,i);

            /*a = int.Parse(Console.ReadLine());
            res = res + a;
            a = int.Parse(Console.ReadLine());
            res = res + a;
            a = int.Parse(Console.ReadLine());
            res = res + a;
            a = int.Parse(Console.ReadLine());
            res = res + a;
            a = int.Parse(Console.ReadLine());
            res = res + a;
            a = int.Parse(Console.ReadLine());
            res = res + a;
            if (a == 0)
            {
                return;
            }*/
        }
    }
}
