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
            int i;
            if (data.Length != 2)
            {
                Console.Write("Вводимая строка должна содержать ровно 2 символа");
            }
            else
            {
                i = text.IndexOf(data);
                if (i != -1)
                {
                    
                    Console.Write("{0} ", i);
                    i = i + 1;
                    i = text.IndexOf(data, i);
                    Console.Write("{0} ", i);
                    i = i + 1;
                    i = text.IndexOf(data, i);
                    Console.Write(i);
                }// индекс оф?\ ласт индекс оф?
            }
            
        }
    }
}
