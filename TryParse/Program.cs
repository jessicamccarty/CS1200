// Code Along
// Scenarios: The user enters a valid number. The user enters a positive integer.
// Implement a do-while loop to prompt users until they satisfy the request. Inside the loop, prompt the user, read in a string value from the console, attempt to conver the value using
// TryParse(). If successful, perform any other checks and then break the loop. If unsuccessful, print and error message and let loop continue.

// Define Variables

string input;

int num;
double val;


// Add the loop and prompt

do {
    Console.Write("Enter a number: ");
    input = Console.ReadLine();

    // Attempt the conversaion
    if (double.TryParse(input, out val)) {

        break; // If conversion was successful, break out of loop.
    }

    Console.WriteLine("That was not a valid number!"); // Error will only print if the test condition is false (the conversion failed).

} while (true); // Test condition is true. This starts and infinite loop. Add a break statement to ensure we can exit the loop.

