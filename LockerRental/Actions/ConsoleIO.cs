// ConsoleIO.cs in Actions folder
using System;
using LockerRental.DTOs;

namespace LockerRental.Actions
{
    public static class ConsoleIO
    {
        // Prompts the user to enter a string value
        public static string GetRequiredString(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        // Displays the contents of a locker
        public static void DisplayLockerContents(LockerContents dto, int lockerNumber)
        {
            if (dto != null)
            {
                Console.WriteLine($"Locker {lockerNumber} contents: {dto.Description}.");
            }
            else
            {
                Console.WriteLine($"Locker {lockerNumber} is EMPTY.");
            }
        }

        // Prompts the user for a locker number (1-100)
        public static int GetLockerNumber()
        {
            int lockerNumber;
            do
            {
                lockerNumber = GetRequiredInt("Enter locker number (1-100): ");
            } while (lockerNumber < 1 || lockerNumber > 100);
            return lockerNumber;
        }

        // Displays the menu and prompts for a choice (1-5)
        public static int GetMenuOption()
        {
            Console.WriteLine("Locker Rental Menu");
            Console.WriteLine("=============================");
            Console.WriteLine("1. View a locker");
            Console.WriteLine("2. Rent a locker");
            Console.WriteLine("3. End a locker rental");
            Console.WriteLine("4. List all locker contents");
            Console.WriteLine("5. Quit");
            return GetRequiredInt("Enter your choice (1-5): ");
        }

        // Helper method to get an integer input from user
        private static int GetRequiredInt(string prompt)
        {
            int result;
            while (!int.TryParse(GetRequiredString(prompt), out result))
            {
                Console.WriteLine("Please enter a valid number.");
            }
            return result;
        }

        // Displays a "press any key to continue" message
        public static void AnyKey()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
