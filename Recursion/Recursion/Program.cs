using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            A(0);

            Console.ReadKey();
        }

        static void A(int a)
        {
            Console.WriteLine(a);

            if (a < 5)
            {
                A(++a); //Recurse
            }
        }
    }
}
