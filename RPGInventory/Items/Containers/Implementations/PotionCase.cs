using RPGInventory.Items; // Ensure this namespace is included for ItemBase and AddResult

namespace RPGInventory.Items.Containers.Implementations
{
    // PotionCase inherits from TypeRestrictedInventory
    public class PotionCase : TypeRestrictedInventory
    {
        public PotionCase() : base(10, ItemType.Potion) // Set capacity to 10 and required type to Potion
        {
        }

        // Implementation of ListContents method to list the contents of the PotionCase
        public override void ListContents()
        {
            Console.WriteLine("Contents");
            Console.WriteLine("=================");

            foreach (var item in Items)
            {
                Console.WriteLine($"{item.ItemType,-10} | {item.Name,-20} | {item.Weight,5}kg | $ {item.Value,5}");
            }
        }

        // Implementation of RemoveItem to allow removal of an item from the PotionCase
        public override void RemoveItem(ItemBase item)
        {
            if (Items.Contains(item))
            {
                Items.Remove(item); // Remove the item from the inventory
                Console.WriteLine($"{item.Name} has been removed from the Potion Case.");
            }
            else
            {
                Console.WriteLine($"{item.Name} is not in the Potion Case.");
            }
        }
    }
}
