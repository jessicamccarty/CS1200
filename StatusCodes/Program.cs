// Author: Jessica McCarty
// Date: October 7, 2024
// Description: Prompt for specific HTTP response status code and print the category. 


using System.Net.Security;

class StatusCodes {
    static int Main(string[] args) {

        // User Input
        Console.Write("Enter a Response Code: ");
        int responseCode = Convert.ToInt32(Console.ReadLine());

        // If Else Statement
        if (responseCode == 100 || responseCode == 101 || responseCode == 102 || responseCode == 103) {
            // Informational Response
            Console.Write($"{responseCode} is an Informational Response.");
        } else if (responseCode >= 200 && responseCode <= 208 || responseCode == 226 || responseCode == 207) {
            // Successful Response
            Console.Write($"{responseCode} is a Successful Response.");
        } else if (responseCode >= 300 && responseCode <= 308 || responseCode == 305) {
            // Redirection Message
            Console.Write($"{responseCode} is a Redirection Response.");
        } else if (responseCode >= 400 && responseCode <= 418 || responseCode == 423 || responseCode == 424 || responseCode == 427 || responseCode == 421 || responseCode >= 421 && responseCode <= 429 || responseCode == 431 || responseCode == 451) {
            // Client Error Response
            Console.Write($"{responseCode} is a Client Error Response.");
        } else if (responseCode >= 500 && responseCode <= 508 || responseCode == 510 || responseCode == 511) {
            // Server Error
            Console.Write($"{responseCode} is a Server Error Response.");
        } else {
            // Invalid Response
            Console.Write($"{responseCode} is not a valid Response.");
        }

    return 0;

    }
}