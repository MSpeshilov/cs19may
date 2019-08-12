using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.доп_Зад._8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] data;
            data = new String[] { "a", "b", "c", "d", "e", "f", "g", "h" };
            String x = Console.ReadLine();
            int a = 0;
            int b = 0;
            while (a < 8)
            {
                if (x == data[b])
                {

                    Console.Write(data[b]);
                    Console.Write("1");


                }
                else
                {
                    Console.Write(data[b]);
                    
                }
                

                b++;
                a++;
            }
        }
    }
}
