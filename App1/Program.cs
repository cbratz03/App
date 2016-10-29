using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Adds two numbers together

            int numOne;
            int numTwo;
            string expr;
            int sum;

            Console.WriteLine("Enter First Number:");
            numOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Add Second Number:");
            numTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter +, -, *, /");

            expr = Console.ReadLine();

            if (expr == "+")
                sum = (numOne + numTwo);
            else if (expr == "*")
                sum = (numOne * numTwo);


            Console.WriteLine(sum);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
}
