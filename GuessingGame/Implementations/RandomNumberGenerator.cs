// Implementations/RandomNumberGenerator.cs
using System;

public class RandomNumberGenerator : INumberGenerator
{
    public int Min { get; }
    public int Max { get; }

    private readonly Random _random;

    public RandomNumberGenerator(int min, int max)
    {
        Min = min;
        Max = max;
        _random = new Random();
    }

    public int GenerateNumber()
    {
        return _random.Next(Min, Max + 1);  // Random number between Min and Max (inclusive)
    }
}
