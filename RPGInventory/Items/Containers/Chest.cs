using System;
using System.Collections.Generic;
using RPGInventory.Items; // Ensure this namespace is included for ItemBase and AddResult

namespace RPGInventory.Items.Containers
{
    // Chest is a concrete class that inherits from InventoryBase.
    // It represents a basic container for holding items.
    public class Chest : InventoryBase
    {
        // Constructor to set the capacity of the Chest
        public Chest(int capacity) : base(capacity)
        {
            // Initialize the items list
            Items = new List<ItemBase>();
        }

        // Override the AddItem method to provide custom behavior
        public override AddResult AddItem(ItemBase item)
        {
            // Check if the inventory is full
            if (Items.Count >= Capacity)
            {
                return AddResult.ContainerFull;
            }

            // Add the item to the inventory
            Items.Add(item);
            return AddResult.Success;
        }

        // Implement the RemoveItem method to remove an item from the inventory
        public override void RemoveItem(ItemBase item)
        {
            // Check if the item is in the inventory and remove it
            if (Items.Contains(item))
            {
                Items.Remove(item);
            }
        }

        // Override ListContents to display the contents of the chest
        public override void ListContents()
        {
            Console.WriteLine("Contents");
            Console.WriteLine("=================");

            foreach (var item in Items)
            {
                // Display item details (you can format this as needed)
                Console.WriteLine($"{item.ItemType,-10} | {item.Name,-20} | {item.Weight,5}kg | $ {item.Value,5}");
            }
        }
    }
}
