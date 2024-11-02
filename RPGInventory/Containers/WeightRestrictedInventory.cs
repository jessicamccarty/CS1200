// Containers/WeightRestrictedInventory.cs
public abstract class WeightRestrictedInventory : InventoryBase
{
    protected double _currentWeight;
    protected double _maxWeight;

    public WeightRestrictedInventory(int capacity, double maxWeight) : base(capacity)
    {
        _maxWeight = maxWeight;
    }

    public override AddResult AddItem(ItemBase item)
    {
        if (_currentWeight + item.Weight > _maxWeight)
            return AddResult.Overweight;

        var result = base.AddItem(item);
        if (result == AddResult.Success)
            _currentWeight += item.Weight;

        return result;
    }

    public override void RemoveItem(ItemBase item)
    {
        if (Items.Remove(item))
            _currentWeight -= item.Weight;
    }
}
