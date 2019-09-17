using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5
{
    class Program
    {
        static void Main(string[] args)
        {
            String text = "abcdefwxyz";
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a < 0 ||a > 9)
            {
                Console.Write("Значение CA должно быть в интервале [0,длина строки)");

            }else if (b < 0 || b > 9)
            {
                Console.Write("Значение CB должно быть в интервале [0,длина строки)");
            }
            else
            {
                String s;
                int c = a - b;
                
                if (a < b)
                {
                    c = Math.Abs(c);
                    c = c + 1;
                    s = text.Substring(a, c);
                }
                else
                {
                    c = c + 1;
                    s = text.Substring(b, c);
                }

                Console.Write(s);
            }
            
        }
    }
}
