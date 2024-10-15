// Partners: Jessica McCarty and Remington

// Character Variables
int characterHP = 100;
int characterAttack = 20;
int characterDefense = 10;

// Enemy Variables
string[] enemyName = {"enemyOne", "enemyTwo", "enemyThree"};
int[] enemyHP = {30, 40, 50};
int[] enemyDefense = {5, 7, 10};
int[] enemyAttack = {10, 15, 20};

// Enemy Encounter Loop
int i = 0;

while (characterHP > 0 && enemyHP[i] > 0) {

    for (i = 0; i < 3; i++) {
        Console.WriteLine("You are walking across the planet and encounter an enemy...");

        while (enemyHP[i] > 0) {
            Console.WriteLine($"{enemyName[i]} with a health of {enemyHP[i]} has attacked you for {enemyAttack[i]}.");
            Console.WriteLine($"You defend against {enemyName[i]}'s attack for {characterDefense} leaving your health at {characterHP - enemyAttack[i] + characterDefense}.");
            Console.WriteLine($"Your counter attack against {enemyName[i]} for {characterAttack} was blocked for {enemyDefense[i]} leaving {enemyName[i]} with {enemyHP[i] - characterAttack + enemyDefense[i]} HP.");

        } Console.WriteLine($"{enemyName[i]} has been defeated.");

    }
}
