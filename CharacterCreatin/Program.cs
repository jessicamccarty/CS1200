// Class: Soldier: 100 HP, 100 AR, 100 STR, Weapon, Ablity: Shoot 
// Class: Pilot: 50 HP, 50 AR, 50 STR, Ship, Ability: Fly
// Class: Engineer: 50 HP, 75 AR, 50 STR, Tablet, Ability: Decryption

// Input for Character Name
using System.Collections;

Console.WriteLine("Please enter your character's name: ");
char charName = Console.ReadLine();

// Menu for Class choice
Console.WriteLine("Please choose your class: ");
Console.WriteLine("1. Soldier");
Console.WriteLine("2. Pilot");
Console.WriteLine("3. Engineer");
int charClass = Convert.ToInt32(Console.ReadLine());

// Switch to read character class choice
Switch (charClass) {
    case '1':
        Console.Write("You have chosen the Soldier class.");
        // Initialize Soldier class attributes, inventory, and ability.
        break;
    case '2':
        Console.Write("You have chosen the Pilot class.");
        // Initialize Pilot class attributes, inventory, and ability.
        break;
    case '3':
        Console.Write("You have chosen the Engineer class.");
        // Initialize Engineer class attributes, inventory, and ability.
        break;
    default: 
        Console.WriteLine("Please choose a valid class.");
        break;
}

// Input for Home Planet
Console.WriteLine("Please enter your character's home planet: ");
char charPlanet = Console.ReadLine():

// Menu for Faction Choice
Console.WriteLine("Please choose the faction your character aligns with (light, dark): ");
char charFaction = Console.ReadLine();

// Input starting currency: 500 Lumees
int Lumees = 500;




