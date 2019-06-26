using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.интервалы_значений.Задание_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int reda = int.Parse(Console.ReadLine());
            int redb = int.Parse(Console.ReadLine());
            int greena = int.Parse(Console.ReadLine());
            int greenb = int.Parse(Console.ReadLine());
            if (reda > greena && redb > greenb || reda < greena && redb < greenb) 
            {
                Console.WriteLine("Не пересекаются");
            }else if (greenb < greena || reda > redb)
            {
                Console.WriteLine("Некорректный интервал. Левая граница должна быть меньше правой.");
            }
            else
            {
                Console.WriteLine("Пересекаются");
            }
           

            
        }
    }
}
