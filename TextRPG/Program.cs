using System;

class Program
{
    static void Main()
    {
        // Create player character
        Player player = CreatePlayer();

        // Start an encounter
        Encounter(player);
    }

    static Player CreatePlayer()
    {
        Console.WriteLine("Welcome to the RPG! Let's create your character.");

        // Get player name
        Console.Write("Enter your character's name: ");
        string name = Console.ReadLine();

        PlayerClass chosenClass;
        while (true)
        {
            // Get player class
            Console.WriteLine("Choose a class: (1) Warrior, (2) Mage, (3) Rogue");
            int classChoice;

            // Validate input
            if (int.TryParse(Console.ReadLine(), out classChoice) && classChoice >= 1 && classChoice <= 3)
            {
                chosenClass = classChoice switch
                {
                    1 => PlayerClass.Warrior,
                    2 => PlayerClass.Mage,
                    3 => PlayerClass.Rogue,
                    _ => PlayerClass.Warrior, // Default (should not reach here)
                };
                break; // Valid class selected, exit loop
            }
            else
            {
                Console.WriteLine("Invalid choice. Please choose a valid class.");
            }
        }

        // Initialize player with currency and inventory
        return new Player(name, chosenClass);
    }

    static void Encounter(Player player)
    {
        Random random = new Random();
        Enemy[] enemies = {
            new GoblinRaider(),
            new ShadowSorcerer(),
            new StoneGuardian()
        };

        // Randomly select an enemy
        Enemy enemy = enemies[random.Next(enemies.Length)];
        Console.WriteLine($"You have encountered a {enemy.Name}!");

        // Start battle
        while (player.HitPoints > 0 && enemy.HitPoints > 0)
        {
            Console.WriteLine($"Your HP: {player.HitPoints}, Enemy HP: {enemy.HitPoints}");

            // Player's turn
            if (player.HitPoints < 100) // Only ask about potion if health is less than full
            {
                Console.Write("Do you want to use a health potion? (yes/no): ");
                string potionChoice = Console.ReadLine();

                if (potionChoice.ToLower() == "yes" && player.UsePotion())
                {
                    Console.WriteLine("You used a health potion!");
                }
            }

            // Enemy attacks
            enemy.Attack(player);
            if (player.HitPoints <= 0)
            {
                Console.WriteLine("You have been defeated!");
                player.Lumees -= 200;
                player.Respawn();
                Console.WriteLine($"You respawned with full health! Current Lumees: {player.Lumees}");
                return; // End encounter after respawn
            }

            // Player attacks
            player.Attack(enemy);
            if (enemy.HitPoints <= 0)
            {
                Console.WriteLine($"You have defeated the {enemy.Name}!");
                player.Lumees += 200;
                Console.WriteLine($"You received 200 Lumees! Current Lumees: {player.Lumees}");
            }
        }
    }
}

class Player
{
    public string Name { get; private set; }
    public PlayerClass Class { get; private set; }
    public int HitPoints { get; set; } = 100;
    public int Lumees { get; set; } = 500;
    private int potions = 2; // Initial potions
    public int Defense { get; private set; } // Defense rating

    public Player(string name, PlayerClass playerClass)
    {
        Name = name;
        Class = playerClass;
        Defense = playerClass switch // Assign defense based on class
        {
            PlayerClass.Warrior => 15,
            PlayerClass.Mage => 5,
            PlayerClass.Rogue => 10,
            _ => 0
        };
    }

    public int AttackPower => Class switch // Get attack power based on class
    {
        PlayerClass.Warrior => 25,
        PlayerClass.Mage => 40,
        PlayerClass.Rogue => 30,
        _ => 0
    };

    public bool UsePotion()
    {
        if (potions > 0)
        {
            HitPoints += 20; // Heal for 20 HP
            potions--;
            Console.WriteLine($"You now have {potions} potions left.");
            return true;
        }
        else
        {
            Console.WriteLine("You have no potions left!");
            return false;
        }
    }

    public void Respawn()
    {
        HitPoints = 100; // Full health on respawn
    }

    public void Attack(Enemy enemy)
    {
        Console.WriteLine($"{Name} attacks {enemy.Name} for {AttackPower} damage!");
        enemy.HitPoints -= AttackPower;
    }
}

abstract class Enemy
{
    public abstract string Name { get; }
    public int HitPoints { get; set; } = 100;

    public abstract void Attack(Player player);
}

class GoblinRaider : Enemy
{
    public override string Name => "Goblin Raider";
    public override void Attack(Player player)
    {
        int damage = 15; // Goblin Raider's attack damage
        int damageTaken = Math.Max(0, damage - player.Defense); // Calculate damage after defense
        Console.WriteLine($"{Name} attacks you for {damage} damage!");
        player.HitPoints -= damageTaken;
        Console.WriteLine($"You take {damageTaken} damage after accounting for defense. Your HP: {player.HitPoints}");
    }
}

class ShadowSorcerer : Enemy
{
    public override string Name => "Shadow Sorcerer";
    public override void Attack(Player player)
    {
        int damage = 20; // Sorcerer's attack damage
        int damageTaken = Math.Max(0, damage - player.Defense); // Calculate damage after defense
        Console.WriteLine($"{Name} casts a spell and deals {damage} damage!");
        player.HitPoints -= damageTaken;
        Console.WriteLine($"You take {damageTaken} damage after accounting for defense. Your HP: {player.HitPoints}");
    }
}

class StoneGuardian : Enemy
{
    public override string Name => "Stone Guardian";
    public override void Attack(Player player)
    {
        int damage = 25; // Guardian's attack damage
        int damageTaken = Math.Max(0, damage - player.Defense); // Calculate damage after defense
        Console.WriteLine($"{Name} slams the ground, dealing {damage} damage!");
        player.HitPoints -= damageTaken;
        Console.WriteLine($"You take {damageTaken} damage after accounting for defense. Your HP: {player.HitPoints}");
    }
}

enum PlayerClass
{
    Warrior,
    Mage,
    Rogue
}
