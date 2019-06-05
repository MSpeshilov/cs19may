using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_3
{
    class Program
    {
        static void Main(string[] args)
        {
            String edge1 = Console.ReadLine();
            double edge = double.Parse(edge1);
            if (edge <= 0){//Если значение от пользователя меньше или равно 0, то
                Console.WriteLine("Значение edge должно быть положительным");
            return;//завершить работу программы
            

            }
            double q;
            q = edge * edge;
            double area;
            area = 6 * q;
            Console.WriteLine("area = {0:F4}", area);

        }
    }
}
