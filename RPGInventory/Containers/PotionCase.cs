// Containers/Implementations/PotionCase.cs
public class PotionCase : TypeRestrictedInventory
{
    public PotionCase(int capacity) : base(capacity, ItemType.Potion)
    {
    }
}
