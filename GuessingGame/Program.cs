// Program.cs

class Program
{
    static void Main(string[] args)
    {
        INumberGenerator numberGenerator = ConsoleIO.GetImplementationFromUser();
        
        // Check if numberGenerator is null
        if (numberGenerator == null)
        {
            Console.WriteLine("Error: Invalid number generator selected.");
            return;  // Exit the program or handle the error appropriately
        }

        GameManager gameManager = new GameManager(numberGenerator);
        gameManager.InitGame();
    }
}
