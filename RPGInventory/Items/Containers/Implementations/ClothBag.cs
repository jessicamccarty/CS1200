using RPGInventory.Items; // Ensure this namespace is included for ItemBase and AddResult

namespace RPGInventory.Items.Containers.Implementations
{
    // ClothBag inherits from WeightRestrictedInventory
    public class ClothBag : WeightRestrictedInventory
    {
        public ClothBag() : base(5, 5.0) // Set capacity to 5 and max weight to 5.0 kg
        {
        }

        // Implementation of ListContents method to list the contents of the ClothBag
        public override void ListContents()
        {
            Console.WriteLine("Contents");
            Console.WriteLine("=================");

            foreach (var item in Items)
            {
                Console.WriteLine($"{item.ItemType,-10} | {item.Name,-20} | {item.Weight,5}kg | $ {item.Value,5}");
            }
        }
    }
}
