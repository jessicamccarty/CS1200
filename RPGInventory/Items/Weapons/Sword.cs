using RPGInventory.Items; // Ensure this namespace is included for ItemBase and ItemType
using RPGInventory.Items.Weapons; // Ensure this namespace is included for WeaponBase

namespace RPGInventory.Items.Weapons
{
    // Concrete class Sword that inherits from WeaponBase
    public class Sword : WeaponBase
    {
        // Constructor to set the properties of the sword
        public Sword()
        {
            ItemType = ItemType.Weapon; // Set the item type to Weapon
            Damage = 5;                 // Set the damage of the sword
            Name = "Iron Sword";        // Set the name of the sword
            Description = "A standard iron sword."; // Description of the sword
            Weight = 4;                 // Weight of the sword
            Value = 100;                // Value in currency
        }
    }
}
