using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3.Строки
{
    class Program
    {
        static void Main(string[] args)
        {
            String text = "abcdefwxyz";
            String a = Console.ReadLine();
            String b = Console.ReadLine();
            int i1 = text.IndexOf(a);
            int i2 = text.IndexOf(b);
            
            int result;
            if (i1 == -1)
            {
                Console.Write("Фрагмент {0} отсутствует в строке",a);
            }else if(i2 == -1)
            {
                Console.Write("Фрагмент {0} отсутствует в строке", b);
            }
            else
            {
                result = i2 - i1;
                result = Math.Abs(result);
                result = result - 1;
                Console.Write(result);
            }
        }
    }
}
