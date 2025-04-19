using System;

namespace IT481_Unit4
{
    public class IT481_U4
    {
        static void Main(string[] args)
        {
            IT481_Unit4.IT481_U4 u4 = new IT481_Unit4.IT481_U4();
            Console.WriteLine("In Program Main");
            u4.findMinValueTest();
            u4.printIntArrayTest();
            u4.findIntValuesTest();
        }

        //Given an array of integers, and a number of times to look, return the minimum value

        public int findMinValue(int[] inputArray, int timesToLook)
        {
            int minVal = 999;
            int timesLooked = 0;

            if (timesLooked < timesToLook)
            {

                foreach (int value in inputArray)
                {
                    if (value < minVal)
                        minVal = value;
                }
                timesLooked++;
            }

            return minVal;
        }


        //Given an array in integers, print out each value
        public void printIntArray(int[] inputArray)
        {
            int i = 1;
            Console.Write("{");
            foreach (int value in inputArray)
            {
                if( i < inputArray.Length)
                {
                    Console.Write(value + ", ");
                    i++;
                }
                else
                {
                    Console.Write(value);
                }
            }
            Console.Write("}\n");
        }

        //Given two int search terms, scrub an input array to find them.
        public bool findIntValues(int[] inputArray, int termOne, int termTwo)
        {
            bool result = false;
            int i = 0;
            foreach (int value in inputArray)
            {
                if (value == termOne)
                {
                    Console.WriteLine("We have found the number  " + termOne + " at index " + i + ".");
                    result = true;
                }
                if (value == termTwo)
                {
                    Console.WriteLine("We have found the number " + termTwo + " at index " + i + ".");
                    result = true;
                }
                i++;
            }

            return result;
        }

        //Unit test for findMinValue:
        public void findMinValueTest()
        {
            int[] arrayOne = { 10, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] arrayTwo = { 234, 233, 01, 01, -13 };
            Console.WriteLine("The minimum value of arrayOne is: " + findMinValue(arrayOne, 3) + " (expected 2)");
            Console.WriteLine("The minimum value of arrayTwo is: " + findMinValue(arrayTwo, 1) + " (expected -13)");
        }

        //Unit test for printIntArray
        public void printIntArrayTest()
        {
            int[] arrayOne = { 10, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] arrayTwo = { 234, 233, 01, 1, -13 };
            Console.WriteLine("\nThe contents of the first test array are: ");
            printIntArray(arrayOne);
            Console.WriteLine("Expected: \n{10, 2, 3, 4, 5, 6, 7, 8, 9}");
            Console.WriteLine("\nThe contents of the second test array are: ");
            printIntArray(arrayTwo);
            Console.WriteLine("Expected: \n{234, 233, 1, 1, -13}");
        }

        //Unit test for findIntValues
        public void findIntValuesTest()
        {
            int[] arrayOne = { 10, 2, 3, 4, 5, 6, 7, 7, 9 };
            Console.WriteLine("\nCalling int search. Expecting index 0 and 4.");
            findIntValues(arrayOne, 10, 5);

            Console.WriteLine("\nCalling int search. Expecting two of the first at indexes 6 and 7 with none for the other number.");
            findIntValues(arrayOne, 7, 19);
        }
    }
}