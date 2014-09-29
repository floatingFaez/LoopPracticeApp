using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace loop
{
    class Program
    {
        static void Main(string[] args)
        {
            string msg = "Looping Serize 1 to 10";

            Console.WriteLine(msg);
            for (int counter = 0; counter < 10; counter++ )
            {
                int i = counter+1;
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
