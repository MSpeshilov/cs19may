using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.Проверка_данных.Задание_13
{
    class Program
    {
        static void Main(string[] args)
        {
            double leigthseconds = double.Parse(Console.ReadLine());
            if (leigthseconds < 0)
            {
                Console.WriteLine("Количество времени должно быть неотрицательным");
                return;
            }
            double h = 60 * 60;
            
            double hour = Math.Floor(leigthseconds / h);
            double min = Math.Floor(leigthseconds % h);
            double m = Math.Floor(min / 60);
            double sec = Math.Floor(min % 60);
            Console.WriteLine("{0} часов {1} минут {2} секунд", hour, m, sec);
        }
    }
}
