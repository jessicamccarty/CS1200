// Author: Jessica McCarty
// Date: October 7, 2024
// Requirements: Prompt the user for the type of shape they want to use (rectangle, triangle, circle), then prompt them for the necessary values, calculate the area, and output
// the result. All values should be rounded to two decimal places and trailing zeros should be output. You will need the value for Pi, availabe in the Math type. You can use the 
// double type for all values. Use a switch statement as the primary conditional structure and display a message for invalid input.
// Math.Round() and Math.Pi





class AreaCalculator {

    static int Main(string[] args) {
        
        // User input for type of shape
        Console.Write("What type of shape (R)ectangle, (T)riangle, (C)ircle? ");
        char shape = Convert.ToChar(Console.ReadLine());

        // Switch to handle user input
        switch (shape) {
            case 'R':
            case 'r':
                // Rectangle Functions
                // For rectangle, user input for length
                Console.Write("Enter the length: ");
                double recLength = Convert.ToDouble(Console.ReadLine());
                // For rectangle, user input for width
                Console.Write("Enter the width: ");
                double recWidth = Convert.ToDouble(Console.ReadLine());
                // Function to find area of a rectangle and output
                // Length x Width
                double recArea = recLength * recWidth;
                Console.Write($"The area of this rectangle is {recArea:N2}.");
                break;
            case 'T':
            case 't':
                // Triangle Functions
                // For triangle, user input for base
                Console.Write("Enter the base: ");
                int triBase = Convert.ToInt32(Console.ReadLine());
                 // For triangle, user input for height
                Console.Write("Enter the height: ");
                int triHeight = Convert.ToInt32(Console.ReadLine());
                // Function to find area of a triangle and output
                // 1/2 x Base x Height
                double triArea = 0.5 * triBase * triHeight;
                Console.Write($"The area of this triangle is {triArea:N2}.");
                break;
            case 'C':
            case 'c':
                // Circle Functions
                // For circle, user input for radius
                Console.Write("Enter the radius: ");
                int cirRadius = Convert.ToInt32(Console.ReadLine());
                // Function to find area of a circle and output
                // pi x Radius Squared
                double cirArea = Math.PI * cirRadius * cirRadius;
                Console.Write($"The area of this circle is {cirArea:N2}.");
                break;
            default:
                Console.Write("Please enter a valid shape.");
                break;
        }     

    return 0;

    }
}