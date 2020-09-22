using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0908
{
    class Class3
    {
        static void Main()
        {
            bool b1 = true;
            Console.WriteLine(b1);

            bool b2 = false;
            Console.WriteLine(b2);

            b1 = !b1;//! 부정 Not
            Console.WriteLine(b1);

            char c = 'o';
            Console.WriteLine(char.IsLetter(c));
             
        }
    }
}
