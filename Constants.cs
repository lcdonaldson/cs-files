using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstantsDemo
{
    class Program
    {
        enum Ages
        {
            oldEnough = 5,
            canRide = 21,
            tooOld = 90
        }
        static void Main(string[] args)
        {
            const int age = 20;

            if ( age < (int)Ages.oldEnough)
            {
                Console.WriteLine("Sorry, you are not old enough to play");
            }
            else if (age < (int)Ages.canRide)
            {
                Console.WriteLine("You can play, but no riding");
            }
            else if (age < (int)Ages.tooOld) 
            {
                Console.WriteLine("Have fun!");
            }
            else
            {
                Console.WriteLine("How about a nice nap?");
            }
            // this is just for the console
            Console.ReadLine();
        }
    }
}
