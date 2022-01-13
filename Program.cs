using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using задание_10;

namespace задание_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Ugol ugol = new Ugol();
         


            Console.WriteLine(ugol.gradus);
            Console.WriteLine(ugol.min);
            Console.WriteLine(ugol.sec);
            Console.WriteLine(ugol.ToRadians()) ;

            ugol.gradus = 15;
            ugol.sec = 25;
            ugol.min = 10;
            Console.WriteLine(ugol.ToRadians());

            Console.ReadKey();

        }
    }
}

