using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Username_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring variables required for program
            string username, country;
            int flag = 0;

            //collecting data for variables from user
            Console.WriteLine("Enter your good name");
            username = Console.ReadLine();

            Console.WriteLine("\nWhere are you from?");
            country = Console.ReadLine();

            //validating the collected data
            if (Regex.IsMatch(username, @"^[a-zA-Z]+$") && Regex.IsMatch(country, @"^[a-zA-z]+$"))
                flag = 0;
            else
                flag = 1;

            //generating output based on results of validation
            if (flag == 0)
                Console.WriteLine("\nWelcome " + username + " from country " + country);
            else
                Console.WriteLine("\nPlease enter valid details.. your name and country inputs must contain only characters");

            //finishing the program with taking a character from user
            Console.ReadLine();
        }
    }
}
