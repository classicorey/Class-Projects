//Dependencies for methods used in this program.
using System;
using System.Collections.Generic;
using System.Linq;

namespace IT391_Crooks_Unit3_PartB
{
    class Program
    {
        //Start the program.
        static void Main(string[] args)
        {
            //*********************************************************
            //****Assignment 3, Part B, Section 1
            //*********************************************************

            //Introduce the section
            Console.WriteLine("\n**********Section 1 **********\n");
            //Introduce the set
            Console.WriteLine("\nContents of the set are:\n");
            //Create a new array of mammals, and populate it with six elements.
            String[] mammals = new string[] { "Bear", "Gorilla", "Tiger", "Polar Bear", "Lion", "Monkey" };
            //Set the mammals to a new hash set.
            HashSet<String> setMammals = new HashSet<String>();
            //Introduce a try statement for error handling.
            try
            {
                //While you still have mammals to transfer,
                for (int i = 0; i <= mammals.GetUpperBound(0); i++)
                {
                    //Use the Add method to add mammals to the set.
                    setMammals.Add(mammals[i]);
                }
                //Write a bracket to introduce output.
                Console.Write("[");
                //While you still have mammals to print,
                for (int i = 0; i <= mammals.GetUpperBound(0); i++)
                {
                    //Print the mammals.
                    Console.Write(mammals[i]);
                    //If that was the last mammal,
                    if (i == mammals.GetUpperBound(0))
                    {
                        //Close the list.
                        Console.Write("]");
                    }
                    //Otherwise,
                    else
                    {
                        //Write a comma for the next mammal.
                        Console.Write(", ");
                    }
                }
                //Write two blank lines.
                Console.WriteLine();
                Console.WriteLine();
                //Prepare the user to see the sorted set.
                Console.WriteLine("The Contents of the Sorted Set Are:\n");
                //Create a sorted set using the mammals array.
                SortedSet<String> sortedMammals = new SortedSet<string>(setMammals);
                //Write a bracket to introduce output.
                Console.Write("[");
                //Set an integer a to zero.
                int a = 0;
                //For each animal in the sorted mammals set,
                foreach (string animal in sortedMammals)
                {
                    //Write the name of that animal,
                    Console.Write(animal);
                    //If that is not the end of the list,
                    if (a != sortedMammals.Count() - 1)
                        //Write a comma to introduce the next animal.
                        Console.Write(", ");
                    //Increment a.
                    a++;
                }
                //Write a close bracket to end the list.
                Console.Write("]\n");
                //Tell the user what the first item in the set is.
                Console.WriteLine("\nThe first item in the set is: " + sortedMammals.First());
                //Tell the user what the last item in the set is.
                Console.WriteLine("\nThe last item in the set is: " + sortedMammals.Last());
            }
            //If there was an error,
            catch (Exception ex)
            {
                //Inform the user.
                Console.WriteLine("Encountered Error: " + ex.Message.ToString());
            }



            //*********************************************************
            //****Assignment 3, Part B, Section 2
            //*********************************************************

            //Introduce the section.
            Console.WriteLine("\n********** Section 2 **********\n");
            //Introduce a try statement for error handling.
            try
            {
                //Create a new string linked list called myFriends.
                LinkedList<String> myFriends = new LinkedList<String>();
                //Add 8 friends to the linked list.
                myFriends.AddLast("Fred 602-299-3300");
                myFriends.AddLast("Ann 602-555-4949");
                myFriends.AddLast("Grace 520-544-9898");
                myFriends.AddLast("Sam 602-343-8723");
                myFriends.AddLast("Dorothy 520-689-9745");
                myFriends.AddLast("Susan 520-981-8745");
                myFriends.AddLast("Bill 520-456-9823");
                myFriends.AddLast("Mary 520-788-3457");

                //Introduce the contents of the list.
                Console.WriteLine("The contents of my Friends list:\n");
                //For each friend in the myFriends linked list,
                foreach (var friend in myFriends)
                {
                    //Write the friend on their own line.
                    Console.WriteLine(friend);
                }
                //Remove Bill from the friends list.
                myFriends.Remove("Bill 520-456-9823");
                //Sort the list.
                /* Thank you for helping me with this code. I had no idea how to go about sorting a linked list, and didn't realize 
                that you could just assign it to a new version of itself that is pre-sorted. */
                myFriends = new LinkedList<String>(myFriends.OrderBy(i => i));
                //Remove the first and last elements of the linked list.
                myFriends.RemoveFirst();
                myFriends.RemoveLast();
                //Change Mary's phone number.
                myFriends.Find("Mary 520-788-3457").Value = "Mary 520-897-4567";
                //Introduce the updated list.
                Console.WriteLine("\nThe updated contents of my Friends list:\n");
                //For each friend in the myFriends list,
                foreach (var friend in myFriends)
                {
                    //Write the friend.
                    Console.WriteLine(friend);
                }
                //Write out how many friends you have left.
                Console.Write("\nThe number of friends in my list is ");
                Console.Write(myFriends.Count + ", ");
                //If the myFriends list contains Fred,
                if (myFriends.Contains("Fred 602-299-3300"))
                {
                    //Let the user know.
                    Console.Write("including Fred.\n");
                }
                //If not,
                else
                {
                    //Let the user know.
                    Console.Write("but Fred is not in that list.\n");
                }

            }

            //If there was an error,
            catch (Exception ex)
            {
                //Inform the user.
                Console.WriteLine("Encountered Error: " + ex.Message.ToString());
            }


            //*********************************************************
            //****Assignment 3, Part B, Section 2
            //*********************************************************
            //Part of this section's code was retrieved from the code example, as required on the assignment instructions.
            //Introduce a try statement for error handling.
            try
            {
                //creates a new binary tree object which will initialize itself and print its contents
                new BinaryTree().create();

                //Keep the window open for the user.
                Console.ReadKey();
            }

            //If there was an error,
            catch (Exception ex)
            {
                //Inform the user.
                Console.WriteLine("Encountered Error: " + ex.Message.ToString());
            }

        }

