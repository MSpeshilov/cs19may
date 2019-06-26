using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.Интервалы_значений.Задание_10
{
    class Program
    {
        static void Main(string[] args)
        {
            double xt = double.Parse(Console.ReadLine());
            double yt = double.Parse(Console.ReadLine());
            double x1 = 100;
            double y1 = 100;
            double x2 = 170;
            double y2 = 190;
            
            
            if (xt < x1 || xt > x2 )
            {
                bool x = true;
            }if (yt < y1 || yt > y2)
            {
                bool y = true;
            }if (x && y == true)
            {
                Console.WriteLine("Точка снаружи");
            }

            else
            {
                Console.WriteLine("Точка внутри");
            }
           
        }
    }
}
