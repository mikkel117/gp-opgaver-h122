using System;
using System.Linq;
using static System.Console;

/*
 * This project is a collection of exersises that will teach students how to write clean and DRY code.
 * These exersises are stutable for beginer to experienced programmers.
 */
namespace CleanCodeExersises
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine(IsLegalDrikingAgeClean(21));
            bool test2 = IsLoggedInClean(true);
            bool test3 = eligibleClean(new Employee());
            WriteLine(GetPriceClean(true));
        }
        /*
         * Magic Number exercise
         */
        public bool IsLegalDrikingAgeDirty(int age)
        {
            if (age > 21)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /*
         * Solution to Magic Number exercise
         * Use consts to describe the numbers you are using to your programs.
         */
        public static string IsLegalDrikingAgeClean(int age)
        {
            const int leaglDrikingAge = 21;
            return age >= leaglDrikingAge ? "it's legal for you to drink" : "it's not legal for you to drink";
        }
        /*
         * Be positive exersise
         */
        public bool IsLoggedInDirty(bool isNotloggedIn)
        {
            if (!isNotloggedIn == true)
            {
                System.Console.WriteLine("Succesfully logged in.");
                return true;
            }
            else
            {
                System.Console.WriteLine("Failed to logged in.");
                return false;
            }
        }
        /*
         * Solution to Be positive exersise
         */
        public static bool IsLoggedInClean(bool isLoggedIn)
        {
            if (isLoggedIn == true)
            {
                WriteLine("Succesfully logged in.");
                return true;
            }
            else
            {
                WriteLine("Failed to logged in.");
                return false;
            }

        }
        /*
         * Intermediate exercise
         * What is the question answering?
         */
        public bool eligibleDirty(Employee employee)
        {
            if (employee.Age > 55
                && employee.YearsEmployed > 10
                && employee.IsRetired == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /*
         * Solution to ohm Intermediate exercise
         * An intermediate Variable says a lot more them a long expression
         */
        public static bool eligibleClean(Employee employee)
        {
            const int employeeMaxAge = 55;
            const int yearsEmployed = 10;
            if (employee.Age > employeeMaxAge && employee.YearsEmployed > yearsEmployed && employee.IsRetired == true)
            {
                WriteLine($"this employee is under {employeeMaxAge} and has been employed for {yearsEmployed} years and is retired");
                return true;
            }
            else
            {
                WriteLine($"this employee is under {employeeMaxAge} and has been employed for under {yearsEmployed} years and is not retired");
                return false;
            }

        }

        /*
         * Ternary exersise
         */
        public double GetPriceDirty(bool isPreordered)
        {
            if (isPreordered == true)
            {
                return 200.00;
            }
            else
            {
                return 350.00;
            }
        }
        /*
         * Solution to Ternary exersise
         * Use a oneline Ternary.
         */
        public static double GetPriceClean(bool isPreordered)
        {
            return isPreordered ? 200.00 : 350.00;
        }
        /*
         * Strong type exersise - not done
         */

    }
}


