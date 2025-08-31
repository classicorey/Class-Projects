using System;
using System.Diagnostics;

namespace IT391_Crooks_Unit4_PartB
{
    class Program
    {
        //Start the program.
        static void Main(string[] args)
        {
            //Define minimum and maximum values to be used for the random number generator.
            int minVal = 0;
            int maxVal = 10000;

            //Instantiate arrays of varying lengths to hold our data sets.
            int[] smallDataSet = new int[10];
            int[] mediumDataSet = new int[1000];
            int[] largeDataSet = new int[10000];
            //Create a stopwatch object to time our sorting methods.
            Stopwatch timer = new Stopwatch();
            //Create a random number generator object to help fill out our datasets.
            Random randNum = new Random();

            //Populate the small data set with random numbers.
            for (int i = 0; i < smallDataSet.Length; i++)
            {
                smallDataSet[i] = randNum.Next(minVal, maxVal);

            }
            //Clone the completed array for an apples-to-apples comparison, since the sorting method modifies the input.
            int[] smallDataSet2 = smallDataSet;

            //Populate the medium dataset with random numbers.
            for (int i = 0; i < mediumDataSet.Length; i++)
            {
                mediumDataSet[i] = randNum.Next(minVal, maxVal);

            }
            //Clone the completed array for an apples-to-apples comparison, since the sorting method modifies the input.
            int[] mediumDataSet2 = mediumDataSet;

            //Populate the large data set with random numbers.
            for (int i = 0; i < largeDataSet.Length; i++)
            {
                largeDataSet[i] = randNum.Next(minVal, maxVal);

            }
            //Clone the completed array for an apples-to-apples comparison, since the sorting method modifies the input.
            int[] largeDataSet2 = largeDataSet;

            //Start the timer, sort the array, and stop the timer.
            timer.Start();
            sortArrayAscBS(smallDataSet);
            timer.Stop();
            //Inform the user of the time it took, and reset the stopwatch.
            Console.WriteLine("Time to sort small data: {0}", timer.Elapsed);
            timer.Reset();

            //Start the timer, sort the array using the "optimized" method, and stop the timer.
            timer.Start();
            sortArrayAscBSOptimized(smallDataSet2);
            timer.Stop();
            //Inform the user of the time it took, and reset the stopwatch.
            Console.WriteLine("Time to sort small data with changes: {0}", timer.Elapsed);
            timer.Reset();

            //Start the timer, sort the array, and stop the timer.
            timer.Start();
            sortArrayAscBS(mediumDataSet);
            timer.Stop();
            //Inform the user of the time it took, and reset the stopwatch.
            Console.WriteLine("Time to sort medium data: {0}", timer.Elapsed);
            timer.Reset();

            //Start the timer, sort the array using the "optimized" method, and stop the timer.
            timer.Start();
            sortArrayAscBSOptimized(mediumDataSet2);
            timer.Stop();
            //Inform the user of the time it took, and reset the stopwatch.
            Console.WriteLine("Time to sort medium data with changes: {0}", timer.Elapsed);
            timer.Reset();

            //Start the timer, sort the array, and stop the timer.
            timer.Start();
            sortArrayAscBS(largeDataSet);
            timer.Stop();
            //Inform the user of the time it took, and reset the stopwatch.
            Console.WriteLine("Time to sort large data: {0}", timer.Elapsed);
            timer.Reset();

            //Start the timer, sort the array using the "optimized" method, and stop the timer.
            timer.Start();
            sortArrayAscBSOptimized(largeDataSet2);
            timer.Stop();
            //Inform the user of the time it took, and reset the stopwatch.
            Console.WriteLine("Time to sort large data with changes: {0}", timer.Elapsed);
            timer.Reset();
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

        //Create a method that sorts an input array by ascending using the Bubble Sort algorithm.
        //Remove the calculations from the for loops, and instead just use a variable to optimize this algorithm.
        public static void sortArrayAscBSOptimized(int[] inputArray)
        {
            //Initialize a tempElement int to keep track of both elements.
            int tempElement;
            //Store the for loop calculations for faster execution.
            int length = inputArray.Length - 2;
            //While we still have elements to iterate through,
            for (int j = 0; j <= length; j++)
            {
                //Create a nested for loop to search through elements,
                for (int i = 0; i <= length; i++)
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
    }
}
