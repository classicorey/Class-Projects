using System;

namespace IT213_Crooks_Unit3
{
    class Program
    {
        static void Main(string[] args)
        {
            //*********************************************************

            //****Assignment 3 Section 1

            //*********************************************************
            //Declare variables
            int i = 0;
            int assignmentGrade = 0;       
            int overallGrade = 0;
            float averageGrade = 0;

            //Start while loop. i will be used as a generic checkpoint variable to ensure the code does not execute more than 10 times.
            while (i < 10)
            {
                //Ask what grade the student got on assignment, and store result in variable assignmentGrade
                Console.WriteLine("What grade did you get? ");
                assignmentGrade = Convert.ToInt32(Console.ReadLine());
                //Add the individual assignment grade to the overall grade
                overallGrade += assignmentGrade;
                //Increment i by 1. This could be done after specifying the condition of the While statement, but I find it easier to read if i is incremented at the end of the loop.
                i++;
            }
            //Set Average Score to the sum of all point divided by 10
            averageGrade = overallGrade / 10;
            //Display the Sum of all Assignment Grades
            Console.WriteLine("All points added up is: " + overallGrade);
            //Display Average Score
            Console.WriteLine("The Average Grade is: " + averageGrade);
            

            //*********************************************************

            //****Assignment 3 Section 2

            //*********************************************************
            //Declare Variables (i has been declared above. We will just reset it)
            int k = 5;
            i = 0;

            //Start outside while loop using k counting down
            while (k > 1)
            {
                //Set i to 0 to ensure that the inside will loop correctly from the end of one to the beginning of another
                i = 0;
                //Start inside loop using i counting up by 2
                while (i < 10)
                {
                    //Tell the user the values of k and i for debugging
                    Console.WriteLine("k = {0}, and i = {1}", k, i);
                    //increment i by two. This could be written earlier, but I prefer this for readability.
                    i += 2;
                }
                //decrement k. This could be written earlier, but I prefer this for readability.
                k -= 1;
            }
            
            
            //*********************************************************

            //****Assignment 3 Section 3

            //*********************************************************
            //Declare Variables (i has been declared above. We will just reset it)
            i = 1;
            int userInput = 0;
            int inputSum = 0;

            //Start while loop using i as a checkpoint
            while (i > 0)
            {
                //Ask the user to give us either a positive number, or "-1" and record their response in the userInput int
                Console.WriteLine("Enter a positive number to be added, or input '-1' to total all values: ");
                userInput = Convert.ToInt32(Console.ReadLine());
                //If they typed a positive number, add it to the inputSum
                if (userInput > 0)
                    inputSum += userInput;
                //If they typed "-1" then exit the loop
                else if (userInput == -1)
                    i = 0;
            }
            //Display the sum of what they entered
            Console.WriteLine("The Sum of the numbers you entered is: "+ inputSum);
            //Keep the console open so the user can read the output
            Console.ReadKey();

        }
    }
}
