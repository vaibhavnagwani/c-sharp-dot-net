using System;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(getMax(1, 4, 3));

            Console.WriteLine("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Select the number for the operation that you want to perform: \n1. Add\n2. Subtract\n3. Multiply\n4. Divide");
            int caseParam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nAnswer = " + calculator(num1, num2, caseParam));
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

        static string calculator(double num1, double num2, int caseParam)
        {

            switch (caseParam)
            {
                case 1:
                    return num1 + num2 + "";

                case 2:
                    return num1 - num2 + "";

                case 3:
                    return num1 * num2 + "";

                case 4:
                    if (num2 == 0) Console.WriteLine("Cannot divide by 0!");
                    return (num1 / num2) + "";

                default:
                    return "Please enter the desired operation you want, correctly!";
            }
        }
    }
}
