using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assignment4A
{
    class myProgram
    {
        static void Main(string[] args)
        {
            //*********************************************************
            //****Assignment 4, Part A, Section 1
            //*********************************************************
            Console.WriteLine();
            Console.WriteLine("**********Section 1 - Quick Sort **********");
            Console.WriteLine();

            int[] myNumbers = { 6501, 9503, 7557, 5535, 5601, 9001, 9888, 8801, 9767, 7815 };

            Console.Write("The array unsorted is: [");
            for (int i = 0; i <= myNumbers.GetUpperBound(0); i++)
            {
                Console.Write(myNumbers[i]);
                if (i != myNumbers.GetUpperBound(0))
                {
                    Console.Write(",");
                }
            }
            Console.Write("]");


            int low = 0;
            int high = myNumbers.Length - 1;
            quickSort(myNumbers, low, high);

            Console.WriteLine();
            Console.Write("The array sorted is: [");
            for (int i = 0; i <= myNumbers.GetUpperBound(0); i++)
            {
                Console.Write(myNumbers[i]);
                if (i != myNumbers.GetUpperBound(0))
                {
                    Console.Write(",");
                }
            }
            Console.Write("]");

            //*********************************************************
            //****Assignment 4, Part A, Section 2
            //*********************************************************
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("**********Section 2 - Bubble Sort **********");
            Console.WriteLine();

            int[] myArray = { 5, 90, 35, 45, 150, 3 };

            Console.Write("The array unsorted is : [");
            for (int i = 0; i <= myArray.GetUpperBound(0); i++)
            {
                Console.Write(myArray[i]);
                if (i != myArray.GetUpperBound(0))
                {
                    Console.Write(",");
                }
            }
            Console.Write("]");

            bubbleSort(myArray);

            Console.WriteLine();
            Console.Write("The array sorted is : [");
            for (int i = 0; i <= myArray.GetUpperBound(0); i++)
            {
                Console.Write(myArray[i]);
                if (i != myArray.GetUpperBound(0))
                {
                    Console.Write(",");
                }
            }
            Console.Write("]");
            Console.WriteLine();

            //*********************************************************
            //****Assignment 4, Part A, Section 3
            //*********************************************************
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("**********Section 3 - Binary Search**********");
            Console.WriteLine();

            Console.WriteLine(binarySearch(myNumbers, 8801));
            Console.WriteLine();
            Console.WriteLine(binarySearch(myNumbers, 7777));

            Console.ReadKey();

        }


        public static void quickSort(int[] arr, int low, int high)
        {
            if (arr == null || arr.Length == 0)
                return;
            if (low >= high)
                return;
            // pick the pivot 
            int middle = low + (high - low) / 2;
            int pivot = arr[middle];
            // make left < pivot and right > pivot 
            int i = low, j = high;
            while (i <= j)
            {
                while (arr[i] < pivot)
                {
                    i++;
                }
                while (arr[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                    j--;
                }
            }
            // recursively sort two sub parts 
            if (low < j)
                quickSort(arr, low, j);
            if (high > i)
                quickSort(arr, i, high);
        }

        public static void bubbleSort(int[] arr)
        {
            int t;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        t = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = t;
                    }
                }
            }

        }

        static string binarySearch(int[] arr, int num)
        {
            string answer = "";
            int first = 0;
            int last = arr.Length - 1;
            int middle = (first + last) / 2;
            while (first <= last)
            {
                if (arr[middle] < num)
                    first = middle + 1;
                else if (arr[middle] == num)
                {
                    answer = num + " found at location " + (middle + 1) + ".";
                    break;
                }
                else
                    last = middle - 1;
                middle = (first + last) / 2;
            }
            if (first > last)
                answer = num + " is not present in the list.\n";

            return answer;

        }
    }
}
