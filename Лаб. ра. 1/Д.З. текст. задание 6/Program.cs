using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.текст.задание_6
{
    class Program
    {
        static void Main(string[] args)
        {   //переменные 
            String companyName;//для хранения названия компании.
            String productName;//для хранения наименования товара.
            String productCost;//для хранения цены на товар.
            String messagePart;//для хранения фрагментов сообщения.
           
            Console.WriteLine("Задача 1910");//Выведите на экран строковый литерал "Задача 1910".
            Console.WriteLine("Введите название компании");//Выведите на экран строковый литерал "Введите название компании".

            companyName = Console.ReadLine();//Инициализируйте companyName - запишите в нее строку, полученную от пользователя.

            Console.WriteLine("Введите наименование товара");//Выведите на экран строковый литерал "Введите наименование товара".

            productName = Console.ReadLine();//Инициализируйте productName - запишите в нее строку, полученную от пользователя.

            Console.WriteLine("Введите цену товара");//Выведите на экран строковый литерал "Введите цену товара".

            productCost = Console.ReadLine();//Инициализируйте productCost - запишите в нее строку, полученную от пользователя.

            Console.WriteLine("Распродажа в {0} !",companyName);
            Console.WriteLine("Наши {0} по супер цене. Всего {1} !", productName, productCost);
            Console.WriteLine("Торопитесь, предложение ограничено!");



        }
    }
}
