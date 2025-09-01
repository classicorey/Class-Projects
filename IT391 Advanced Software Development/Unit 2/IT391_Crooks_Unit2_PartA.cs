//Include dependencies for the console, interactivity, and stack/queue.
using System;
using System.Collections.Generic;
using System.Collections;
namespace StackNQueue
{
    class myProgram
    {
        //Part A code is the required example code as obtained from the Unit 2 Assignment Instructions.
        static void Main(string[] args)
        {
            //*********************************************************
            //****Assignment 2, Part A, Section 1
            //*********************************************************
         
            //Write out the section header on its own line.
            Console.WriteLine();
            Console.WriteLine("**********Section 1 **********");
            Console.WriteLine();
            //Write out the prompt for the user to enter a reversed word.
            Console.WriteLine("Enter any word and hit enter to see the word reversed: ");

            //Store the result in a string variable "str".
            string str = Console.ReadLine();
            //Reverse the string, and give the user the result.
            Console.WriteLine("\nYour word in reverse is: " + revString(str));

            //*********************************************************
            //****Assignment 2, Part A, Section 2
            //*********************************************************

            //Write the section header on its own line.
            Console.WriteLine();
            Console.WriteLine("**********Section 2 **********");
            Console.WriteLine();

            //Create a new Customer's queue object.
            Queue customers = new Queue();

            //Load the queue with 5 names
            customers.Enqueue("Jane");
            customers.Enqueue("Bob");
            customers.Enqueue("Liza");
            customers.Enqueue("Tom");
            customers.Enqueue("Mary");

            //Write out the total number of customers in our customers queue.
            Console.WriteLine("The number of shoppers at the grocery store is, " + customers.Count);
            //Write out who is first up in the queue.
            Console.WriteLine("The first shopper in line is, " + customers.Peek());

            //Add two more customers to the queue.
            customers.Enqueue("Stephen");
            customers.Enqueue("Ellen");

            //De-queue 3 customers.
            customers.Dequeue();
            customers.Dequeue();
            customers.Dequeue();
            //Write out the total number of customers in the updated queue.
            Console.WriteLine("The number of shoppers now in line is, " + customers.Count);
            //Write out the shopper in first in the updated queue.
            Console.WriteLine("The shopper currently first in line is, " + customers.Peek());

            //Keep the window open for the user to read the results.
            Console.ReadKey();
        }

        //Create a new function to reverse a string, taking a string as an argument and returning a string.
        private static string revString(string str)
        {
            //create a stack object to mangage letters in the string.
            Stack<string> wordStack = new Stack<string>();

            //while i is less than the length of the argument string,
            for (int i = 0; i < str.Length; i++)
                //push each character of the string argument to the stack object. Increment i.
                wordStack.Push(str.Substring(i, 1));
            //creat a new string that is currently empty.
            string reversed = string.Empty;
            //while i is less than the length of the argument string,
            for (int i = 0; i < str.Length; i++)
                //Add letters from the top of the stack to the current index in the new string. Increment i.
                reversed += wordStack.Pop();
            //Return the reversed string.
            return reversed;
        }
    }
}
