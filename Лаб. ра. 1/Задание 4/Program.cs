using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4
{
    class Program
    {
        static void Main(string[] args)
        {
            String a; //переменная для исходных данных
            a = Console.ReadLine();//получить данные от пользователя и записать их в переменную а
            String result;//переменная для результата
            result = "Мы стремимся к " + a;
            Console.WriteLine(result);
        }
    }
}
