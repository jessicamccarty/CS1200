using RPGInventory.Items; // Ensure this namespace is included for ItemBase

namespace RPGInventory.Items.Potions
{
    // Abstract class PotionBase that inherits from ItemBase
    public abstract class PotionBase : ItemBase
    {
        // Abstract method that derived classes must implement
        public abstract void Drink();
    }
}
