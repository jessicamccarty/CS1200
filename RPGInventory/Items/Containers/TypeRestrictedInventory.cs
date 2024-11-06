using RPGInventory.Items; // Ensure this namespace is included for ItemBase and ItemType

namespace RPGInventory.Items.Containers
{
    // TypeRestrictedInventory is an abstract class that inherits from InventoryBase.
    // It restricts the types of items that can be added to the inventory based on a required type.
    public abstract class TypeRestrictedInventory : InventoryBase
    {
        // The required item type that this inventory will accept
        protected ItemType RequiredType;

        // Constructor that sets the capacity and required item type for the inventory
        protected TypeRestrictedInventory(int capacity, ItemType requiredType) 
            : base(capacity)
        {
            RequiredType = requiredType;
        }

        // Override AddItem to enforce type restrictions when adding an item
        public override AddResult AddItem(ItemBase item)
        {
            // Check if the item is of the required type
            if (item.ItemType != RequiredType)
            {
                return AddResult.WrongType; // Return WrongType if item is not allowed
            }

            // Check if the inventory is full before adding the item
            if (Items.Count >= Capacity)
            {
                return AddResult.ContainerFull; // Return ContainerFull if no space
            }

            // Add the item to the inventory
            Items.Add(item); // Directly add the item
            return AddResult.Success; // Return Success if the item is added
        }
    }
}
