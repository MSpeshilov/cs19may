using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4.Строки
{
    class Program
    {
        static void Main(string[] args)
        {
            String text = "abcabcabbacbacbaaac";
            String data = Console.ReadLine();
            int i = text.LastIndexOf(data);
            Console.Write(i);
            // проверка на кол-во введенных букв?
        }
    }
}
