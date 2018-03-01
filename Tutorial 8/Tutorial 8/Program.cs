using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_8
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = 0;

            Console.WriteLine("Enter a number");
            input = int.Parse(Console.ReadLine());

            if (input >= 0)
            {
                Console.WriteLine("This is a positive number");
            }
            else
                Console.WriteLine("you etnered a negative number");
            Console.ReadLine();
        }
    }
}
