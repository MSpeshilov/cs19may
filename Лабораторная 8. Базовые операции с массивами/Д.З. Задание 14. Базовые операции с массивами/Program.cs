using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.Задание_14.Базовые_операции_с_массивами
{
    class Program
    {
        static void Main(string[] args)
        {
            String data = Console.ReadLine();
            String[] q;
            q = data.Split(' ');
            int i = q.Length - 1;
            while (i + 1 > 0)
            {
                Console.Write(q[i] + " ");
                i--;
            }
        }
    }
}
