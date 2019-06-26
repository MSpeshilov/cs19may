using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drherh
{
    class Program
    {
        static void Main(string[] args)
        {
            int reda = int.Parse(Console.ReadLine());
            int redb = int.Parse(Console.ReadLine());
            int greena = int.Parse(Console.ReadLine());
            int greenb = int.Parse(Console.ReadLine());
            if (reda < greena && redb < greenb)
            {
                Console.WriteLine("Не пересекаются");
            }else if (reda > greena && redb > greenb)
            {
                Console.WriteLine("Не пересекаются");
            }
            else 
            {
                Console.WriteLine("Пересекаются");
                
            }
            if (greenb < greena || reda > redb)
            {
                Console.WriteLine("Некорректный интервал. Левая граница должна быть меньше правой.");
                return;
            }
        }
    }
}
