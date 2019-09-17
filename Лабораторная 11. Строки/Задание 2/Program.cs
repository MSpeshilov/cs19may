using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            String text = "abcdefwxyz";
            String s = Console.ReadLine();
            int a = 0;
            int i = text.IndexOf(s);
            if (i == -1)
            {
                Console.Write("Фрагмент {0} отсутствует в строке",s);
            }
            else
            {
                a = text.Length - i-s.Length;
                Console.Write("Фрагмент {0} находится на индексе {1}\nДлинна введенного фрагмента {2}\nПосле него есть еще {3} символов",s,i,s.Length ,a);
            }
        }
    }
}
