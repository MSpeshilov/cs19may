using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Взаимоисключающие_случаи.Задание_14
{
    class Program
    {
        static void Main(string[] args)
        {
            String x = Console.ReadLine();
            if (x == "a")
            {
                Console.WriteLine("a+\nb\nc\nd\ne\nf\ng\nh");
            }else if (x == "b")
            {
                Console.WriteLine("a\nb+\nc\nd\ne\nf\ng\nh");
            }
            else if (x == "c")
            {
                Console.WriteLine("a\nb\nc+\nd\ne\nf\ng\nh");
            }
            else if (x == "d")
            {
                Console.WriteLine("a\nb\nc\nd+\ne\nf\ng\nh");
            }
            else if (x == "e")
            {
                Console.WriteLine("a\nb\nc\nd\ne+\nf\ng\nh");
            }
            else if (x == "f")
            {
                Console.WriteLine("a\nb\nc\nd\ne\nf+\ng\nh");
            }
            else if (x == "g")
            {
                Console.WriteLine("a\nb\nc\nd\ne\nf\ng+\nh");
            }
            else if (x == "h")
            {
                Console.WriteLine("a\nb\nc\nd\ne\nf\ng\nh+");
            }else
            {
                Console.WriteLine("a\nb\nc\nd\ne\nf\ng\nh");
            }
        }
    }
}
