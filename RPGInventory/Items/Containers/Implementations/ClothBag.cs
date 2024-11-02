using RPGInventory.Items; // Include the necessary namespace for ItemBase
using RPGInventory.Items.Containers; // Include the namespace for InventoryBase
using RPGInventory.Items.Containers.Implementations; // Include for implementing ClothBag

namespace RPGInventory.Items.Containers.Implementations
{
    public class ClothBag : WeightRestrictedInventory
    {
        // Constructor for ClothBag
        public ClothBag() : base(5, 5) // Initialize with capacity of 5 items and a max weight of 5
        {
        }

        // Override the ListContents method to display the contents of the bag
        public override void ListContents()
        {
            Console.WriteLine("Contents");
            Console.WriteLine("=================");
            foreach (var item in _items) // Access the _items list from the base class
            {
                Console.WriteLine($"{item.ItemType}\t| {item.Name}\t| {item.Weight}kg\t| $ {item.Value}");
            }
        }
    }
}
