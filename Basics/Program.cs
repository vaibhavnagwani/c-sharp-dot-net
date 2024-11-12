using System;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(getMax(1, 4, 3));
           
        }

        static int getMax(int num1, int num2, int num3)
        {
            int res;
            if(num1>num2 && num1 > num3)
            {
                res = num1;
            }
            else if (num2 > num3)
            {
                res = num2;
            } else
            {
                res = num3;
            }
            return res;
        }
    }
}
