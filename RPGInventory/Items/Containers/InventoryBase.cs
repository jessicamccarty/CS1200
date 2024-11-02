using System.Collections.Generic;

namespace RPGInventory.Items.Containers
{
    // InventoryBase is an abstract class representing a container for items.
    // It defines the common properties and methods that all inventory types will implement.
    public abstract class InventoryBase
    {
        // The maximum number of items the inventory can hold
        public int Capacity { get; private set; }
        
        // List to store the items in the inventory
        protected List<ItemBase> Items;

        // Constructor to initialize the inventory with a given capacity
        protected InventoryBase(int capacity)
        {
            Capacity = capacity;
            Items = new List<ItemBase>();
        }

        // Abstract method to add an item to the inventory
        public abstract AddResult AddItem(ItemBase item);

        // Abstract method to remove an item from the inventory
        public abstract void RemoveItem(ItemBase item);

        // Abstract method to list the contents of the inventory
        public abstract void ListContents();
    }
}
