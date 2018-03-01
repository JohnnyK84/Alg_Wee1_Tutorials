using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var pi = Math.PI;
            var radius = 7.5;

            Console.WriteLine("Enter Radius of Circle: ");
            radius = double.Parse(Console.ReadLine());

            var power = 2;
            var rsq = Math.Pow(radius, power);

            Console.WriteLine($"The Perimeter o fthe circle is: {2*pi*radius}");
            Console.WriteLine($"The Area of the circle is: {pi*rsq}");
            Console.ReadLine();

        }
    }
}
