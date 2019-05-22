using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_10
{
    class Program
    {
        static void Main(string[] args)
        {
            String firstName;
            firstName = Console.ReadLine();
            Console.Write("SELECT first_name, last_name, group FROM students WHERE student_id = '{0}';", firstName);
        }
    }
}
