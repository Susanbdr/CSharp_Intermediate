using System;
using System.Threading;

namespace CSharp_Intermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press enter to start the stopwatch");

            Console.ReadLine();
            
            var watch = new StopWatch();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Start: " + watch.Start().Millisecond);

                Thread.Sleep(2000);

                Console.WriteLine("Start: " + watch.Stop().Millisecond);

                Console.WriteLine("-----------");

                Console.WriteLine("Duration: " +watch.GetDuration().Milliseconds);

                Console.WriteLine("Press enter to start the stopwatch again");

                Console.ReadLine();
            }

          

        }
    }
}
