// LockerManager.cs in Actions folder
using System;
using LockerRental.DTOs;

namespace LockerRental.Actions
{
    public class LockerManager
    {
        // This is the array that stores the locker content data
        private LockerContents[] _lockers = new LockerContents[100];

        // Uses ConsoleIO.DisplayLockerContents() to display contents of non-null elements
        public void ListContents()
        {
            for (int i = 0; i < _lockers.Length; i++)
            {
                ConsoleIO.DisplayLockerContents(_lockers[i], i + 1);
            }
        }

        // Uses ConsoleIO.DisplayLockerContents() to display contents if the locker is not null
        public void ViewLocker(int number)
        {
            if (number >= 1 && number <= 100)
            {
                ConsoleIO.DisplayLockerContents(_lockers[number - 1], number);
            }
        }

        // Checks if a locker is available (null). If available, it populates it.
        public void RentLocker(int number)
        {
            if (number >= 1 && number <= 100)
            {
                if (_lockers[number - 1] == null)
                {
                    LockerContents newContents = new LockerContents();
                    newContents.Description = ConsoleIO.GetRequiredString("Enter the item you want to store in the locker: ");
                    newContents.RenterName = ConsoleIO.GetRequiredString("Enter your full name: ");
                    _lockers[number - 1] = newContents;
                    Console.WriteLine($"Locker {number} has been rented for {newContents.Description} storage.");
                }
                else
                {
                    Console.WriteLine($"Sorry, but locker {number} has already been rented!");
                }
            }
        }

        // Prints a confirmation message and sets the element to null
        public void EndRental(int number)
        {
            if (number >= 1 && number <= 100)
            {
                if (_lockers[number - 1] != null)
                {
                    Console.WriteLine($"Locker {number} rental has ended, please take your { _lockers[number - 1].Description }.");
                    _lockers[number - 1] = null;
                }
                else
                {
                    Console.WriteLine($"Locker {number} is not currently rented.");
                }
            }
        }
    }
}
