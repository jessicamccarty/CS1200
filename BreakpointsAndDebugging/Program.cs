Console.Write("Enter a whole number: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine($"Factors of {number}");
Console.WriteLine("=================");

for (int i = 1; i <= number; i++)
{
    if (number % i == 0)
    {
        Console.WriteLine(i);
    }
}