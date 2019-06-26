using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int reda = int.Parse(Console.ReadLine());
            int redb = int.Parse(Console.ReadLine());
            int greena = int.Parse(Console.ReadLine());
            int greenb = int.Parse(Console.ReadLine());
            if (redb < greena || greenb < reda)
            {
                Console.WriteLine("Не пересекаются");
            }
            else if (greenb < greena || reda > redb)
            {
                Console.WriteLine("Некорректный интервал. Левая граница должна быть меньше правой.");
            }
            else
            {
                Console.Write("Пересекаются");
            } if (greena > reda && greenb > redb)
            {
                Console.Write("({0};{1})", redb, greena);
            }
        }
    }
}
