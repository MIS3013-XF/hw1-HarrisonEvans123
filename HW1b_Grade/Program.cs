// HW1b Grade

// Your Name: Harrison Evans
// Did you seek help ? If yes, specify the helper or web link here: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1b_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("What is your first name?");
            string firstname = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lastname = Console.ReadLine();
            Console.WriteLine("What is your student ID?");
            string studentID = Console.ReadLine();

            double num1;
            double num2;
            double num3;
            double num4;
            double num5;
           
            double sum;

            string Num1asString;
            string Num2asString;
            string Num3asString;
            string Num4asString;
            string Num5asString;
 

            Console.WriteLine("What is your overall percentage grade for homeworks?");
            Num1asString = Console.ReadLine();
            Console.WriteLine("What is your overall percentage grade for participations?");
            Num2asString = Console.ReadLine();
            Console.WriteLine("What is your overall percentage grade for quizzes?");
            Num3asString = Console.ReadLine();
            Console.WriteLine("What is your overall percentage grade for the midterm?");
            Num4asString = Console.ReadLine();
            Console.WriteLine("What is your overall percentage grade for the final?");
            Num5asString = Console.ReadLine();

            num1 = Convert.ToDouble(Num1asString);
            num2 = Convert.ToDouble(Num2asString);
            num3 = Convert.ToDouble(Num3asString);
            num4 = Convert.ToDouble(Num4asString);
            num5 = Convert.ToDouble(Num5asString);

            sum = (num1 + num2 + num3 + num4 + num5)/5; 

            string allvaluestogether = firstname + " " + lastname + " " + "("+studentID+")";
            Console.WriteLine($"{allvaluestogether}, your final grade is {sum}");





        }
    }
}
