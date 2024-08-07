//Include dependencies for the console, interactivity, and stack/queue.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace StackNQueue
{
    class Program
    {
        //Create a new function to reverse a sentence while taking a string argument, and returning a string.
        private static string reverse(string inputStr)
        {
            //Create a new stack object called wordStack.
            Stack<string> wordStack = new Stack<string>();
            //For each word in the input string,
            foreach (String word in inputStr.Split(" "))
            {
                //Add each word in the string argument to the wordStack stack individually.
                wordStack.Push(word);
            }
            //Create a new empty string to hold the reversed output.
            string reversed = string.Empty;
            //While the stack is not empty,
            while (wordStack.Count() !=0)
            {
                //Add the current top-of-stack to the reversed string as it's own word.
                reversed += wordStack.Pop() + " ";
            }
            //Return the reversed string.
            return reversed;
        }
        //Start the program.
        static void Main(string[] args)
        {
            //*********************************************************
            //****Assignment 2, Part B, Section 1
            //*********************************************************
            //Write the section header on its own line.
            Console.WriteLine("\n**********Section 1 **********\n");

            //Create a new Queue called bankers.
            Queue bankers = new Queue();

            //Add 5 names to the bankers queue
            bankers.Enqueue("Jim");
            bankers.Enqueue("Bob");
            bankers.Enqueue("Suzan");
            bankers.Enqueue("Liz");
            bankers.Enqueue("Alex");

            //Write out the number of people in the bankers queue
            Console.WriteLine("The number of people in line at the bank is, " + bankers.Count + "\n");
            //Prepare to list the names of everyone in queue
            Console.Write("The names of those in line at the bank are: ");
            //For each element in the queue, assign the current element of the queue to the banker string
            foreach (String banker in bankers)
            {
                //Write the banker string with a space.
                Console.Write(banker + " ");
            }
            //Print out a new line.
            Console.WriteLine();

            //Write the first name in the string.
            Console.WriteLine("The first banker in line is, " + bankers.Peek());
            //Dequeue one person from the queue.
            bankers.Dequeue();
            //Add two to the queue.
            bankers.Enqueue("Andy");
            bankers.Enqueue("Rhonda");
            //Remove three from the queue.
            bankers.Dequeue();
            bankers.Dequeue();
            bankers.Dequeue();
            //Write out the updated number of people in the queue.
            Console.WriteLine("The number of customers in line now is, " + bankers.Count + "\n");

            //*********************************************************
            //****Assignment 2, Part B, Section 2
            //*********************************************************

            //Print out the section header on its own line.
            Console.WriteLine("\n**********Section 2 **********\n");
            //Ask the user for a sentence to be reversed.
            Console.WriteLine("Please enter a sentence.");

            //Create a string variable with the user's answer.
            string str = Console.ReadLine();
            //Give the user the reverse of their string using the reverse function.
            Console.WriteLine("\nYour Sentence in reverse is: " + reverse(str));

            //Keep the window open for the user to read the result.
            Console.ReadKey();

        }
    }
}
