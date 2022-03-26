/*
 * 
 * Grading ID: R7834
 * CIS 199-01
 * Exam 2
 * Due Date: 11/09/2020
 * This program creates a console application where a user can enter a county and a search will be performed to find and output entered country threat level.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace exam2_F20
{
    class Program
    {
        static void Main(string[] args)
        {
            // The parallel arrays to be searched

            string[] counties = { "Jefferson" , "Clark", "Floyd", "Harrison", "Bullitt",

                "Shelby", "Nelson", "Oldham", "Galatin", "Meade" };

            string[] threats = { "Red", "Orange", "Red", "Orange", "Red", "Orange", "Red", "Orange", "Yellow", "Orange" };

            string input;
            bool wasFound = false;

            WriteLine("Enter name of county: ");
            input = ReadLine();

            for(int index = 0; index < counties.Length; index++)
            {
                if (counties[index] == input)
                {
                    WriteLine($"The state assessed threat level in {counties[index]} is {threats[index]}.");
                    wasFound = true;
                    break;
                }

            }

            if(wasFound != true)
            {
                WriteLine($"Sorry, no data for {input} county.");
            }
        }
    }
}
