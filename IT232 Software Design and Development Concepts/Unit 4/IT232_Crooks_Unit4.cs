using System;
using System.Collections.Generic;
using System.Collections;

namespace IT232_Unit_4_Assignment
{
    class IT232_Crooks_Unit4
    {
        //Create a new Car struct. Took me a LONG time to get this right cause I didn't know it had to be OUTSIDE main(). Silly me.
        struct newCar
        {
            //Specify the elements of the struct (make, model, and year)
            public string make;
            public string model;
            public int modelYear;
        }

        //Start the program
        static void Main(string[] args)
        {
            //*********************************************************

            //****Assignment 4 Section 1

            //*********************************************************

            //Inform the user we are in Section 1
            Console.WriteLine("Section 1: Array of Structures:");

            //Instance the newCar struct we specified earlier
            newCar[] cars = new newCar[3];


            //Add a 2010 Ford Mustang to the newCar struct
            cars[0] = new newCar();
            cars[0].make="Ford";
            cars[0].model="Mustang";
            cars[0].modelYear = 2010;

            //Add a 2008 Chevy Silverado to the newCar struct
            cars[1] = new newCar();
            cars[1].make="Chevrolet";
            cars[1].model="Silverado";
            cars[1].modelYear = 2008;

            //Add a 2012 Dodge Charger to the newCar struct
            cars[2] = new newCar();
            cars[2].make="Dodge";
            cars[2].model="Charger";
            cars[2].modelYear = 2012;
            
            //While there are still new cars in inventory,
            for (int i=0; i<cars.Length; i++)
            {
                //Print out the full information for the current car we're looking at
                Console.WriteLine(cars[i].make + " " + cars[i].model + " " + cars[i].modelYear);
            }

            //*********************************************************

            //****Assignment 4 Section 2

            //*********************************************************

            //Inform the user we're in section 2.
            Console.WriteLine("\nSection 2: Inventory Count:");

            //Create a new dictionary to hold how many of each car we have in inventory
            Dictionary<string, int> carsInInventory = new Dictionary<string, int>();

            //Add dictionary elements for 9 Mustangs, 13 Silverados, and 4 Chargers
            carsInInventory.Add("Mustang", 9);
            carsInInventory.Add("Silverado", 13);
            carsInInventory.Add("Charger", 4);

            //Inform the user how many of each car we have above
            Console.WriteLine("There's " + carsInInventory["Mustang"] + " Mustang(s) in inventory.");
            Console.WriteLine("There's " + carsInInventory["Silverado"] + " Silverado(s) in inventory.");
            Console.WriteLine("There's " + carsInInventory["Charger"] + " Charger(s) in inventory.");

            //*********************************************************

            //****Assignment 4 Section 3

            //*********************************************************

            //Inform the User we're on section 3
            Console.WriteLine("\nSection 3: Days of the Week:");

            //Add an array list for the days of the week
            ArrayList daysOfWeek = new ArrayList();

            //Add sunday through Saturday to the array list created above
            daysOfWeek.Add("Sunday");
            daysOfWeek.Add("Monday");
            daysOfWeek.Add("Tuesday");
            daysOfWeek.Add("Wednesday");
            daysOfWeek.Add("Thursday");
            daysOfWeek.Add("Friday");
            daysOfWeek.Add("Saturday");

            //While there are still unprinted days,
            for (int i=0; i<daysOfWeek.Count; i++)
            {
                //Write the name of the day we're currently looking at
                Console.WriteLine(daysOfWeek[i]);
            }

            //Inform the user we're going to print that in reverse
            Console.WriteLine("\nAnd the days of the week in reverse would be:");

            //While there are still unprinted days,
            for (int i = daysOfWeek.Count - 1; i >= 0; i--)
            {
                //Write the name of the day we're currently looking at
                Console.WriteLine(daysOfWeek[i]);
            }

            //Add a new array list to include the workable days, since workers apparently don't want to be in the office on the weekends. Silly workers
            ArrayList workingDays = new ArrayList();

            //Add the days of the week specified above to the working days
            workingDays.AddRange(daysOfWeek);

            //Remove saturday and sunday from the working days list
            workingDays.Remove("Saturday");
            workingDays.Remove("Sunday");

            //Inform the user we're going to print the working days
            Console.WriteLine("\nWork days:");

            //While we still need to print a day,
            for (int i=0; i< workingDays.Count; i++)
            {
                //Print the name of the day we're currently looking at
                Console.WriteLine(workingDays[i]);
            }

            //*********************************************************

            //****Assignment 4 Section 4

            //*********************************************************

            //Inform the user we're in section 4
            Console.WriteLine("\nSection 4: Stack:");

            //Create a new Stack element called newStack
            Stack<int> newStack = new Stack<int>();

            //Push 10, 24, 31, 45, 19, and 76 to the newStack element
            newStack.Push(10);
            newStack.Push(24);
            newStack.Push(31);
            newStack.Push(45);
            newStack.Push(19);
            newStack.Push(76);

            //Inform the user of how many items are on the stack
            Console.WriteLine("There's " + newStack.Count + " items on the stack.");

            //Pop 3 items from the stack
            newStack.Pop();
            newStack.Pop();
            newStack.Pop();

            //Inform the user of how many items are on the stack
            Console.WriteLine("There's " + newStack.Count + " items on the stack.");

            //Tell the user which item is going to be popped next
            Console.WriteLine("The next pop is: " + newStack.Peek() + ".");

            //*********************************************************

            //****Assignment 4 Section 4

            //*********************************************************

            //Inform the user we're in section 5
            Console.WriteLine("\nSection 5: Queue:");

            //Create a new Queue element named newQueue
            Queue<int> newQueue = new Queue<int>();

            //Queue up 10, 24, 31, 45, 19, and 76 to the newQueue element
            newQueue.Enqueue(10);
            newQueue.Enqueue(24);
            newQueue.Enqueue(31);
            newQueue.Enqueue(45);
            newQueue.Enqueue(19);
            newQueue.Enqueue(76);

            //Inform the user of how many items are in the queue
            Console.WriteLine("There's " + newQueue.Count + " items in queue.");

            //Dequeue three elements from the newQueue queue
            newQueue.Dequeue();
            newQueue.Dequeue();
            newQueue.Dequeue();

            //Inform the user of how many items are in the queue
            Console.WriteLine("There's " + newQueue.Count + " items in queue.");

            //Inform the user of the next item that will be dequeued
            Console.WriteLine("The next item to be dequeued is: " + newQueue.Peek() + ".");

            //Keep the console open for the user to read results
            Console.Read();
        }
    }
}
