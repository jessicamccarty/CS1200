// Class Notes 

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



class Car {  // Name class to be called later. Can be in a separate file. Can be considered like a header file in C.  

    string color = "red"; // Attributes
    int speed = 200;

    public void fullThrottle() { // Behavior expected of class 
        if (speed == 200) {
            Console.WriteLine("This car is going as fast as it can!");
        }
    }

    static void Main(string[] args) { // Entry point of program. What actually runs. Can have multiple main functions but only 1 entry point.
        Car myObj = new Car();
        Console.WriteLine("myObj.color");
    }

}

