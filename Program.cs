using System;
using System.Globalization;
using System.Xml.Serialization;
using static System.Console;
namespace SocialSecurityNumber0
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("what is you first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("And last name?");
            string lastName = Console.ReadLine();
            
            
            
            
            
            Console.WriteLine("Social Security Number (YYMMDD-XXXX): ");

            string socialSecurityNumber = Console.ReadLine();
            string gender;

            int genderNumber = int.Parse(socialSecurityNumber.Substring(socialSecurityNumber.Length - 2, 1));

            bool isFemale = genderNumber % 2 == 0;

            gender = isFemale ? "Female" : "Male";

            DateTime birthDate = DateTime.ParseExact(socialSecurityNumber.Substring(0, 6), "yyMMdd", CultureInfo.InvariantCulture);

            int age = DateTime.Now.Year - birthDate.Year;

            if ((birthDate.Month > DateTime.Now.Month) || (birthDate.Month == DateTime.Now.Month && birthDate.Day > DateTime.Now.Day))
            {
                age--;
            }
            // Input
            if (args.Length > 0)
            {
                // if input from terminal is already done
                Console.WriteLine($"You provided: {args[0]}");
                socialSecurityNumber = args[0];
            }
            else

            {   // Ask for input
                Console.WriteLine("Please input your Social security number YYMMDD-XXXX");
                socialSecurityNumber = Console.ReadLine();
            }



            Console.Clear();

            Console.WriteLine($"{gender}, {age}, {firstName}, {lastName}");



        }
    }
}




        

    

