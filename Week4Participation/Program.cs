using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Participation
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("35 + 3 == 38 : {0}", (35 + 3 == 38));

            Console.WriteLine("35 * 3 > 120: {0}", (35 * 3 > 120));

            Console.WriteLine("35 - 30 < -5 + 10 : {0}", (35 - 30 < -5 + 10));

            Console.WriteLine("-5 < 0 : {0}", (-5 < 0));

            Console.WriteLine("35 / -5 + 8 <= 0: {0}", (35 / -5 + 8 <= 0));

            Console.WriteLine("35 % 2 != 0 : {0}", (35 % 2 != 0));

            int m = 11;
            Console.WriteLine("m > 10 : {0}", (m > 10));
            int z = 3;
            int a = 2, b = 2, c = 4;
            Console.WriteLine("28 % a : {0}", (28 % a == 0));
            Console.WriteLine("28 % b : {0}", (28 % b == 0));
            Console.WriteLine("28 % c : {0}", (28 % c == 0));
                      
        }
    }
}
