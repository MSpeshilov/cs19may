using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_12.Базовые_операции_с_масиивами
{
    class Program
    {
        static void Main(string[] args)
        {
            String data = Console.ReadLine();
            String[] q;
            q = data.Split(' ');
            int x = 1;
            int i = 5;
            int o = 4;
            String a = q[i];
            while (x < q.Length)
            {
                
                q[i] = q[o];
                i--;
                o--;
                x++;
                
            }
            /*q[i] = q[o];
            o = o - 1;
            i = i - 1;
            q[i] = q[o];
            o = o - 1;
            i = i - 1;
            q[i] = q[o];
            o = o - 1;
            i = i - 1;
            q[i] = q[o];
            o = o - 1;
            i = i - 1;
            q[i] = q[o];
            o = o - 1;
            i = i - 1;
            q[i] = a;*/

            //String a = q[5];
            /*q[5] = q[4];
            q[4] = q[3];
            q[3] = q[2];
            q[2] = q[1];
            q[1] = q[0];
            q[0] = a;*/

            /* = q[0];
            String b = q[1];
            String c = q[2];
            String d = q[3];
            String e = q[4];
            String f = q[5];
            q[0] = f;
            q[1] = a;
            q[2] = b;
            q[3] = c;
            q[4] = d;
            q[5] = e;*/
            q[0] = a;
            x = 0;
            while (x < q.Length)
            {
                Console.Write(q[x] + " ");
                x++;
            }
        }
    }
}
