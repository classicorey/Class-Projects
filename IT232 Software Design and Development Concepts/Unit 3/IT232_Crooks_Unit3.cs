using System;
using System.Collections;
namespace IT232_Unit_3_Assignment
{
    class IT232_Crooks_Unit3
    {
        static void Main(string[] args)
        {
            //Start the Program


            //*********************************************************

            //****Assignment 3 Section 1

            //*********************************************************


            //Create a new 3D array of strings called sales Region
            string[,] salesRegions = new string[4, 4];

            //The grid should contain the cardinal directions as headers,
            salesRegions[0, 0] = "North";
            salesRegions[1, 0] = "South";
            salesRegions[2, 0] = "East";
            salesRegions[3, 0] = "West";

            //Bob, Stef, and Ron in column 1,
            salesRegions[0, 1] = "Bob";
            salesRegions[0, 2] = "Stef";
            salesRegions[0, 3] = "Ron";

            //Sue, Janice, and Will in column 2,
            salesRegions[1, 1] = "Sue";
            salesRegions[1, 2] = "Janice";
            salesRegions[1, 3] = "Will";

            //Nathan, Henry, and Kimmy in column 3,
            salesRegions[2, 1] = "Nathan";
            salesRegions[2, 2] = "Henry";
            salesRegions[2, 3] = "Kimmy";

            //and Ms. Maximoff, Prince Charles, and Pete Castiglione in the final column.
            salesRegions[3, 1] = "Wanda";
            salesRegions[3, 2] = "Charles";
            salesRegions[3, 3] = "Pete";

            //Tell the user we are beginning section 1 of the assignment.
            Console.WriteLine("Section 1: Two-dimensional Array.");


            //For every time there is a row left to scan/print,
            for (int row = 0; row < 4; row++)
            {
                //For every time there is a column left to scan/print,
                for (int col = 0; col < 4; col++)
                {
                    //Write out the element at the current index of the 3D array.
                    Console.WriteLine(salesRegions[row, col]);
                }
                //Print a new line
                Console.WriteLine("");
            }


            //*********************************************************

            //****Assignment 3 Section 2

            //*********************************************************

            //create a new array list to make a dynamic array.
            ArrayList salesTeam = new ArrayList();


            //For every time there is a column left to scan,
            for (int col = 1; col < 4; col++)
            {
                //Add the elements of the first column of the 3D array to our dynamic array.
                salesTeam.Add(salesRegions[0, col]);
            }
            //Notify the user we are moving on to section 2 of the Assignment.
            Console.WriteLine("Section 2: Array List.");
            //Print a new line.
            Console.WriteLine("");

            //Inform the user how many names are in the dynamic arrray.
            Console.Write("There are " + salesTeam.Count.ToString() + " names in the salesTeam arrayList.");

            //Fore each time there is still a column left to scan,
            for (int col = 1; col < 4; col++)
            {
                //Add the elements in column 1 of the 3D array to the dynamic array.
                salesTeam.Add(salesRegions[1, col]);
            }

            //Print a new line
            Console.WriteLine("");

            //If Stef is in the dynamic array,
            if (salesTeam.Contains("Stef"))
            {
                //Inform the user that Stef is in the dynamic array.
                System.Console.WriteLine("Stef is in the salesTeam arrayList.");
            }
            //If not,
            else
            {
                //Inform the user that Stef is not in the dynamic array.
                System.Console.WriteLine("Stef is not in the salesTeam arrayList.");
            }

            //Inform the user of how many names are in the dynamic array now.
            Console.WriteLine("There are " + salesTeam.Count.ToString() + " names in the salesTeam arrayList.");

            //Remove Jandice and Ron from the dynamic array.
            salesTeam.Remove("Jandice");
            salesTeam.Remove("Ron");

            //Inform the user of how many names are in the dynamic array now.
            Console.WriteLine("There are " + salesTeam.Count.ToString() + " names in the salesTeam arrayList.");

            //Prepare to inform the user of which elements are in the dynamic array.
            Console.WriteLine("Names currently in the salesTeam arrayList:");

            //For every time there's still a new element to scan in the dynamic array,
            for (int i = 0; i < salesTeam.Count; i++)
            {
                //print the contents of that element.
                Console.WriteLine(salesTeam[i]);
            }

            //Keep the window open for the user to see the results.
            Console.Read();
        }
    }
}
