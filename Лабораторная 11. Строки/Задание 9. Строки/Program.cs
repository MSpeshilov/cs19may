using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_9.Строки
{
    class Program
    {
        static void Main(string[] args)
        {
            String data = Console.ReadLine();
            Char ch = data[0];
            //ToLower
            //ToUpper
            // Проверка на заглавную букву?
            //создать массив с алфавитом для проверки регистра буквы
            
            bool b = Char.IsUpper(ch);
            if (b == true)
            {
                Console.Write("Верхний регистр");
            }
            else
            {
                Console.Write("Нижний");
            }
        }
    }
}
