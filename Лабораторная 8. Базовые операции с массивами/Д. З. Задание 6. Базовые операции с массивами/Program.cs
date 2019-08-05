using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.Задание_6.Базовые_операции_с_массивами
{
    class Program
    {
        static void Main(string[] args)
        {
            String data = Console.ReadLine();
            String[] q;
            
            int a ;
            q = data.Split(',');
            int b = q.Length;
            a = q.Length - 1;
            while (b >= 1)
            {
                Console.Write(a);
                Console.Write(q[a] + " ");

                a--;
                b--;
            }
            

        }
    }
}
