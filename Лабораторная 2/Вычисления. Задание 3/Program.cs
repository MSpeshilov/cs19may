using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Вычисления.Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = Console.ReadLine();
            double num = double.Parse(str);//Преобразование текста из переменной А в число и запись в переменную В
            double result;//Объявляем переменную для результата
            result = num + 7;//Вычисляем результат и записываем в соотв. переменную
            Console.WriteLine("{0:F4}", result);//Выводим на экран число с точностью 4 знака после запятой
        }
    }
}
