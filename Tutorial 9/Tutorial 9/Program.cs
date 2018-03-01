using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_9
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] newArray = new int[3];
            for (int i = 0; i < newArray.Length; i++)
            {
                var choices = i + 1;
                Console.WriteLine($"Enter number {choices} and press enter:  ");
                newArray[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(newArray); //sort array highest to lowest
            int lowestNumber = newArray[0];
            int middleNumber = newArray[1];
            int highestNumber = newArray[2];

                Console.WriteLine($"Highest number is {highestNumber}");
                Console.WriteLine($"Middle number is {middleNumber}");
                Console.WriteLine($"Lowest number is {lowestNumber}");
            
        }
    }
}
