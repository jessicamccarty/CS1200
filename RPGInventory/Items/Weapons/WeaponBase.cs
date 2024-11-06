using RPGInventory.Items; // Ensure this namespace is included for ItemBase

namespace RPGInventory.Items.Weapons
{
    // Abstract class WeaponBase that inherits from ItemBase
    public abstract class WeaponBase : ItemBase
    {
        // Property to hold the damage value of the weapon
        public int Damage { get; set; }
    }
}
