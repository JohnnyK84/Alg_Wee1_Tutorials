using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var number1 = 1;
            var number2 = 2;

            Console.WriteLine("FirstNumber:");
            number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("SecondNumber");
            number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Your first number is: {0}", number1);
            Console.WriteLine("Your second number is: {0}", number2);

            var output = number1 * number2;
            Console.WriteLine($"{number1} x {number2} = {output}");

            Console.ReadLine();
        }
    }
}
