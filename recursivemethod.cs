using System;
using System.Collections.Generic;
using System.Text;

namespace methods
{
    class recursivemethod
    {
        public static double Factorial(int number)
        {
            if (number == 0)
                return 1;
            return number * Factorial(number - 1);//Recursive call  

        }
        static void Main(string []args)
        {
            Console.WriteLine("Enter number:");

            //Read number input by the user    
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            //Invoke  the static method  Factorial 
            double factorial = Factorial(number);

            //print the factorial result    
            Console.WriteLine("Factorial of" + number + "=" + factorial.ToString());
            Console.ReadLine();
        }
    }
}
