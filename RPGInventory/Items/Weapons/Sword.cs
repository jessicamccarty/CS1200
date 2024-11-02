public class Sword : WeaponBase
{
    public Sword()
    {
        ItemType = ItemType.Weapon;
        Damage = 5;
        Name = "Iron Sword";
        Description = "A standard iron sword.";
        Weight = 4;
        Value = 100;
    }
}