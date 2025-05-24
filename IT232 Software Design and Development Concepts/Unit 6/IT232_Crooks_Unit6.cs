using System;
using System.Diagnostics;

namespace IT232_Unit_6_Assignment_Corey_Crooks
{
    class IT232_Crooks_Unit6
    {
        //Create a function that will take two numbers, and return the quotient
        public static int DivideByZero(int num1, int num2)
        {
            //If the divisor is 0,
            if (num2 == 0)
                //Throw an exception telling the user that they are trying to divide by zero.
                throw new Exception("Dvide By Zero");
            //Return the quotient of the two numbers.
            return (num1 / num2);
        }
        //Start the program.
        static void Main(string[] args)
        {
            //Print out the introductory assignment header.
            Console.WriteLine("Assignment 6 – Asserts and Try/Catch.");
            //*********************************************************

            //****Assignment 6 Section 1

            //*********************************************************

            //Set a string named "value" to be empty.
            string value = string.Empty;
            //If the string above is empty, tell the user the string needs to have content.
            Debug.Assert(string.IsNullOrEmpty(value) == false, "Parameter must not be empty or null.");
            //Set a number to be zero.
            int number = 0;
            //If the number above is 0 or less, tell the user the number needs to be greater than zero.
            Debug.Assert(number > 0, "Parameter must be greater than zero.");

            //*********************************************************

            //****Assignment 6 Section 2

            //*********************************************************

            //try to:
            try
            {
                //Set a new array of strings to be a list of names.
                string[] names = { "Ed", "Fred", "Ted", "Mel", "Stan" };
                //Create an empty string called "someName".
                string someName;
                //While we still have names left in our names array,
                for (int i = 0; i<= names.Length; i++)
                {
                    //Set teh someName string to be the element at the current index of the names array.
                    someName = names[i];
                }
            }
            //If there was an exception ex,
            catch (Exception ex)
            {
                //Tell the user there was an out of bounds exception,
                Console.WriteLine("'Array out of bounds' error occured");
                //And write the error from the compiler into the console.
                Console.WriteLine(ex.Message.ToString());
            }

            //*********************************************************

            //****Assignment 6 Section 3

            //*********************************************************

            //try to:
            try
            {
                //Set a new int lineCounter to zero.
                int lineCounter = 0;
                //Create an empty string called "line".
                string line;
                //Open a file called "NoFileNamedThis.txt" and,
                using (System.IO.StreamReader file = new System.IO.StreamReader("NoFileNamedThis.txt"))
                {
                    //While there are lines to read,
                    while ((line = file.ReadLine()) != null)
                    {
                        //Increase the line counter.
                        lineCounter++;
                    }
                }
            }
            //If there is an exception ex,
            catch (Exception ex)
            {
                //Tell the user that there is no file as specified,
                Console.WriteLine("'File not found' error.");
                //And write the error from the compiler into the console.
                Console.WriteLine(ex.Message.ToString());
            }

            //*********************************************************

            //****Assignment 6 Section 4

            //*********************************************************

            //Try to:
            try
            {
                //Use the DivideByZero function detailed above using arguments 42 and 0.
                DivideByZero(42, 0);
            }

            //If there's an exception ex,
            catch (Exception ex)
            {
                //Tell the user they are trying to divide by zero,
                Console.WriteLine("DivideByZeroError occurred.");
                //And write the error from the compiler into the console.
                Console.WriteLine(ex.Message.ToString());
            }
            //Keep the window open for the user to read the results.
            Console.Read();
        }
    }
}
