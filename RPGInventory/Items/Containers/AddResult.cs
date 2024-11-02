namespace RPGInventory.Items.Containers
{
    // AddResult is an enumeration that represents the possible results
    // of trying to add an item to an inventory.
    public enum AddResult
    {
        Success,        // Item was added successfully
        ContainerFull,  // The container is full and cannot accept more items
        Overweight,     // Adding the item would exceed the weight limit
        WrongType       // The item type is not allowed in the inventory
    }
}
