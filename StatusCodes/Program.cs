// Author: Jessica McCarty
// Date: October 7, 2024
// Description: Prompt for specific HTTP response status code and print the category. 

// User Input
using System.Net.Security;

Console.Write("Enter a Response Code: ");
int responseCode = Convert.ToInt32(Console.ReadLine());

// If Else Statement
if (responseCode >= 100 && responseCode <= 199) {
    // Informational Response
    Console.Write($"{responseCode} is an Informational Response.");
} else if (responseCode >= 200 && responseCode <= 299) {
    // Successful Response
    Console.Write($"{responseCode} is a Successful Response.");
} else if (responseCode >= 300 && responseCode <= 399) {
    // Redirection Message
    Console.Write($"{responseCode} is a Redirection Method.");
} else if (responseCode >= 400 && responseCode <= 499) {
    // Client Error Response
    Console.Write($"{responseCode} is a Client Error Response.");
} else if (responseCode >= 500 && responseCode <= 599) {
    // Server Error
    Console.Write($"{responseCode} is a Server Error Response.");
} else {
    // Invalid Response
    Console.Write($"{responseCode} is not a valid Response.");
}
