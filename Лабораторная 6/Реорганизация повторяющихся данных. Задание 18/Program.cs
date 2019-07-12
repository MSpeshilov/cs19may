using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Реорганизация_повторяющихся_данных.Задание_18
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int a = 10;
            int b = 20;
            if (x < a || x > b)
            {
                while (a <= b)
                {
                    Console.WriteLine(a);
                    a = a + 1;
                }
            }
            else 
            {
                while (a <= b)
                {
                    
                    Console.Write(a);
                    if (a == x)
                    {
                        Console.Write("+");

                    }
                    Console.WriteLine();
                    a = a + 1;
                    
                }
            }
            
        }
    }
}
