// Implementations/ConsoleNumberGenerator.cs
using System;

public class ConsoleNumberGenerator : INumberGenerator
{
    public int Min { get; }
    public int Max { get; }

    public ConsoleNumberGenerator(int min, int max)
    {
        Min = min;
        Max = max;
    }

    public int GenerateNumber()
    {
        int guess;
        bool validInput = false;
        do
        {
            Console.WriteLine($"Please enter a number between {Min} and {Max}: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out guess) && guess >= Min && guess <= Max)
            {
                validInput = true;
            }
            else
            {
                Console.WriteLine($"Invalid input. Please enter a number between {Min} and {Max}.");
            }
        } while (!validInput);

        return guess;
    }
}
