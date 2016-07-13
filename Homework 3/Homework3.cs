//Homework3
//Write a program that takes seconds.
//Covert it into days, hours, minutes, and seconds.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Homework3
    {
        static void Main(string[] args)
        {
            //Declare int variable for user input 
            int seconds;

            //Inquire the number of seconds here 
            Console.Write("Please Enter the Number of Seconds Here: ");
            seconds = Convert.ToInt32(Console.ReadLine());

            //Creating a timespan and doing conversions 
            TimeSpan userTime = TimeSpan.FromSeconds(seconds);

            //result when int covert as hours, minutes, seconds 
            string result = string.Format("{0} Day(s) {1} Hour(s): {2} Minute(s): {3} Second(s)",
            userTime.Days, userTime.Hours, userTime.Minutes, userTime.Seconds);

            //displaying the result to the user 
            Console.Write(result);
            Console.ReadLine();

        }
    }
}
