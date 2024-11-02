public class HealthPotion : PotionBase
{
    public HealthPotion()
    {
        ItemType = ItemType.Potion;
        Name = "Health Potion";
        Description = "Restores health.";
        Weight = 1;
        Value = 10;
    }

    public override void Drink()
    {
        Console.WriteLine("You drink a health potion. You feel better.");
    }
}