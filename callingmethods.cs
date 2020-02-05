
using System;

namespace methods
{
    class callingmethods
    {
        public int FindMaxNum(int num1,int num2)
        {
            //declare local variable
            int result;
            if (num1 > num2)
            {
                result = num1;
            }
            else
            {
                result = num2;
            }
            return result;
        }

        static void Main(string[] args)
        {
            callingmethods cc = new callingmethods();
            int x, y, res;
            x = 200;
            y = 500;
            res = cc.FindMaxNum(x, y);
            Console.WriteLine("Max number is:{0}",res);
            Console.ReadLine();
        }
    }
}
