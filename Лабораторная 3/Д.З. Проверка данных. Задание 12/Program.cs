using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.Проверка_данных.Задание_12
{
    class Program
    {
        static void Main(string[] args)
        {
            double ainitial = double.Parse(Console.ReadLine());
            double aremainder = ainitial % 360;
            Console.WriteLine(aremainder);
        }
    }
}
