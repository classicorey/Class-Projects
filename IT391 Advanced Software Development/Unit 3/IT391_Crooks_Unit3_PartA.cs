using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assignment3A
{
    class myProgram
    {
        static void Main(string[] args)
        {
            //This section code is from the required example code as per the assigment instructions.
            //*********************************************************
            //****Assignment 3, Part A, Section 1
            //*********************************************************
            Console.WriteLine();
            Console.WriteLine("**********Section 1 **********");
            Console.WriteLine();

            String[] professions = new string[] { "Software Engineer", "Programmer", "Database Admin", "Network Admin", "Web Developer", "Program Manager" };

            HashSet<String> setprofessions = new HashSet<String>();
            try
            {
                for (int i = 0; i <= professions.GetUpperBound(0); i++)
                {
                    setprofessions.Add(professions[i]);
                }
                Console.WriteLine("Original List: ");
                Console.Write("[");
                for (int i = 0; i <= professions.GetUpperBound(0); i++)
                {
                    Console.Write(professions[i]);
                    if (i == professions.GetUpperBound(0))
                    {
                        Console.Write("]");
                    }
                    else
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Sorted List: ");
                SortedSet<String> sortedProfessions = new SortedSet<string>(setprofessions);
                Console.Write("[");
                int j = 0;
                foreach (string job in sortedProfessions)
                {
                    Console.Write(job);
                    if (j != sortedProfessions.Count() - 1)
                        Console.Write(", ");
                    j++;
                }
                Console.Write("]");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message.ToString());
            }


            //*********************************************************
            //****Assignment 3, Part A, Section 2
            //*********************************************************
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("**********Section 2 **********");
            Console.WriteLine();

            List<String> lstbooks = new List<String>();
            lstbooks.Add("To Kill a Mockingbird");
            lstbooks.Add("Huckleberry Finn");
            lstbooks.Add("Pride and Prejudice");
            lstbooks.Add("Brave New World");
            lstbooks.Add("Lord of the Flies");
            lstbooks.Add("Alice in Wonderland");
            lstbooks.Add("The Old Man and the Sea");
            lstbooks.Add("Atlas Shrugged");

            Console.WriteLine("Original Book List: ");
            DisplayList(lstbooks);
            Console.WriteLine();

            lstbooks.Sort(); //sort the list

            Console.WriteLine("Sorted Book List: ");
            DisplayList(lstbooks);
            Console.WriteLine();

            lstbooks.RemoveAt(1);//remove second item from list
            lstbooks.RemoveAt(0); //remove first item from list
            lstbooks.RemoveAt(lstbooks.Count() - 1);//remove last item from list

            Console.WriteLine("Book List After Deletions: ");
            DisplayList(lstbooks);
            Console.WriteLine();

            Console.Write("The number of items in my book list is: " + lstbooks.Count + "\n");
            Console.WriteLine();

            int index = lstbooks.IndexOf("Brave New World"); //look for this title
            if (index != -1)
            {
                Console.WriteLine("Brave New World is in the list.");
            }
            else
            {
                Console.WriteLine("Brave New World is not in the list.");
            }

            //*********************************************************
            //****Assignment 3, Part A, Section 3
            //*********************************************************
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("**********Section 3 **********");
            Console.WriteLine();

            //creates a new binary tree object which will initialize itself and print its contents

            new BinaryTree().create();

            Console.ReadKey();

        }

        static void DisplayList(List<String> lst)
        {
            Console.Write("[");
            for (int i = 0; i < lst.Count(); i++)
            {
                Console.Write(lst[i]);
                if (i != lst.Count() - 1)
                    Console.Write(", ");
            }
            Console.Write("]");
            Console.WriteLine();
        }
    }

    public class Node
    {
        public Node left;
        public Node right;
        public int value;
        public Node(int value)
        { this.value = value; }
    }

    public class BinaryTree
    {
        public void create()
        {
            Node rootnode = new Node(50);
            insert(rootnode, 30);
            insert(rootnode, 45);
            insert(rootnode, 12);
            insert(rootnode, 29);
            Console.WriteLine("The contents of the binary tree are: ");
            traverse(rootnode);
        }

        public void traverse(Node rootnode)
        {
            printInOrder(rootnode); // printInOrder uses recursion to traverse the tree
        }

        public void insert(Node node, int value)
        {
            if (value < node.value)
            {
                if (node.left != null)
                {
                    insert(node.left, value);
                }
                else
                {
                    //Console.WriteLine(" Inserted " + value + " to left of node " + node.value);
                    node.left = new Node(value);
                }
            }
            else if (value > node.value)
            {
                if (node.right != null) { insert(node.right, value); }
                else
                {
                    //Console.WriteLine(" Inserted " + value + " to right of node " + node.value);
                    node.right = new Node(value);
                }
            }
        }

        public void printInOrder(Node node)
        {
            if (node != null)
            {
                printInOrder(node.left); Console.WriteLine(" Traversed " + node.value);
                printInOrder(node.right);
            }
        }

    }
}

