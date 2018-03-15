using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack _stack = new Stack();
 
            createStack(_stack);

        }
        static void createStack(Stack _stack)
        {
            Console.WriteLine($"Enter snippet of code to be checked:  ");
            var input = Console.ReadLine();            

            //adding EACH item of string input individaully into StackArray
            foreach (var i in input)
            {
             _stack.Push(i);
            }

            string check_a = "(";
            string check_b = ")";
            int count_a = 0;
            int count_b = 0;

            //checking each char in the stack to match check_a or check_b values
            foreach (char i in _stack)
            {
                if (check_a.Contains(i))
                {
                    {
                        count_a++;
                    }
                }
                else if (check_b.Contains(i))
                    {
                    count_b++;
                    }
            }

            checkParentheses(count_a,count_b,check_a,check_b);

            //Console.WriteLine($"{_stack.Pop()}");
        }
        public static void checkParentheses(int count_a, int count_b, string check_a, string check_b)
        {

            //using if else statement to check difference betwen two variables and calculate balance of missing parentheses
            if (count_a < count_b)
            {
                int missing_lp = count_b - count_a;
                Console.WriteLine("\nyou need {0} {1} to balance the parentheses in your code", missing_lp, check_a);
            }
            else if (count_a > count_b)
            {
                int missing_rp = 0;
                missing_rp = count_a - count_b;
                Console.WriteLine("\nYou need {0} {1} to balance the parentheses in your code", missing_rp, check_b);
            }
            else
            {
                Console.WriteLine("\nCongratulations you have equal amount of parentheses in your code !!!!");
            }
            Console.WriteLine();
            Console.WriteLine("you had {0} x {1} parentheses", count_a, check_a);
            Console.WriteLine();
            Console.WriteLine("you had {0} x {1} parentheses", count_b, check_b);
            Console.WriteLine();
            Console.WriteLine("Tap ANYKEY to exit");
            Console.ReadKey();
        }
    }
}
