using RPGInventory.Items; // Ensure this namespace is included for ItemBase and AddResult

namespace RPGInventory.Items.Containers
{
    // WeightRestrictedInventory is an abstract class that inherits from InventoryBase.
    // It restricts the total weight of items that can be added to the inventory.
    public abstract class WeightRestrictedInventory : InventoryBase
    {
        // Protected fields to store current and maximum weights
        protected double _currentWeight;
        protected double _maxWeight;

        // Constructor that sets the capacity and maximum weight for the inventory
        protected WeightRestrictedInventory(int capacity, double maxWeight) 
            : base(capacity)
        {
            _maxWeight = maxWeight;
            _currentWeight = 0; // Initialize current weight to 0
        }

        // Override AddItem to enforce weight restrictions when adding an item
        public override AddResult AddItem(ItemBase item)
        {
            // Check if adding the new item exceeds the maximum weight
            if (_currentWeight + item.Weight > _maxWeight)
            {
                return AddResult.Overweight; // Return Overweight if adding exceeds the limit
            }

            // Add the item to the inventory without calling the abstract base method
            if (Items.Count >= Capacity)
            {
                return AddResult.ContainerFull; // Check for container full condition
            }

            Items.Add(item); // Add the item to the inventory
            _currentWeight += item.Weight; // Update current weight
            return AddResult.Success; // Indicate success
        }

        // Override RemoveItem to adjust current weight when removing an item
        public override void RemoveItem(ItemBase item)
        {
            if (Items.Contains(item))
            {
                Items.Remove(item); // Remove the item from the inventory
                _currentWeight -= item.Weight; // Decrease current weight
            }
        }
    }
}
