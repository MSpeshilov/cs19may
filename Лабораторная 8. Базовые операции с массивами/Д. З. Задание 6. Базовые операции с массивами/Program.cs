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
            int b = 0;
            int a ;
            q = data.Split(',');
            a = q.Length - 1;
            while (q.Length >= b)
            {
                Console.Write(q[a] + " ");
                a--;
                
            }
            //Console.Write(q[5], q[4], q[3], q[2], q[1], q[0]);
        }
    }
}
