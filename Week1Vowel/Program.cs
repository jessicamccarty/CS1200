
// Input and read character
Console.WriteLine("Please enter a letter: ");
string userInput = Console.ReadLine();


// Convert string to character
if (!string.IsNullOrEmpty(userInput))
{
    char userCharacter = userInput[0];

    // Switch
    switch (userCharacter) {
        case 'a':
        case 'A':
        case 'e':
        case 'E':
        case 'i':
        case 'I':
        case 'o':
        case 'O':
        case 'U':
        case 'u':
            Console.WriteLine("Vowel");
            break;
        case 'y':
        case 'Y':
            Console.WriteLine("Maybe");
            break;
        default:
            Console.WriteLine("Not a vowel");
            break;    
}
}