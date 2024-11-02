// App.cs in Workflows folder
using LockerRental.Actions;

namespace LockerRental.Workflows
{
    public static class App
    {
        public static void Run()
        {
            LockerManager lockerManager = new LockerManager();

            while (true)
            {
                Console.Clear();
                int choice = ConsoleIO.GetMenuOption();

                if (choice == 5)
                {
                    return; // Quit
                }
                else if (choice == 4)
                {
                    lockerManager.ListContents(); // List all lockers
                }
                else
                {
                    int lockerNumber = ConsoleIO.GetLockerNumber();
                    if (choice == 1)
                    {
                        lockerManager.ViewLocker(lockerNumber); // View locker
                    }
                    else if (choice == 2)
                    {
                        lockerManager.RentLocker(lockerNumber); // Rent locker
                    }
                    else
                    {
                        lockerManager.EndRental(lockerNumber); // End rental
                    }
                }

                ConsoleIO.AnyKey(); // Pause for user
            }
        }
    }
}