        //Create a new Node class.
        public class Node
        {
            //Utilize nodes left and right for navigation.
            public Node left;
            public Node right;
            //Keep track of the value of that node with an int.
            public int value;
            //Initialize the node.
            public Node(int value)
            { this.value = value; }
        }

        //Create a class for the Binary Tree. The meat of the section.
        public class BinaryTree
        {
            //Create a Create method of the Binary Tree class. Fun to say.
            public void create()
            {
                //Keep track of the root node.
                Node rootnode = new Node(50);
                //Insert four nodes using the insert method.
                insert(rootnode, 30);
                insert(rootnode, 45);
                insert(rootnode, 12);
                insert(rootnode, 29);
                //traverse the Binary Tree using the root node, and the traverse method.
                traverse(rootnode);
            }

            //Create an insert method of the Binary Tree class.
            public void insert(Node node, int value)
            {
                /* The assignment instructions say to copy-and-paste this code from the example, and to add the other methods,
                so I will do my best to decode this method in these line-by-line comments. */
                //If the value is less than the value of the current node we're looking at,
                if (value < node.value)
                {
                    //If the node to the left is not null,
                    if (node.left != null)
                    {
                        //Insert a node to the left using this value
                        insert(node.left, value);
                    }
                    //Otherwise,
                    else
                    {
                        //Create a node to the left, and submit the value to it.
                        node.left = new Node(value);
                    }
                }
                //If the value is greater than the value of the node we're looking at,
                else if (value > node.value)
                {
                    //if the node to the right is not null,
                    //also this if was written with the condition and execution statements on all one line. My eyes can only take so much...
                    if (node.right != null)
                    {
                        //Set a node to the right to the requested value.
                        insert(node.right, value);
                    }
                    //Otherwise,
                    else
                    {
                        //create a new node to the right, and set it to the requested value.
                        node.right = new Node(value);
                    }
                }
            }
            //Create a traverse method in the Binary Tree class.
            public void traverse(Node rootnode)
            {
                //Introduce the section we're in.
                Console.WriteLine("\n********** Section 3 **********\n");

                //Write that you are traversing the Binary Tree in order.
                Console.WriteLine("Traversing the Binary Tree in order:");
                //Call the printInOrder method to traverse in order.
                printInOrder(rootnode);

                //Write that you are traversing the Binary Tree in pre-order.
                Console.WriteLine("\nTraversing the Binary Tree in pre-order:");
                //Call the printPreOrder method to traverse in pre-order.
                printPreOrder(rootnode);

                //Write that you are traversing the Binary Tree in post-order.
                Console.WriteLine("\nTraversing the Binary Tree in post-order:");
                //Call the printPostOrder method to traverse in post-order
                printPostOrder(rootnode);
            }
            //Create a printInOrder method in the Binary Tree Class.
            public void printInOrder(Node node)
            {
                //If the node is not null,
                if (node != null)
                {
                    //Use recursion until you get to the leftmost node,
                    printInOrder(node.left); 
                    //Write which value is at this node,
                    Console.WriteLine(" Traversed " + node.value);
                    //Use recursion until you get to the rightmost node.
                    printInOrder(node.right);
                }
            }

            //Create a printPreOrder method in the Binary Tree Class.
            public void printPreOrder(Node rootNode)
            {
                if (rootNode != null)
                {
                    //Write which value is at this node,
                    Console.WriteLine("Traversed " + rootNode.value);
                    //Use recursion until you get to the leftmost node,
                    printPreOrder(rootNode.left);
                    //Use recursion until you get to the rightmost node.
                    printPreOrder(rootNode.right);
                }
            }

            //Create a printPostOrder method in the Binary Tree Class.
            public void printPostOrder(Node rootNode)
            {
                if (rootNode != null)
                {
                    //Use recursion until you get to the leftmost node,
                    printPostOrder(rootNode.left);
                    //Use recursion until you get to the rightmost node.
                    printPostOrder(rootNode.right);
                    //Write which value is at this node,
                    Console.WriteLine("Traversed " + rootNode.value);
                }
            }
        }
    }
}

