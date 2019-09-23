using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_7.Строки
{
    class Program
    {
        static void Main(string[] args)
        {
            String data = Console.ReadLine();
            String s1;
            String s2;
            String s3;
            String s4;
            int i1 = 0;
            int i2 = 3;
            int i3 = 9;
            int i4 = 12;
            int a = 3;
            int b = 6;
            int c = 1;
            if(data.Length != 13)
            {
                Console.Write("Некорректная длина штрих-кода");
            }
            else
            {
                s1 = data.Substring(i1, a);
                s2 = data.Substring(i2, b);
                s3 = data.Substring(i3, a);
                s4 = data.Substring(i4, c);
                Console.Write("Код страны: {0}\nКод изготовителя: {1}\nКод товара: {2}\nКонтрольное число: {3}",s1,s2,s3,s4);
            }
        }
    }
}
