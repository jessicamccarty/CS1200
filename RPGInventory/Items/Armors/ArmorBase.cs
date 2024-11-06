namespace RPGInventory.Items.Armors
{
    // ArmorBase is an abstract class representing all armor items.
    // It inherits from ItemBase and includes a Defense property.
    public abstract class ArmorBase : ItemBase
    {
        // Defense property indicating the defensive strength of the armor
        public int Defense { get; set; }

        // Constructor for setting default values in derived classes
        protected ArmorBase()
        {
            ItemType = ItemType.Armor; // Setting default ItemType for Armor items
        }
    }
}
