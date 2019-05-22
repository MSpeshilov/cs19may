using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {//переведите алгоритм с естественного языка на ваш язык программирования
            //Объявите переменные:
            String accountBalance; //для хранения баланса счета
            String paymentSite; //для хранения адреса сайта пополнения
            String messageText; //для хранения текста пополнения

            accountBalance = "0,37"; //Инициализируйте переменную accountBalance - запишите в нее строковый литерал "0,37".
            Console.WriteLine("Задача 7365"); //Выведите на экран строковый литерал "Задача 7365".
            messageText = "Пора пополнить счет!\n"; //Запишите в переменную messageText строковый литерал "Пора пополнить счет!\n".
            messageText = messageText + "Баланс Вашего счета составляет "; //Запишите в переменную messageText результат конкатенации значения переменной messageText и строкового литерала "Баланс Вашего счета составляет ".
            //Запишите в переменную messageText результат конкатенации значений переменных messageText и accountBalance.
//Запишите в переменную messageText результат конкатенации значения переменной messageText и строкового литерала " руб.".
//Выведите на экран значение переменной messageText.
            messageText = messageText + accountBalance;
            messageText = messageText + "руб";
            Console.Write(messageText);
        }
    }
}
