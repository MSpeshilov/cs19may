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
            int t = 0;
            int i = 0;
            while (i < data.Length)
            {
               
                if (data[i] == x)
                {
                    t = 1;
                    
                }
                Console.Write(t);
                i++;
            }
        }
    }
}
