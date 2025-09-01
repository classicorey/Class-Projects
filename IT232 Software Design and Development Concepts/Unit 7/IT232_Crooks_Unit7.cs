//Use dependencies for system, and input/output streams
using System;
using System.IO;

namespace Unit7
{
    class IT232_Crooks_Unit7
    {
        //Keep track of a string that contains the name of the log file.
        static string logFileName;

        //Start a function that will display the contents of the log file.
        public static void DisplayLogFile(string logFileName)
        {
            //Close the initial error readout
            Console.Error.Close();

            //Ensure our path matches the name of the Log File we are currently using.
            string path = logFileName;

            //Open or create file with read and write privileges. 
            using (FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                //Read the file opened.
                using (StreamReader streamReader = new StreamReader(fileStream))
                {
                    //While we have more lines to read,
                    while (streamReader.EndOfStream == false)
                    {
                        //write to the console the currently line we're reading.
                        Console.WriteLine(streamReader.ReadLine());
                    }
                }
            }
        }

        //Start a function to produce an error due to a file path mismatch.
        public static void FileDoesNotExist()
        {
            //Start a variable for the line counter.
            int lineCounter = 0;
            //Start a string variable to keep track of our current line.
            string line;
            //Open a file that doesn't exist.
            using (System.IO.StreamReader file = new System.IO.StreamReader("NoFileNamedThis.txt"))
            {
                //While we still have lines to read,
                while ((line = file.ReadLine()) != null)
                {
                    //add to the line counter.
                    lineCounter++;
                }
            }
        }

        //Start a function to divide by zero.
        public static void divideByZero()
        {
            //Create a variable for our dividend.
            int num1 = 15;
            //Create a variable for our divisor.
            int num2 = 0;
            //Set our quotient via the division to produce an error.
            int sum = num1 / num2;
        }

        //Start a function to produce an error due to checking indexes of an array that is out of bounds.
        public static void ArrayOutOfBounds()
        {
            //Set an array of strings to house names.
            string[] names = { "Ed", "Fred", "Ted", "Mel", "Stan" };

            //While we still have names to check (and over by one),
            for (int i = 0; i <= names.Length; i++)
            {
                //Set a name variable to be the name found at the current index.
                string SomeName = names[i];
            }
        }

        //Start a function to produce a null error.
        public static void ArrayIsNull()
        {
            //Set an array of strings to house names.
            string[] names = { "Ed", "Fred", "Ted", "Mel", "Stan" };
            //Set the same array to be null.
            names = null;
            //Set a string variable to be the names array index 2, which currently doesn't exist.
            string SomeName = names[2];
        }


        //Start the program.
        static void Main(string[] args)
        {
            //Print to console the required text as per the assignment instructions. 
            Console.WriteLine("Assignment 7 – Logging Exceptions to a File.\n");
            Console.WriteLine("Testing Try/Catch for Divide by Zero, File Does Not Exist, Array Out of Bounds, and Array is Null scenarios.");
            Console.WriteLine("All console error messages are printed from error log file.");

            //Set a string variable to be the name of our error log file.
            logFileName = @"log.txt";
            //Open the error log's stream.
            TextWriter errStream = new StreamWriter(logFileName);

            //Write the error stream instead to the file we've specified.
            Console.SetError(errStream);

            //try to,
            try
            {
                //call the divide by zero function.
                divideByZero();
            }
            //If there's an exception,
            catch (Exception ex)
            {
                //Write the error message to our log file.
                string err = ex.Message.ToString();
                Console.Error.WriteLine(err);
            }

            //try to,
            try
            {
                //Call the function to reference a file that doesn't exist.
                FileDoesNotExist();
            }

            //If there's an exception,
            catch (Exception ex)
            {
                //Write the error message to our log file.
                string err = ex.Message.ToString();
                Console.Error.WriteLine(err);
            }

            //try to,
            try
            {
                //Call the function to reference an index of an array that's out of bounds.
                ArrayOutOfBounds();
            }

            //If there's an exception,
            catch (Exception ex)
            {
                //Write the error message to our log file.
                string err = ex.Message.ToString();
                Console.Error.WriteLine(err);
            }

            //try to,
            try
            {
                //Call the function to reference an index of an array that's set to null.
                ArrayIsNull();
            }

            //If there's an exception,
            catch (Exception ex)
            {
                //Write the error message to our log file.
                string err = ex.Message.ToString();
                Console.Error.WriteLine(err);
            }

            //Call the function to write the errors recieved above to the console.
            DisplayLogFile("log.txt");
        }
    }
}
