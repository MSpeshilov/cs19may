using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_10.Строки
{
    class Program
    {
        static void Main(string[] args)
        {
            String text = "abcdacadbacdaabaadc";
            String newValue = " ";
            String data = Console.ReadLine();
            String s;
            if(data.Length != 2)
            {
                Console.Write("Вводимая строка должна содержать ровно 2 символа");
            }
            else
            {
                s = text.Replace(data, newValue);
                Console.Write(s);
            }
        }
    }
}
