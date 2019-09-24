using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задание_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = int.Parse(Console.ReadLine());
            String filename = String.Format("test{0}.txt", i);
            bool f = File.Exists(filename);
            if (f == false)
            {
                Console.Write("Файл не существует");
                return;
            }
            
            //Создание инструмента для чтения файла filename
            StreamReader sr = new StreamReader(filename);
            //происходит открытие и занятие этого файла программой
            bool t = sr.EndOfStream;
            if (t == true)
            {
                Console.Write("Файл пуст");
                return;
            }
            //истина, если закончили читать
            while (t == false)
            {
                String line = sr.ReadLine();
                //чтение строки из файла
                Console.Write(line);
                t = sr.EndOfStream;
            }
            //закрытие файла и освобождение его для другх программ
            sr.Close();
        }
    }
}
