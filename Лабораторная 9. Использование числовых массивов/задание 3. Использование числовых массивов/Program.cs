using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_3.Использование_числовых_массивов
{
    class Program
    {
        static void Main(string[] args)
        {
            String data_left = Console.ReadLine();
            String[] left = data_left.Split(' ');
            String data_right = Console.ReadLine();
            String[] right = data_right.Split(' ');
            int i = 0;
            int[] a = new int[left.Length];
            int[] b = new int[right.Length];
            if (left.Length < right.Length || left.Length > right.Length)
            {
                Console.Write("Размеры массивов должны быть одинаковы");
            }
            else
            {
                while (i < left.Length)
                {
                    a[i] = int.Parse(left[i]);
                    b[i] = int.Parse(right[i]);
                    a[i] = a[i] * b[i];
                    Console.Write(a[i] + " ");
                    i++;
                }
            }
            
        }
    }
}
