using System;

namespace ConsoleApp1
{
    class Program
    {
        //Start Main
        static void Main(string[] args)
        {
            //Declare variables including:
            //An int array containing 10 values
            int[] intArray = { 56, 77, 23, 12, 88, 59, 97, 33, 38, 64 };
            //A string array that can hold up to 10 strings
            string[] stringArray = new string[10];
            //And the index of the largest number contained in the int array using the findMax function
            int maxNumIndex = findMax(intArray, intArray.Length);

            //Set each value of the string array to be either even or odd depending on the values of the int array
            evenOrOdd(intArray, stringArray, intArray.Length);
            //Write out the maximum value of the int array, and its index
            Console.WriteLine("The Maximum Value in the Array is " + intArray[maxNumIndex] + " with the index of " + maxNumIndex + ".");
            //Write out the numbers of the int array sequentially
            Console.WriteLine("The Array was composed of the following numbers: ");
            //Start a loop to start at the first value in the array, and end at the last
            for (int i = 0; i < intArray.Length;)
            {
                //If you are currently looking before the second to last value in the array,
                if (i < intArray.Length - 2)
                    //Write the value, followed by "which is" followed by the even or odd determiniation, followed by a comma
                    Console.WriteLine(intArray[i] + " which is " + stringArray[i] + ",");
                //If you are looking at the second to last value in the int array,
                else if (i == intArray.Length - 2)
                    //Write the same format as before, but this time with and oxford comma followed by an "and" to help with grammar
                    Console.WriteLine(intArray[i] + " which is " + stringArray[i] + ", and");
                //If neither of the last two conditions apply,
                else
                    //Then you must be looking at the last value in the int array, so use a period instead of a comma at the end
                    Console.WriteLine(intArray[i] + " which is " + stringArray[i] + ".");
                //i++ could be put in the for syntax, but this helps me with readability and debugging
                i++;
            }
            //Keep the window open, so the user can read the output
            Console.Read();
        }
        //End Main

        //Start the findMax function
        public static int findMax(int[] intArray, int length)
        {
            //Declare variables including:
            //An int to store the value of the maximum number in the int array, initialized at 0
            int maxValue = intArray[0];
            //An int to store the position of the maximum number in the int array, initialized at 0
            int maxValuePosition = 0;

            //Start a loop to comb through the int array looking for the maximum number
            for (int i = 0; i < length;)
            {
                //If the current indexed value is greater than what we currently have stored as the maximum value,
                if (intArray[i] > maxValue)
                {
                    //Then record the value of the maximum number
                    maxValue = intArray[i];
                    //And record the index of the maximum number
                    maxValuePosition = i;
                }
                //i++ could be put in the for syntax, but this helps me with readability and debugging
                i++;
            }
            //When finished, return the index of the maximum number
            return maxValuePosition;
        }
        //End findMax

        //Start the evenOrOdd function
        public static void evenOrOdd(int[] intArray, string[] strArray, int length)
        {
            //Start a loop to determine if a given value is even or odd per each value in the int array
            for (int i = 0; i < length;)
            {
                //If the current indexed value of int array is divisible by two,
                if (intArray[i] % 2 == 0)
                    //Set the corrosponding value of the string array to be "even"
                    strArray[i] = "even";
                //If it is not divisible by two,
                else
                    //Set the corrosponding value of the string array to be "odd"
                    strArray[i] = "odd";
                //i++ could be put in the for syntax, but this helps me with readability and debugging
                i++;
            }
        }
        //End evenOrOdd
    }
    //End Program class
}
//Big end
