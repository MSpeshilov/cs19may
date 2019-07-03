using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Предисловие");
            Console.WriteLine("Глава 1");
            Console.WriteLine("Глава 2");
            Console.WriteLine("Глава 3");
            Console.WriteLine("Глава 4");
            Console.WriteLine("Глава 5");
            Console.WriteLine("Глава 6");
            Console.WriteLine("Глава 7");
            Console.WriteLine("Послесловие");*/


            /*Console.WriteLine("Предисловие");
            int i;
            int i = 1;
            Console.WriteLine("Глава " + i);
            i = i + 1;
            Console.WriteLine("Глава " + i);
            i = i + 1;
            Console.WriteLine("Глава " + i);
            i = i + 1;
            Console.WriteLine("Глава " + i);
            i = i + 1;
            Console.WriteLine("Глава " + i);
            i = i + 1;
            Console.WriteLine("Глава " + i);
            i = i + 1;
            Console.WriteLine("Глава " + i);
            i = i + 1;
            Console.WriteLine("Глава " + i);
            Console.WriteLine("Послесловие");*/



            Console.WriteLine("Предисловие");
            int i;
            i = 1;
            while (i <= 7)//счетчик оператор ограничение
            {
                Console.WriteLine("Глава " + i);
                i = i + 1;
            } Console.WriteLine("Послесловие");
        }
    }
}
