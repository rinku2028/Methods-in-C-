using System;
using System.Collections.Generic;
using System.Text;

namespace methods
{
    class factorialmethod
    {
        public static double Factorial(int number)
        {
            if (number == 0)
                return 1;

            double factorial = 1;
            for (int i = number; i >= 1; i--)
            {
                factorial = factorial * i;
            }
            return factorial;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");

            //Read number input by user  
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            //Invoke the static method    
            double factorial = Factorial(number);

            //print the factorial result    
            Console.WriteLine("Factorial of " + number + "=" + factorial.ToString());
            Console.ReadLine();
        }
    }
}
