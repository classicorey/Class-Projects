using System;

namespace Unit1Assignment
{
    //Provide specific name for the program to give individualization
    class Program
    {
        //Start computing
        static void Main(string[] args)
        {
            //Instantiate and declare variables and constants
            string name = "JohnSmith";
            string address = "101 N. Main Street";
            string city = "Anytown";
            string state = "TX";
            string zipCode = "11111";
            string unitsTaken = "19";
            const double pricePerUnit = 100.50;
            const double discount = 150;
            const int monthsInYear = 12;

            //Convert String to Int for unitsTaken
            int intUnitsTaken = Convert.ToInt32(unitsTaken);

            //Add a unit taken
            intUnitsTaken++;

            //Multiply unit price and units taken to get tuition cost
            double tuition = pricePerUnit * intUnitsTaken;

            //Subtract discount from tuition to get the price after discount
            double afterDiscount = tuition - discount;

            //Divide discounted tuition by 12 (months in year) to get monthly payment
            double monthlyPayment = afterDiscount / monthsInYear;

            //display outputs
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("City: " + city);
            Console.WriteLine("State: " + state);
            Console.WriteLine("ZipCode: " + zipCode);
            Console.WriteLine("The number of units taken is: " + intUnitsTaken);

            //format values as currency, and display properly
            Console.WriteLine(string.Format("The tuition before discount is {0:C}", tuition));
            Console.WriteLine(string.Format("The tuition after twenty-unit discount is {0:C}", afterDiscount));
            Console.WriteLine(string.Format("Your monthly payment is: {0:C}", monthlyPayment));

            //Let user view output
            Console.Read();
        }
    }
}