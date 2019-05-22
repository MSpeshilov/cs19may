using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2.Вычисления
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = Console.ReadLine();
            double num = double.Parse(str);//преобразование текста из переменной str в число и запись в переменную num
            Console.WriteLine("{0:F4}", num);//выводим на экран число с точностью 4 знака после точки
        }
    }
}
