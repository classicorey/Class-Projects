using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace IT481_Unit6_CSharp
{
    class Scenario
    {
        static Customer customer;
        static int items = 0;
        static int numItems;
        static int controlItemNumber;

        static void Main(string[] args)
        {

            int numberOfCustomers = 0;
            bool validInput = false;
            //Set clothing per customer
            Console.Write("What ClothingItems value do you want to simulate? (input 0 for a random value between 1 and 20) ");
            while (validInput == false)
            {
                try
                {
                    controlItemNumber = Int32.Parse(Console.ReadLine());
                    validInput = true;
                }
                catch 
                {
                    Console.WriteLine("Please select a whole number.\nHow many clothing items per customer would you like? ");
                }
            }

            validInput = false;
            //Set the number of customers
            Console.Write("How many customers would you like to simulate? ");
            while (validInput == false)
            {
                try
                {
                    numberOfCustomers = Int32.Parse(Console.ReadLine());
                    validInput = true;
                }
                catch
                {
                    Console.WriteLine("Please select a whole number.\nHow many customers would you like to simulate in your store? ");
                }
            }
            validInput = false;

            Console.WriteLine("There are " + numberOfCustomers + " total customers");

            //Set the number of dressing rooms
            Console.Write("How many dressing rooms do you want to simulate? ");
            int maxRooms = Int32.Parse(Console.ReadLine());

            //Start the scenario for testing
            Scenario scenario = new Scenario(maxRooms, numberOfCustomers);

            //Create the dressing rooms object with number of rooms
            DressingRooms dressingRoom = new DressingRooms(maxRooms);

            List<Task> tasks = new List<Task>();

            //Loop through the customers and create threads
            for (int i = 0; i < numberOfCustomers; i++)
            {
                //Create the customer object
                customer = new Customer(controlItemNumber);

                //Get the number of items
                numItems = customer.getNumberOfItems();

                //Track total number of items
                items += numItems;

                //Start async request room
                tasks.Add(Task.Factory.StartNew(async () => { await dressingRoom.RequestRoom(customer); }));

            }

            Task.WaitAll(tasks.ToArray());

            //Inform the user of the statistics.
            Console.WriteLine($"Average Run time: {dressingRoom.getRunTime() / numberOfCustomers} milliseconds.");
            Console.WriteLine($"Average Wait time: {dressingRoom.getWaitTime() / numberOfCustomers} milliseconds.");
            int averageItemsPerCustomer = items / numberOfCustomers;
            Console.WriteLine($"There were {numberOfCustomers} total customers with an average number of {averageItemsPerCustomer} items on average.");
            //Keep the window open for the user to read the output.
            Console.Read();
        }

        //Create a method to introduce the number of dressing Rooms and Customers the user has selected.
        public Scenario(int dressingCount, int customerCount)
        {
            Console.WriteLine($"{dressingCount} dressing rooms for {customerCount} customers.");

            controlItemNumber = 0;
            numItems = 0;
        }

    }
}
