using RPGInventory.Items; // Ensure this namespace is included for ItemBase and ItemType
using RPGInventory.Items.Potions; // Ensure this namespace is included for PotionBase

namespace RPGInventory.Items.Potions
{
    // Concrete class HealthPotion that inherits from PotionBase
    public class HealthPotion : PotionBase
    {
        // Constructor to set the properties of the health potion
        public HealthPotion()
        {
            ItemType = ItemType.Potion; // Set the item type to Potion
            Name = "Health Potion";      // Set the name of the potion
            Description = "Restores 50 health points."; // Description of the potion
            Weight = 1;                  // Weight of the potion
            Value = 10;                  // Value in currency
        }

        // Implementation of the Drink method
        public override void Drink()
        {
            Console.WriteLine("Glug, glug, glug! You feel better!"); // Effect of drinking the potion
        }
    }
}
