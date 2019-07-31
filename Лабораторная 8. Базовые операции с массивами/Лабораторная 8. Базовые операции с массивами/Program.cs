using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_8.Базовые_операции_с_массивами
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            String data = Console.ReadLine();
            String[] q;
            q = data.Split(' ');
            if (String.IsNullOrEmpty(data))
            {
                Console.Write("Исходная строка пуста");
                return;
            }
            if (a < 0|| a > q.Length)
            {
                Console.Write("Число A должно быть в интервале [0, размер массива)");
                return;
            }
           
            Console.Write(q[a]);
            
        }
    }
}
