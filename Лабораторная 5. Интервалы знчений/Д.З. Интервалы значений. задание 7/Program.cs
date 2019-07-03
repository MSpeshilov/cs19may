using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.Интервалы_значений.задание_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int reda = int.Parse(Console.ReadLine());
            int redb = int.Parse(Console.ReadLine());
            int greena = int.Parse(Console.ReadLine());
            int greenb = int.Parse(Console.ReadLine());
            int rab = redb - reda;
            int gab = greenb - greena;
            int sr = rab / 2;
            int sg = gab / 2;
            int red = reda + sr;
            int green = greena + sg;
            if ((reda > redb) || (greena > greenb))
            {
                Console.WriteLine("Некорректный интервал. Левая граница должна быть меньше правой.");
            }else if (red < green)
            {
                Console.WriteLine("Красный слева, зеленый справа");
            }else if (red == green)
            {
                Console.WriteLine("Середины интервалов совпадают");
            }else
            {
                Console.WriteLine("Зеленый слева, красный справа");
            }
        }
    }
}
