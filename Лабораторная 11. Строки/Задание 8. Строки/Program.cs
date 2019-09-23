using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_8.Строки
{
    class Program
    {
        static void Main(string[] args)
        {
            String data = "abcdefwxyz";
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            String result;
            int i = a + b;
            if (a < 0)
            {
                Console.Write("Значение CA должно быть в интервале [0, длина строки)");
            }else if (b < 0)
            {
                Console.Write("Значение CB должно быть неотрицательно");
            }else if (i > 10)
            {
                Console.Write("Сумма значений CA и CB должна быть меньше длины строки");
            }
            else
            {
                
                result = data.Remove(a,b);
                Console.Write(result);
            }
        }
    }
}
