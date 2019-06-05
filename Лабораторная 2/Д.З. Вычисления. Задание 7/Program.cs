using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.Вычисления.Задание_7
{
    class Program
    {
        static void Main(string[] args)
        {
            String temp;
            /*String height;
            String wight;
            String area;*/

            Console.WriteLine("Задача 1976");
            Console.WriteLine("Введите высоту прямоугольника");
            temp = Console.ReadLine();
            double height;
            height = double.Parse(temp);
            Console.WriteLine("Введите ширину прямоугольника");
            temp = Console.ReadLine();
            double wight;
            wight = double.Parse(temp);
            double area;
            area = height * wight;
            Console.WriteLine("Площадь прямоугольника со сторонами height и wight равна {0}", area);


        }
    }
}
