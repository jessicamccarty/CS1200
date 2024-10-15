// Class Assignment 

// Character Variables
        int characterHP = 100;
        int characterAttack = 20;
        int characterDefense = 10;

        // Enemy Variables
        string[] enemyName = { "enemyOne", "enemyTwo", "enemyThree" };
        int[] enemyHP = { 30, 40, 50 };
        Random random = new Random(); // Initialize random function for enemy attack and defense

        // Enemy Encounter Loop
        for (int i = 0; i < enemyName.Length; i++)
        {
            Console.WriteLine("You are walking across the planet and encounter an enemy...");

            while (characterHP > 0 && enemyHP[i] > 0)
            {
                // Randomize enemy's attack and defense for this turn
                int enemyAttack = random.Next(5, 21); // Random attack between 5 and 20
                int enemyDefense = random.Next(0, 11); // Random defense between 0 and 10

                Console.WriteLine($"{enemyName[i]} with a health of {enemyHP[i]} has attacked you for {enemyAttack}.");
                characterHP -= Math.Max(0, enemyAttack - characterDefense); // Ensure HP does not go negative
                Console.WriteLine($"You defend against {enemyName[i]}'s attack, leaving your health at {characterHP}.");

                // Check if character is defeated
                if (characterHP <= 0)
                {
                    Console.WriteLine("You have been defeated.");
                    return; // Exit the program if defeated
                }

                // Calculate enemy's counterattack
                enemyHP[i] -= Math.Max(0, characterAttack - enemyDefense); // Ensure HP does not go negative
                Console.WriteLine($"Your counter attack against {enemyName[i]} for {characterAttack} was blocked for {enemyDefense}, leaving {enemyName[i]} with {enemyHP[i]} HP.");

                // Check if enemy is defeated
                if (enemyHP[i] <= 0)
                {
                    Console.WriteLine($"{enemyName[i]} has been defeated.");
                    break; // Exit the loop if the enemy is defeated
                }
            }
        }
    
