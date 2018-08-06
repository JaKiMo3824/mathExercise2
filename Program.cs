using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1:");
            Console.WriteLine("What is your current hourly rate?");
            string p1Hourly = Console.ReadLine();
            double p1Hou = Convert.ToDouble(p1Hourly);
            Console.WriteLine("How many hours do you work per week?");
            string p1Weekly = Console.ReadLine();
            double p1Wee = Convert.ToDouble(p1Weekly);

            Console.WriteLine("Person 2:");
            Console.WriteLine("What is your current hourly rate?");
            string p2Hourly = Console.ReadLine();
            double p2Hou = Convert.ToDouble(p2Hourly);
            Console.WriteLine("How many hours do you work per week?");
            string p2Weekly = Console.ReadLine();
            double p2Wee = Convert.ToDouble(p2Weekly);

            double p1Salary = p1Hou * (p1Wee * 52.0);
            Console.WriteLine("Annual salary of Person 1: ");
            Console.WriteLine(p1Salary);

            double p2Salary = p2Hou * (p2Wee * 52.0);
            Console.WriteLine("Annual salary of Person 2: ");
            Console.WriteLine(p2Salary);

            bool p1Greater = p1Salary > p2Salary;
            Console.WriteLine("Does Person 1 make more money than Person 2? ");
            Console.WriteLine(p1Greater);
            Console.ReadLine();






            

        }
    }
}
