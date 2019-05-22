using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_9
{
    class Program
    {
        static void Main(string[] args)
        {
            String firstName;//переменная "имя"
            firstName = Console.ReadLine();//получаемые данные
            String lastName;//переменная "фамилия"
            lastName = Console.ReadLine();
            Console.WriteLine("Меня зовут {0}, {1}, {0}", lastName,firstName);
        }
    }
}
