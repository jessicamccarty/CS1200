// Containers/InventoryBase.cs
public abstract class InventoryBase
{
    protected List<ItemBase> Items = new List<ItemBase>();

    public virtual void ListContents()
    {
        Console.WriteLine("Contents");
        Console.WriteLine("=================");
        foreach (var item in Items)
        {
            Console.WriteLine($"{item.ItemType} | {item.Name} | {item.Weight}kg | ${item.Value}");
        }
    }


public virtual AddResult AddItem(ItemBase item)
{
    if (Items.Count >= Capacity) return AddResult.ContainerFull;
    Items.Add(item);
    return AddResult.Success;
}

}
