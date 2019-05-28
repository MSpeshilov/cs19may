using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.текст.Задание_12
{
    class Program
    {
        static void Main(string[] args)
        {
            String cx;
            String cy;
            String r;
            String fill;

            cx = Console.ReadLine();
            cy = Console.ReadLine();
            r = Console.ReadLine();
            fill = Console.ReadLine();

            Console.WriteLine("<circle cx=\"{0}\" cy=\"{1}\" r=\"{2}\" fill=\"{3}\"/>", cx, cy, r, fill);
        }
    }
}
