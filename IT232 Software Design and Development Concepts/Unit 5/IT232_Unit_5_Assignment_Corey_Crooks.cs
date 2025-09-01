using System;
using System.IO;
using System.Collections;


namespace IT232_Unit_5_Assignment_Corey_Crooks
{
    class Program
    {
        //Start the program.
        static void Main(string[] args)
        {
            //*********************************************************

            //****Assignment 5 Section 1

            //*********************************************************

            //Create a variable list of produce
            ArrayList produceList = new ArrayList();

            //Add bananas, grapes, apples, pears, lettuce, onions, potatoes, and peaches to the array list as well as their prices.
            produceList.Add("bananas 0.59");
            produceList.Add("grapes 2.99");
            produceList.Add("apples 1.49");
            produceList.Add("pears 1.39");
            produceList.Add("lettuce 0.99");
            produceList.Add("onions 0.79");
            produceList.Add("potatoes 0.59");
            produceList.Add("peaches 1.59");

            //While we read the producePrice text file, 
            using (StreamWriter writeFile = new StreamWriter (@"ProducePrice.txt"))
            {
                //While i is less than the total elements in the produce list,
                for (int i = 0; i < produceList.Count; i++)
                {
                    //write what we have in the produce list.
                    writeFile.WriteLine(produceList[i]);
                }
                //Close the file.
                writeFile.Close();
            }
            //Write how many products we have in our file.
            Console.WriteLine("There're " + FileLineCount("ProducePrice.txt") + " products in the file.\n");

            //*********************************************************

            //****Assignment 5 Section 2

            //*********************************************************

            //While we read the producePrice text file,
            using (StreamWriter appendFile = new StreamWriter(@"ProducePrice.txt", true))
            {
                //Add Peppers, celery, cabbage, and tomatoes to the file and their prices.
                appendFile.WriteLine("peppers 0.99");
                appendFile.WriteLine("celery 1.29");
                appendFile.WriteLine("cabbage 0.79");
                appendFile.WriteLine("tomatoes 1.19");

                //Close the file.
                appendFile.Close();
            }

            //Write how many products we have in the file.
            Console.WriteLine("There're " + FileLineCount("ProducePrice.txt") + " products in the file.\n");

            //*********************************************************

            //****Assignment 5 Section 2

            //*********************************************************

            //Create a new array list in produce prices
            ArrayList producePrices = new ArrayList();
            //Use a line counter to count the lines
            int lineCounter = 1;
            //Keep track of the current line we're reading
            string line;

            //While we read the producePrice text file,
            using (StreamReader readFile = new StreamReader (@"ProducePrice.txt", true))
            {
                //While we still have a line to read,
                while ((line = readFile.ReadLine()) != null)
                {
                    //add the current line to the produce prices list.
                    producePrices.Add(line);
                    //Write the current line number we're on and a period.
                    Console.WriteLine(lineCounter + ". " + line);
                    //Add to the line counter.
                    lineCounter++;
                }
                //Close the file.
                readFile.Close();
            }
            //Write how many products we have in the prices list.
            Console.WriteLine("\nThere're " + producePrices.Count + " products in the produce prices arrayList.\n");

            //Keep the console open for the user to read.
            Console.Read();
        }

        //Start a function to count the lines in a file.
        static int FileLineCount(string filename)
        {
            //Use a line counter int.
            int lineCounter = 0;
            //While reading the file we're currently looking at,
            using (StreamReader readFile = new StreamReader(filename))
            {
                //While we can still read a line,
                while (readFile.ReadLine() != null)
                {
                    //add a new line to the line counter.
                    lineCounter++;
                }
                //Close the file.
                readFile.Close();
            }
            //Return the number of lines in the line counter.
            return lineCounter;
        }

    }
}