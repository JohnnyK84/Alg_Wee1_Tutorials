using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // example of swapping two variables

            var a = 10;
            var b = 20;
            Console.WriteLine($"var a = {a} var b = {b}");

            a = a ^ b;
            b = a ^ b;
            a = a ^ b;

            Console.WriteLine($"var a = {a} var b = {b}"); // variables swapped using xor operator

            Console.ReadLine();

        }
    }
}
