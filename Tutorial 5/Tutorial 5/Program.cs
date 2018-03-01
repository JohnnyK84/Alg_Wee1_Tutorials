using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = 15;
            Console.WriteLine("Enter a number: ");
            input = int.Parse(Console.ReadLine());

            for (int i = 1; i<= 10; i++)
            {
                Console.WriteLine($"your number {input} = {i * input}");    

            }
            Console.ReadLine();
        }
    }
}
