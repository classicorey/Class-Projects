using System;

namespace IT391_Crooks_Unit4_PartB
{
    class Program
    {
        static void Main(string[] args)
        {
            //Note and print the section header.
            //*********************************************************
            //****Assignment 4, Part B, Section 1
            //*********************************************************
            Console.WriteLine("\n**********Section 1 - Bubble Sort **********\n");

            //Initialize and set the studentGrades int array that we will be using throughout the assignment.
            int[] studentGrades = {65, 95, 75, 55, 56, 90, 98, 88, 97, 78};
            //Tell the user what the array is using the printArray method.
            Console.Write("The unsorted list of grades is: ");
            printArray(studentGrades);

            //Sort the array using bubble sort by descending method.
            sortArrayDescBS(studentGrades);
            //Tell the user what the array is.
            Console.Write("The grades in descending order are: ");
            printArray(studentGrades);

            //Sort the array using bubble sort by ascending method.
            sortArrayAscBS(studentGrades);
            //Tell the user what the array is.
            Console.Write("The grades in ascending order are: ");
            printArray(studentGrades);

            //Note and print the section header.
            //*********************************************************
            //****Assignment 4, Part B, Section 2
            //*********************************************************
            Console.WriteLine("\n**********Section 2 - Quick Sort **********\n");

            //Reset the Student Grades array using the 'assign the list to a new version of itself' that we did last assignment.
            //Thanks again for helping me with that.
            studentGrades = new int[] { 65, 95, 75, 55, 56, 90, 98, 88, 97, 78 };

            //Inform the user of the reset list.
            Console.Write("The unsorted list of grades is: ");
            printArray(studentGrades);

            //Tell the user of the grades while initializing/setting two values for a Quick Sort.
            Console.Write("The grades in descending order are: ");
            int low = 0;
            int high = studentGrades.Length - 1;
            
            //Sort the array using the descending Quick Sort method and print the result.
            sortArrayDescQS(studentGrades, low, high);
            printArray(studentGrades);

            //Sort the array using the ascending Quick Sort method and print the result.
            Console.Write("The grades in ascending order are: ");
            sortArrayAscQS(studentGrades, low, high);
            printArray(studentGrades);

            //Note and print the section header.
            //*********************************************************
            //****Assignment 4, Part B, Section 3
            //*********************************************************
            Console.WriteLine("\n**********Section 3 - Sequential Search **********\n");

            //Search for 75 in the studentGrades sorted array, and write the output down.
            Console.WriteLine(seqSearch(studentGrades, 75));

            //Note and print the section header.
            //*********************************************************
            //****Assignment 4, Part B, Section 4
            //*********************************************************
            Console.WriteLine("\n**********Section 4 - Binary Search **********\n");

            //Remind the user of the sorted array.
            Console.Write("The sorted contents of the grade array are: ");
            printArray(studentGrades);
            //Tell the user the result of a binary search through the studentGrades array for 56.
            Console.WriteLine("\nWith the Binary Search, " + binarySearch(studentGrades, 56));
            //Tell the user the result of a sequential search through the studentGrades array for 50.
            Console.WriteLine("\nWith the Sequential Search, " + seqSearch(studentGrades, 50));
        }

        //I'm trying something new with these methods. I've done section headers for the methods
        //That I make which correspond to specific sections. Hopefully this makes it easier to grade.

        //*********************************************************
        //****Assignment 4, Part B, Section 1
        //*********************************************************

        //Create a method that sorts an input array by descending using the Bubble Sort algorithm.
        public static void sortArrayDescBS(int[] inputArray)
        {
            //Initialize a tempElement int to keep track of both elements.
            int tempElement;
            //While we still have elements to iterate through,
            for (int j = 0; j <= inputArray.Length - 2; j++)
            {
                //Create a nested for loop to search through elements,
                for (int i = 0; i <= inputArray.Length - 2; i++)
                {
                    //If the current element is less than the next,
                    if (inputArray[i] < inputArray[i + 1])
                    {
                        //Swap the elements.
                        tempElement = inputArray[i + 1];
                        inputArray[i + 1] = inputArray[i];
                        inputArray[i] = tempElement;
                    }
                }
            }
        }

        //Create a method that sorts an input array by ascending using the Bubble Sort algorithm.
        public static void sortArrayAscBS(int[] inputArray)
        {
            //Initialize a tempElement int to keep track of both elements.
            int tempElement;
            //While we still have elements to iterate through,
            for (int j = 0; j <= inputArray.Length - 2; j++)
            {
                //Create a nested for loop to search through elements,
                for (int i = 0; i <= inputArray.Length - 2; i++)
                {
                    //If the current element is greater than the next,
                    if (inputArray[i] > inputArray[i + 1])
                    {
                        //Swap the elements.
                        tempElement = inputArray[i + 1];
                        inputArray[i + 1] = inputArray[i];
                        inputArray[i] = tempElement;
                    }
                }
            }
        }

