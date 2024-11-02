namespace RPGInventory.Items.Armors
{
    // LeatherArmor is a concrete class that inherits from ArmorBase.
    // It represents a specific type of armor with predefined properties.
    public class LeatherArmor : ArmorBase
    {
        // Constructor to set default values for LeatherArmor
        public LeatherArmor()
        {
            Name = "Leather Armor";
            Description = "A basic set of leather armor, offering modest protection.";
            Weight = 3;        // Weight in kilograms
            Value = 100;       // Value in currency units
            Defense = 5;       // Defense rating for the armor
        }
    }
}
