using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проверка_данных.Задание_11
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalM = double.Parse(Console.ReadLine());
            double partCm = double.Parse(Console.ReadLine());
            double totalCm = totalM * 100;
            if (totalM <=0)
            {
                Console.WriteLine("Длина рулона должна быть положительна");
                return;
            }
            if (partCm <= 0)
            {
                Console.WriteLine("Расход материала должен быть положительным");
                return;
            }
            if (totalCm < partCm)
            {
                Console.WriteLine("Материала не хватит даже на одно изделие");
                return;
            }
            
            double amount = Math.Floor(totalCm / partCm);
            double remainder = totalCm % partCm;
            Console.WriteLine(amount);
            Console.WriteLine(remainder);
        }
    }
}
