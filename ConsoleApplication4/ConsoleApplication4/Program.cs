using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace variable
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 15;
            int num2 = 25;
            int sum = num1 + num2;

            double d1 = 3.5;
            double d2 = .5;
            double sumD = d1 + d2;

            float f1 = 3.5f;
             
            string myname = "Jack";

            string message = "My name is " + myname;

            string capsMessage = message.ToUpper();

            Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + sum);
            Console.WriteLine("The sum of " + d1 + " and " + d2 + " is " + sumD);
            Console.WriteLine(capsMessage);

            Console.Read();
        }
    }
}
