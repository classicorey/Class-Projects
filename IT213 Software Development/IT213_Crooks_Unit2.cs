using System;

namespace IT213_Crooks_Unit2
{
    class Program
    {
        static void Main(string[] args)
        {
            //                                                                                  Start Section 1
            int num1;
            int num2;
            double grade;
            int month;
            int dayOfWeek;

            //Read first number of user input
            Console.WriteLine("Please enter first whole number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            //Read second number of user input
            Console.WriteLine("Please enter second whole number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            //Start conditionals to compare numbers and display correlation
            if (num1 == num2)
                Console.WriteLine("{0} = {1}", num1, num2);
            if (num1 != num2)
                Console.WriteLine("{0} <> {1}", num1, num2);
            if (num1 < num2)
                Console.WriteLine("{0} < {1}", num1, num2);
            if (num1 > num2)
                Console.WriteLine("{0} > {1}", num1, num2);
            if (num1 <= num2)
                Console.WriteLine("{0} <= {1}", num1, num2);
            if (num1 >= num2)
                Console.WriteLine("{0} >= {1}", num1, num2);
            //                                                                                  Start Section 2
            //Read user input for grade
            Console.WriteLine("Enter your final grade: ");
            grade = Convert.ToInt32(Console.ReadLine());

            //Display whether or not the student passed using the grade variable
            if (grade >= 60)
                Console.WriteLine("Congratulations! You Passed!");
            else
                Console.WriteLine("Sorry, you failed.");
            //                                                                                  Start Section 3
            //Read user input for month
            Console.WriteLine("Enter the number of the month: ");
            month = Convert.ToInt32(Console.ReadLine());

            //Compare user input and write the month name based on int value
            if (month == 1)
            {
                Console.WriteLine("The month is January.");
            }
            else if (month == 2)
            {
                Console.WriteLine("The month is February.");
            }
            else if (month == 3)
            {
                Console.WriteLine("The month is March.");
            }
            else if (month == 4)
            {
                Console.WriteLine("The month is April.");
            }
            else if (month == 5)
            {
                Console.WriteLine("The month is May.");
            }
            else if (month == 6)
            {
                Console.WriteLine("The month is June.");
            }
            else if (month == 7)
            {
                Console.WriteLine("The month is July.");
            }
            else if (month == 8)
            {
                Console.WriteLine("The month is August.");
            }
            else if (month == 9)
            {
                Console.WriteLine("The month is September.");
            }
            else if (month == 10)
            {
                Console.WriteLine("The month is October.");
            }
            else if (month == 11)
            {
                Console.WriteLine("The month is November.");
            }
            else if (month == 12)
            {
                Console.WriteLine("The month is December.");
            }
            //Display error message if invalid input
            else
            {
                Console.WriteLine("Please enter a whole number within the range of 1 and 12.");
            }
            //                                                                                  Start Section 4
            Console.WriteLine("How many days into the week is it? ");
            dayOfWeek = Convert.ToInt32(Console.ReadLine());

            //Output day name based on user input
            switch(dayOfWeek)
            {
                case 1:
                    Console.WriteLine("The day is: Sunday.");
                    break;
                case 2:
                    Console.WriteLine("The day is: Monday.");
                    break;
                case 3:
                    Console.WriteLine("The day is: Tuesday.");
                    break;
                case 4:
                    Console.WriteLine("The day is: Wednesday.");
                    break;
                case 5:
                    Console.WriteLine("The day is: Thursday.");
                    break;
                case 6:
                    Console.WriteLine("The day is: Friday.");
                    break;
                case 7:
                    Console.WriteLine("The day is: Saturday.");
                    break;
                //Display error message if invalid input
                default:
                    Console.WriteLine("Please enter a whole number within the range of 1 and 7.");
                    break;


            }
            //Keep window open for users to read output
            Console.Read();
        }
    }
}
