using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.Задание_9
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] data;
            data = new String[] { "a", "b", "c", "d", "e", "f", "g", "h"};
            String x = Console.ReadLine();
            int a = 0;
            int b = 0;
            while (a < 8)
            {
                Console.Write(data[b]);
                if (x == data[b])
                {
                    
                    //Console.Write(data[b]);
                    break;

                }else
                {
                    //Console.Write(data[b]);
                }
                // доделать: если при введенной букве, отсутствующей в массиве выводить "-"
                
                b++;
                a++;
            }
            Console.Write("\nend");

            /*if (x == data[b])
            {
                Console.Write("+");
                return;
            }
            if (x == data[b])
            {
                Console.Write("+");
                return;
            }
            if (x == data[b])
            {
                Console.Write("+");
                return;
            }
             if (x == data[b])
            {
                Console.Write("+");
                return;
            }
            if (x == data[b])
            {
                Console.Write("+");
                return;
            }
             if (x == data[b])
            {
                Console.Write("+");
                return;
            }
            if (x == data[b])
            {
                Console.Write("+");
                return;
            }
             if (x == data[b])
            {
                Console.Write("+");
                return;
            }
            Console.Write("-");*/
            
        }
    }
}
