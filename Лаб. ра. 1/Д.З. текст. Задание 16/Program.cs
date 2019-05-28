using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.текст.Задание_16
{
    class Program
    {
        static void Main(string[] args)
        {
            String a;
            String b;
            String c;
            String d;
            String e;
            String f;
            String g;
            String h;

            a = "Которая в тёмном чулане хранится,\n";
            b = "В доме,\n Который построил Джек.\n";
            c = "Которая часто ворует пшеницу,\n";
            d = "Который пугает и ловит синицу,\n";
            e = "Который за шиворот треплет кота,\n";
            f = "Лягнувшую старого пса без хвоста,\n";
            g = "Которая доит корову безрогую,\n";
            h = "Который бранится с коровницей строгою,\n";

            Console.WriteLine(" Самуил Маршак. Дом, который построил Джек.\n");
            Console.WriteLine(" Вот дом,\n Который построил Джек.\n");
            Console.WriteLine(" А это пшеница,\n {0} {1}", a, b);
            Console.WriteLine(" А это весёлая птица-синица,\n {2} {0} {1}", a, b, c);
            Console.WriteLine(" Вот кот,\n {3} {2} {0} {1}", a, b ,c, d);
            Console.WriteLine(" Вот пёс без хвоста,\n {4} {3} {2} {0} {1}", a, b, c, d, e);
            Console.WriteLine(" А это корова безрогая,\n Лягнувшая старого пса без хвоста,\n {4} {3} {2} {0} {1}", a, b, c, d, e);
            Console.WriteLine(" А это старушка, седая и строгая,\n {6} {5} {4} {3} {2} {0} {1}", a, b, c, d, e, f, g);
            Console.WriteLine(" А это ленивый и толстый пастух,\n {7} {6} {5} {4} {3} {2} {0} {1}", a, b, c, d, e, f, g, h);
            Console.WriteLine(" Вот два петуха,\n Которые будят того пастуха,\n {7} {6} {5} {4} {3} {2} {0} {1}", a, b, c, d, e, f, g, h);


        }
    }
}
