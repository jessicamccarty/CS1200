using System;

class DiceRoller
{
    static void Main()
    {
        // Create a Random object to generate random numbers
        Random random = new Random();
        // Create an array to hold the values of the 5 dice
        int[] dice = new int[5];
        // Set the number of rerolls the player has
        int rerollsRemaining = 2;

        // Roll the dice for the first time
        RollDice(dice, random);
        // Display the initial roll to the user
        DisplayDice(dice, true); // true means it's the initial roll

        // Allow the player to reroll dice up to 2 times
        while (rerollsRemaining > 0)
        {
            // Prompt the user to enter which dice they want to reroll
            Console.WriteLine($"Enter the dice numbers to reroll (comma-separated, ex: 2,3,5) or leave blank to keep current dice.");
            Console.WriteLine($"You have {rerollsRemaining} rerolls remaining): ");
            // Get user input from the console
            string input = Console.ReadLine();
            // Clear the console to make it look nice
            Console.Clear();

            // If the user didn't enter anything, break out of the loop
            if (string.IsNullOrWhiteSpace(input))
            {
                break;
            }

            // Split the input string by commas to get individual dice numbers
            string[] inputs = input.Split(',');
            // Loop through each input value
            foreach (string dieString in inputs)
            {
                // Try to convert the string to an integer
                if (int.TryParse(dieString.Trim(), out int dieNumber) && dieNumber >= 1 && dieNumber <= 5)
                {
                    // If valid, roll that specific die again
                    dice[dieNumber - 1] = random.Next(1, 7); // Roll a new number (1 to 6)
                }
            }

            // Decrease the number of rerolls remaining
            rerollsRemaining--;
            // Display the updated dice values
            DisplayDice(dice, false); // false means it's not the initial roll
        }

        // Calculate and show the final score after all rolls
        int score = CalculateScore(dice);
        Console.WriteLine($"Final Score: {score}");
    }

    // Method to roll all dice
    static void RollDice(int[] dice, Random random)
    {
        // Loop through the array and assign random values to each die
        for (int i = 0; i < dice.Length; i++)
        {
            dice[i] = random.Next(1, 7); // Roll a die (1 to 6)
        }
    }

    // Method to display the current dice values
    static void DisplayDice(int[] dice, bool isInitialRoll)
    {
        // Check if this is the initial roll
        if (isInitialRoll)
        {
            Console.WriteLine("Initial Roll:");
        }
        else
        {
            Console.WriteLine("Updated Rolls:");
        }

        // Loop through each die and print its value
        for (int i = 0; i < dice.Length; i++)
        {
            Console.WriteLine($"Die {i + 1}: {dice[i]}"); // Show each die
        }
        Console.WriteLine(); // Print a blank line for better readability
    }

    // Method to calculate the score based on the dice values
    static int CalculateScore(int[] dice)
    {
        int score = 0; // Start score at 0
        int[] counts = new int[7]; // Array to count occurrences of each die (index 0 is unused)

        // Loop through each die and calculate the score
        foreach (int die in dice)
        {
            score += die; // Add the die value to the score
            counts[die]++; // Increase the count for this die value
        }

        // Check how many of each die were rolled to add bonus points
        for (int i = 1; i <= 6; i++)
        {
            // Use a switch statement to check the count of each die value
            switch (counts[i])
            {
                case 2:
                    score += 10; // Add 10 points for two of the same value
                    break;
                case 3:
                    score += 15; // Add 15 points for three of the same value
                    break;
                case 4:
                    score += 25; // Add 25 points for four of the same value
                    break;
                case 5:
                    score += 30; // Add 30 points for five of the same value
                    break;
            }
        }

        return score; // Return the final score
    }
}
