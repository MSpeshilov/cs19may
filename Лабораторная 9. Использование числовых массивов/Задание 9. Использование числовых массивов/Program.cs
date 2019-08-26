using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_9.Использование_числовых_массивов
{
    class Program
    {
        static void Main(string[] args)
        {
            String qqq = Console.ReadLine();
            String[] data = qqq.Split(';');
            if (String.IsNullOrEmpty(qqq))
            {
                Console.Write("Исходная строка пуста");
                return;
            }
            int[] num = new int[data.Length];
            int i = 0;
            int x = 0;
            int ww = 9;
            while (i < data.Length)
            {
                num[i] = int.Parse(data[i]);
                i++;
            }
            x = num[0];
            i = 0;
            while (i < num.Length)
            {
                if (x > num[i])
                {
                    Console.Write("Элемент со значением {0} на индексе {1} нарушает закономерность", num[i],i);
                    return;
                    //ww = 0;
                }
                

                    x++;
                i++;
            }
            Console.Write("Значения отсортированы по возрастанию");
        }
    }
}
