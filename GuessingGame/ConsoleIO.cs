// ConsoleIO.cs

public static class ConsoleIO  // 'public static' is fine here
{
    private static int _minGuess = 1;
    private static int _maxGuess = 20;

    public static int MinGuess => _minGuess;  // Public static property is allowed

    public static int MaxGuess => _maxGuess;  // Public static property is allowed

    // The methods that follow should be static as well
    public static INumberGenerator GetImplementationFromUser()
    {
        Console.WriteLine("Choose a number generator implementation:");
        Console.WriteLine("1. RandomNumberGenerator");
        Console.WriteLine("2. TestNumberGenerator (Always returns 7)");
        Console.WriteLine("3. ConsoleNumberGenerator (User input)");

        string choice = Console.ReadLine();

        INumberGenerator selectedGenerator = null;

        switch (choice)
        {
            case "1":
                selectedGenerator = GetRandomNumberGenerator();
                break;
            case "2":
                selectedGenerator = new TestNumberGenerator();
                break;
            case "3":
                selectedGenerator = GetConsoleInputNumberGenerator();
                break;
            default:
                Console.WriteLine("Invalid choice, defaulting to TestNumberGenerator.");
                selectedGenerator = new TestNumberGenerator();
                break;
        }

        SetMinMaxGuesses(selectedGenerator);  // Set the min/max for the chosen generator

        return selectedGenerator;  // Return the selected generator (will never be null)
    }

    // Add the other methods with 'public static' where necessary
    private static INumberGenerator GetRandomNumberGenerator()
    {
        PromptForMinimumNumber();
        PromptForMaximumNumber();
        return new RandomNumberGenerator(_minGuess, _maxGuess);
    }

    private static INumberGenerator GetConsoleInputNumberGenerator()
    {
        PromptForMinimumNumber();
        PromptForMaximumNumber();
        return new ConsoleNumberGenerator(_minGuess, _maxGuess);
    }

    private static void PromptForMinimumNumber()
    {
        Console.WriteLine("Enter the minimum guess value:");
        while (!int.TryParse(Console.ReadLine(), out _minGuess) || _minGuess < 1)
        {
            Console.WriteLine("Please enter a valid number greater than or equal to 1.");
        }
    }

    private static void PromptForMaximumNumber()
    {
        Console.WriteLine("Enter the maximum guess value:");
        while (!int.TryParse(Console.ReadLine(), out _maxGuess) || _maxGuess <= _minGuess)
        {
            Console.WriteLine($"Please enter a valid number greater than or equal to {_minGuess}.");
        }
    }

    // Set min and max values based on the generator selected
    private static void SetMinMaxGuesses(INumberGenerator numberGenerator)
    {
        if (numberGenerator is RandomNumberGenerator randomGen)
        {
            _minGuess = randomGen.Min;  // Access the Min property
            _maxGuess = randomGen.Max;  // Access the Max property
        }
        else if (numberGenerator is ConsoleNumberGenerator consoleGen)
        {
            _minGuess = consoleGen.Min;  // Access the Min property
            _maxGuess = consoleGen.Max;  // Access the Max property
        }
        else
        {
            _minGuess = 1;
            _maxGuess = 20;
        }
    }
}
