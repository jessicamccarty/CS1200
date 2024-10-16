

class Program
{
    static void Main()
    {
        int startRow, endRow, startCol, endCol;

        // Get user input for rows
        Console.Write("Enter starting value for rows: ");
        while (!int.TryParse(Console.ReadLine(), out startRow))
        {
            Console.Write("Please enter a valid integer for starting rows: ");
        }

        Console.Write("Enter ending value for rows: ");
        while (!int.TryParse(Console.ReadLine(), out endRow))
        {
            Console.Write("Please enter a valid integer for ending rows: ");
        }

        // Get user input for columns
        Console.Write("Enter starting value for columns: ");
        while (!int.TryParse(Console.ReadLine(), out startCol))
        {
            Console.Write("Please enter a valid integer for starting columns: ");
        }

        Console.Write("Enter ending value for columns: ");
        while (!int.TryParse(Console.ReadLine(), out endCol))
        {
            Console.Write("Please enter a valid integer for ending columns: ");
        }

        // Print header
        Console.WriteLine();
        for (int col = startCol; col <= endCol; col++)
        {
            Console.Write($"\t{col}");
        }
        Console.WriteLine();
        Console.WriteLine(new string('=', 50));

        // Generate and print the multiplication table
        for (int row = startRow; row <= endRow; row++)
        {
            Console.Write($"{row}\t");
            for (int col = startCol; col <= endCol; col++)
            {
                Console.Write($"{row * col}\t");
            }
            Console.WriteLine();
        }
    }
}