﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З.взаимоисключающие_случаи.Задание_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double roadKm = double.Parse(Console.ReadLine());
            double lenghtFeet = double.Parse(Console.ReadLine());
            double roadM = roadKm * 1000;
            double lenghtM = lenghtFeet * 0.305;
            if (roadM <= 0)
            {
                Console.WriteLine("Расстояние между деревнями должно быть неотрицательно");
                return;
            }if (lenghtM <= 0)
            {
                Console.WriteLine("Длина кабеля должна быть неотрицательна");
                return;
            }if (roadM <= lenghtM)
            {
                Console.WriteLine("Кабеля хватит. Расстояние меньше длины кабеля.");
            }else
            {
                Console.WriteLine("Кабеля не хватит. Длина кабеля меньше расстояния.");
            }
        }
    }
}
