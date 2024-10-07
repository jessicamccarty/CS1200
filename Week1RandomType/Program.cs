Random rand = new Random();

// int randomNumber = rand.Next(1, 6);
// Console.WriteLine(randomNumber);

// Generate 2 random numbers
int dice1 = rand.Next(1,6);
int dice2 = rand.Next(1,6);
int sum = dice1 + dice2;

// If loop

if (dice1 == 1 && dice2 == 1) {
    Console.WriteLine($"You rolled {dice1}, {dice2}.\nSnake Eyes!");
} else if (dice1 == 6 && dice2 == 6) {
    Console.WriteLine($"You rolled {dice1}, {dice2}.\nBox Cars!");
} else {
    Console.WriteLine($"You rolled {dice1}, {dice2}.\n{sum}");
}

// if(randomNumber % 2 == 0) {
//     Console.WriteLine($"{randomNumber} is even.");
// } else {
//     Console.WriteLine($"{randomNumber} is odd.");
// }

