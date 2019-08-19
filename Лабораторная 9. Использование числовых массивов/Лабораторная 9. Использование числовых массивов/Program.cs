using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_9.Использование_числовых_массивов
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            String data = Console.ReadLine();
            if (String.IsNullOrEmpty(data))
            {
                Console.Write(" ");
                return;
            }
            String[] arr = data.Split(' ');
            int[] num = new int[arr.Length];
            int a = 0;
            while (a < num.Length)
            {
                num[a] = int.Parse(arr[a]);
                num[a] = num[a] * m;
                Console.Write(num[a] + " ");
                a++;
            }
        }
    }
}
