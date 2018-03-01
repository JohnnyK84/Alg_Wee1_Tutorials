using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 1000);
            int[] newArray = new int[5];

            for (int i = 0; i <= 4; i++ )
            {
                number = rnd.Next(1, 1000);
                newArray[i] = number;
                Console.WriteLine($"Random Number {newArray[i]}");
            }

            Console.ReadLine();

        }
    }
}
