using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Køen
{
    class Program
    {
        static void Main(string[] args)
        {
            //<Summary>
            // Queues the guests
            Queue<Guest> guests = new Queue<Guest>();
            guests.Enqueue(new Guest() { Age = 25, Name = "John" });
            guests.Enqueue(new Guest() { Age = 24, Name = "Barbara" });
            guests.Enqueue(new Guest() { Age = 24, Name = "Phil" });
            guests.Enqueue(new Guest() { Age = 23, Name = "Fred" });
            guests.Enqueue(new Guest() { Age = 26, Name = "Hannah" });
            guests.Enqueue(new Guest() { Age = 27, Name = "Cindy" });
            Debug.WriteLine("Full guest list in the queue:");
            
           //<Summary>
           //Prints the guest name and age to the console
            foreach (Guest guest in guests)
            {
                Debug.WriteLine("{0}, {1}", guest.Name, guest.Age);
            }
            
                Debug.WriteLine("");
                Guest firstToLeave = guests.Dequeue();
                Debug.WriteLine(string.Format("First to leave: {0}", firstToLeave.Name));
                Debug.WriteLine("Guest list after the first goodbye:");

            
            foreach (Guest guest in guests)
            {
                Debug.WriteLine("{0}, {1}", guest.Name, guest.Age);
            }
                Guest soonToLeave = guests.Peek();
                Debug.WriteLine(string.Format("Just checking who'll leave next: {0}",
                soonToLeave.Name));

        }

    }
}