// Main

// Prompt user for name

using System.Reflection.Metadata;

static int userName() {
    Console.WriteLine("Please enter your name: ");
    string userName = Console.ReadLine();
}

// Prompt user for age

static void userAge() {
    Console.WriteLine("Please enter your age: ");
    int userAge = Convert.ToInt32(Console.ReadLine());
}

// Complete age verification

static void ageVerification() {
    if (userAge < 18) {
        Console.WriteLine($"{userName} is a minor.");
    } else if (userAge >= 65) {
        Console.WriteLine($"{userName} is a senior.");
    } else {
        Console.WriteLine("User is an adult.");
    }
}

// Allow user to create username if over the age of 18
// Convert user input to lowercase
// Do not allow them to create a username from an array containing blah, nope, why, idontthinkso, crazzzay, bop

static void uniqueUsername() {

string[] notAllowedNames = {"blah", "nope", "why", "idontthinkso", "crazzzay", "bop"};

    if (userAge > 18) {
        Console.WriteLine("Enter a unique username: ");
        string uniqueUsername = Console.ReadLine(); 
    } else {
        Console.WriteLine("You must be 18 or older to create an account.");
    }
}