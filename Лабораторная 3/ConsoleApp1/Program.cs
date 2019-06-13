using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double edge = double.Parse(Console.ReadLine());
            if (edge <= 0)
            {
                Console.WriteLine("Значение edge должно быть положительным");
                return;
            }
            double volume = edge * edge * edge;
            Console.WriteLine(volume);
        }
    }
}
