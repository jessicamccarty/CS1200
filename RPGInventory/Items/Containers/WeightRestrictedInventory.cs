using RPGInventory.Items; // Include the necessary namespace

namespace RPGInventory.Items.Containers
{
    public abstract class InventoryBase
    {
        protected int _capacity; // Maximum number of items in the inventory
        protected List<ItemBase> _items; // List to hold items

        // Constructor to initialize capacity and items list
        protected InventoryBase(int capacity)
        {
            _capacity = capacity;
            _items = new List<ItemBase>();
        }

        // Abstract method to add an item to the inventory
        public abstract AddResult AddItem(ItemBase item);

        // Abstract method to remove an item from the inventory
        public abstract AddResult RemoveItem(ItemBase item);

        // Abstract method to list contents of the inventory
        public abstract void ListContents();
    }
}
