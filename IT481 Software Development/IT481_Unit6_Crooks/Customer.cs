using System;

namespace IT481_Unit6_CSharp
{
    //Create the custoemr class
    class Customer
    {
        //Create an int for children to inherrit to keep track of the number of items.
        int numberOfItems;

        //Create a customer method with no arguments, setting number of items to six.
        public Customer()
        {
            numberOfItems = 6;
        }
        
        //Overload the customer method.
        public Customer(int items)
        {

            int clothingItems = items;
            if (clothingItems == 0)
                numberOfItems = GetRandomNumber(1, 20);
            else
                numberOfItems = clothingItems;
        }

        //Return the number of items
        public int getNumberOfItems()
        {
            return numberOfItems;
        }

        //Random number methods
        private static readonly Random getrandom = new Random();
        public static int GetRandomNumber(int min, int max)
        {
            lock (getrandom)
            {
                return getrandom.Next(min, max);
            }
        }

    }
}