        //Create a method that prints an input array.
        public static void printArray(int[] inputArray)
        {
            //Write a bracket to open the array.
            Console.Write("[");
            //While we still have elements to iterate through,
            for (int i = 0; i < inputArray.Length; i++)
            {
                //Write the current element,
                Console.Write(inputArray[i]);

                //Followed by either a comma or close brackets to make it readable.
                if (i != inputArray.Length-1)
                {
                    Console.Write(", ");
                }
                else
                {
                    Console.Write("]\n");
                }
            }
        }

        //*********************************************************
        //****Assignment 4, Part B, Section 2
        //*********************************************************

        //Create a method that sorts an input array using the Quick Sort Method with a low, and high int input.
        public static void sortArrayDescQS(int[] inputArray, int low, int high)
        {
            //If the input array is empty, return nothing.
            if (inputArray == null || inputArray.Length == 0)
                return;
            //If the low value is greater than or equal to the high value, return nothing.
            if (low >= high)
                return;
            //Set the fulcrum to the middle of the sorting process.
            int middle = low + (high - low) / 2;

            int pivot = inputArray[middle];

            //Initialize two pivots as ints.
            int i = low, j = high;

            //while the iterator is less than the high pivot,
            while (i <= j)
            {
                //While the current element of the inputArray is greater than the pivot,
                while (inputArray[i] > pivot)
                    //Increment i.
                    i++;
                //While the high-pivot element of the inputArray is greater than the pivot,
                while (inputArray[j] < pivot)
                    //decrement j.
                    j--;

                //If i is less than or equal to the high pivot,
                if (i <= j)
                {
                    //swap elements.
                    int temp = inputArray[i];
                    inputArray[i] = inputArray[j];
                    inputArray[j] = temp;
                    //increment and decrement the iterators.
                    i++;
                    j--;
                }
            }
            //Sort the two sub-arrays using recursion.
            if (low < j)
                sortArrayDescQS(inputArray, low, j);
            if (high > i)
                sortArrayDescQS(inputArray, i, high);
        }

        //Do the same process as above, but in ascending alphabetical order.
        public static void sortArrayAscQS(int[] inputArray, int low, int high)
        {
            {
                if (inputArray == null || inputArray.Length == 0)
                    return;

                if (low >= high)
                    return;

                int middle = low + (high - low) / 2;
                int pivot = inputArray[middle];
                int i = low, j = high;

                while (i <= j)
                {
                    while (inputArray[i] < pivot)
                    {
                        i++;
                    }
                    while (inputArray[j] > pivot)
                    {
                        j--;
                    }
                    if (i <= j)
                    {
                        int temp = inputArray[i];
                        inputArray[i] = inputArray[j];
                        inputArray[j] = temp;
                        i++;
                        j--;
                    }
                }

                if (low < j)
                    sortArrayAscQS(inputArray, low, j);
                if (high > i)
                    sortArrayAscQS(inputArray, i, high);
            }
        }

        //*********************************************************
        //****Assignment 4, Part B, Section 3
        //*********************************************************
        //Create a method to sequentially search an array.
        public static string seqSearch(int[] inputArray, int searchTerm)
        {
            //Set an output to be failed by default.
            string outputString = "I did not find " + searchTerm + " at any index in the array.";

            //While there are still elements to search through,
            for (int i = 0; (i < inputArray.Length); i++)
            {
                //If the search term matches whatever is at the current array index,
                if (inputArray[i] == searchTerm)
                {
                    //Break operation and return the success.
                    return ("I have found " + searchTerm + " in this array at index " + i + ". ");
                }
            }
            //Return the result.
            return outputString;

        }

        //*********************************************************
        //****Assignment 4, Part B, Section 4
        //*********************************************************
        //Create a method to implement a binary search for a term through an array.
        public static string binarySearch(int[] inputArray, int searchTerm)
        {
            //Set variables for the min and max.
            int min = 0;
            int max = inputArray.Length - 1;
            //Set the output to failed by default.
            string outputString = "The search term "+ searchTerm + " was not found in the Binary Search.";

            //While we still need to search through the array,
            while (min <= max)
            {
                //Set the midpoint to break as the midpoint of the current array,
                int mid = (min + max) / 2;
                //If the search term matches what we're looking at,
                if (searchTerm == inputArray[mid])
                    //Break operation and return the success.
                    return ("I found " + searchTerm + " at the index of " + mid.ToString() + ".");
                
                //Otherwise if the search term is less than the breakpoint,
                else if (searchTerm < inputArray[mid])
                    //Set the max lower.
                    max = mid - 1;
                //Otherwise,
                else
                    //Set the max higher.
                    min = mid + 1;
                
            }
            //Return the result.
            return outputString;
        }
    }
}
