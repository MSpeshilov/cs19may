using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_11.Строки
{
    class Program
    {
        static void Main(string[] args)
        {
            String text = "abcdefwxyz";
            String s = Console.ReadLine();
            bool t = text.Contains(s);
            if (t == true)
            {
                Console.Write("Фрагмент {0} был найден в 'abcdefwxyz'", s);
            }
            else
            {
                Console.Write("Фрагмент {0} отсутствует в 'abcdefwxyz'", s);
            }
        }
    }
}
