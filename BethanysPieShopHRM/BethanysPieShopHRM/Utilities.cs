using System;
namespace BethanysPieShopHRM
{
	internal class Utilities
	{

        
        public static void UsingSimpleStrings()
        {

            string firstName = "Bethany";
            string lastName = "Smith";
            string s;
            s = firstName;
            var userName = "BethanyS";
            userName = userName.ToLower();

            userName = string.Empty;
            userName = "";//identical to string.Empty;
        }

        public static void UsingEscapeCharacters()
        {
            string firstName = "Bethany";
            string lastName = "Smith";

            string displayName = $"Welcome!\n{firstName}\t{lastName}";

            string filePath = "C:\\data\\employeelist.xlsx";
            string marketingTagLine = "Baking the \"best pies\" ever";

            string verbatimFilePath = @"C:\data\employeelist.xlsx";
        }

        public static void UsingStringEquality()
        {

            string name1 = "Bethany";
            string name2 = "BETHANY";

            Console.WriteLine("Are both names equal? " + (name1 == name2));
            Console.WriteLine("Is name equal to Bethany? " + (name1 == "Bethany"));
            Console.WriteLine("Is name equal to BETHANY? " + name2.Equals("BETHANY"));
            Console.WriteLine("Is uppercase name equal to bethany? " + (name1.ToLower() == "bethany"));
        }

        public static void ManipulatingStrings()
        {
            string firstName = "Bethany";
            string lastName = "Smith";


            string fullName = firstName + " " + lastName;
            string employeeIdentification = String.Concat(firstName, lastName);
            //string empId = firstName.ToLower() + "-" + firstName.ToLower();
            string empId = firstName.ToLower() + "-" + lastName.Trim().ToLower();
            int length = empId.Length;


            if (fullName.Contains("beth") || fullName.Contains("Beth"))
            {
                Console.WriteLine("It's Bethany!");
            }
            string subString = fullName.Substring(1, 3);
            Console.WriteLine("Characters 2 to 4 of fullName are " + subString);

            //string interpolation
            string nameUsingInterpolation = $"{firstName}-{lastName}";
            Console.WriteLine(nameUsingInterpolation);
            //combined with implicit typing
            var v = $"Hello, {firstName}!";
            Console.WriteLine(v);
        }

        public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked)
        {
            //Console.WriteLine($"The yearly wage is: {monthlyWage * numberOfMonthsWorked}");
            //return monthlyWage * numberOfMonthsWorked;

            if (numberOfMonthsWorked == 12)//let's add a bonus month
                return monthlyWage * (numberOfMonthsWorked + 1);

            return monthlyWage * numberOfMonthsWorked;
        }

        public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked, int bonus)
        {
            Console.WriteLine($"The yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");
            return monthlyWage * numberOfMonthsWorked + bonus;
        }

        public static void UsingOptionalParameters()
        {
            int monthlyWage1 = 1234;
            int months1 = 12;

            int yearlyWageForEmployee1 = CalculateYearlyWageWithOptional(monthlyWage1, months1);
            Console.WriteLine($"Yearly wage for employee 1 (Bethany): {yearlyWageForEmployee1}");
        }

        public static int CalculateYearlyWageWithOptional(int monthlyWage, int numberOfMonthsWorked, int bonus = 0)
        {

            Console.WriteLine($"The yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");
            return monthlyWage * numberOfMonthsWorked + bonus;
        }

        public static int CalculateYearlyWageExpressionBodied(int monthlyWage, int
            numberOfMonthsWorked, int bonus) => monthlyWage * numberOfMonthsWorked + bonus; 
    }
}

