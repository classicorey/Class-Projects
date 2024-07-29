using System;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace IT481_Unit6_CSharp
{
    //Create a dressing rooms class.
    class DressingRooms
    {
        //Keep track of the rooms, waiting timer, run timer, and our semaphore object.
        int rooms;
        Semaphore semaphore;
        long waitTimer;
        long runTimer;

        //Create a dressingRooms method with no arguments.
        public DressingRooms()
        {
            rooms = 3;
            semaphore = new Semaphore(rooms, rooms);
        }

        //Overload the dressingrooms object
        public DressingRooms(int room)
        {

            rooms = room;
            //Set the semaphore object
            semaphore = new Semaphore(rooms, rooms);

        }

        //create a taks method RequestRoom
        public async Task RequestRoom(Customer customer)
        {
            Stopwatch stopWatch = new Stopwatch();
            //Waiting thread
            Console.WriteLine("Customer is waiting");

            //Start the timer
            stopWatch.Start();
            semaphore.WaitOne();
            //Stop the wait timer
            stopWatch.Stop();
            //Get the time elapsed for waiting
            waitTimer += stopWatch.ElapsedTicks;

            int roomWaitTime = GetRandomNumber(1, 3);
            //Start the timer
            stopWatch.Start();
            Thread.Sleep((roomWaitTime * customer.getNumberOfItems()));
            //Stop the wait timer
            stopWatch.Stop();
            //Get the elapsed run time
            runTimer += stopWatch.ElapsedTicks;

            Console.WriteLine("Customer finished trying on items in room");
            semaphore.Release();
        }

        //Create a get wait timer method to return the timer
        public long getWaitTime()
        {
            return waitTimer;
        }

        //Create a get run timer method to get the run timer
        public long getRunTime()
        {
            return runTimer;
        }


        //Create a new random object,
        private static readonly Random getrandom = new Random();
        //and use it to generate a random number.
        public static int GetRandomNumber(int min, int max)
        {
            lock (getrandom)
            {
                return getrandom.Next(min, max);
            }
        }
    }
}
