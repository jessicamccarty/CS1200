// Class Notes 
// Date: October 8, 2024

// Console.WriteLine("Hello, World!");

// int a = 10;
// int b = 20;
// Console.WriteLine(a+b);

// Nicole wants our code to look like this.
class Hello {
// Main method
    static void Main(string[] args)
    {
        // Output Hello, World!
        Console.WriteLine("Hello,World!");
    }
}


// Clean user input before using in code. 
// Ex. Convert to uppercase or lowercase before switch statement.


// STRINGS, ARRAYS, LOOPS 10/15/2024
// learn.microsoft.com

string name = "alice";
Console.WriteLine(name);
name.ToUpper();
Console.WriteLine(name); // Will print original string

string capName = name.ToUpper(); // Give strring it's own variable name
Console.WriteLine(capName);  // Show modified strring variable


// This prints Hello. It assigned str1 as str2. We made a modification but never gave it a name to print. 
string str1 = "Hello";
string str2 = str1;
str1 += "World";
Console.WriteLine(str2);

// This is how you would appropriately concatenate the strings.
string str1 = "A string is more";
string str2 = "than the sum of its chars.";
str1 += str2; // The original str1 is now str1 with str2 concatenated.
Console.WriteLine(s1);














// Array of names
string[] names = { "Alice", "Bob", "Charlie", "David", "Eve"}

