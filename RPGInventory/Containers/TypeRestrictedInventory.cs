// Containers/TypeRestrictedInventory.cs
public abstract class TypeRestrictedInventory : InventoryBase
{
    protected ItemType _requiredType;

    public TypeRestrictedInventory(int capacity, ItemType requiredType) : base(capacity)
    {
        _requiredType = requiredType;
    }

    public override AddResult AddItem(ItemBase item)
    {
        if (item.ItemType != _requiredType)
            return AddResult.WrongType;

        return base.AddItem(item);
    }
}
