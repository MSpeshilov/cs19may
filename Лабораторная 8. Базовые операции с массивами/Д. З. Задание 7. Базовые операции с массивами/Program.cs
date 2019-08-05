using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.Задание_7.Базовые_операции_с_массивами
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            String data = Console.ReadLine();
            String[] q;
            q = data.Split(' ');
            if (b >= q.Length || b < 0)
            {
                Console.Write("Число B должно быть в интервале [0, размер массива)");
                return;
            }else if (e > q.Length || e < 0)
            {
                Console.Write("Число E должно быть в интервале [0, размер массива)");
                return;
            } 
            else if (b > e)
            {
                while (b > e)
                {
                    Console.Write(q[e] + " ");
                    e++;
                }
            }
            while (b <= e)
            {
                Console.Write(q[b] + " ");
                b++;
            }
        }
    }
}
