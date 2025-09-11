// HW1a Sales Total

// Your Name: Harrison Evans
// Did you seek help ? If yes, specify the helper or web link here: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1a_Sales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;

            double sum;

            const double multiplier = 8.5/100;

            string Num1AsString;
            string Num2AsString;


            Console.WriteLine("What is the product name of the item you are purchasing?");
            Console.ReadLine();
            Console.WriteLine("How many slices of Pizza would you like?");
            Num1AsString = Console.ReadLine();
            Console.WriteLine("What is the price for each slice?");
            Num2AsString = Console.ReadLine();

            num1 = Convert.ToDouble(Num1AsString);
            num2 = Convert.ToDouble(Num2AsString);


            {
                
                sum = num1 * num2;
                Console.WriteLine("Your subtotal for your pizza is " + sum.ToString("C"));
                sum = sum * multiplier;
                Console.WriteLine($"Your sales tax for you bill is {sum.ToString("C")}");
                sum = num1 * num2 + sum;
                Console.WriteLine($"Your total for you bill is " + sum.ToString("C")); 

            }



        }
    }
}
