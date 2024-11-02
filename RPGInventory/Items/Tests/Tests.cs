using System;
using RPGInventory.Items;
using RPGInventory.Items.Armors;
using RPGInventory.Items.Potions;
using RPGInventory.Items.Weapons;
using RPGInventory.Items.Containers;
using RPGInventory.Items.Containers.Implementations;
using System.Collections.Generic;

namespace RPGInventory.Tests
{
    public class Tests
    {
        public static void Main()
        {
            Test_AddItemToChest();
            Test_ListContents();
            Test_AddOverweightItemToClothBag();
            Test_AddWrongTypeItemToPotionCase();
            Test_HealthPotionDrinkMethod();
            Console.WriteLine("All tests completed.");
        }

        public static void Test_AddItemToChest()
        {
            Console.WriteLine("Running Test_AddItemToChest...");

            Chest chest = new Chest(capacity: 10);
            Sword sword = new Sword();

            var result = chest.AddItem(sword);
            Console.WriteLine(result == AddResult.Success ? "Passed" : "Failed");
        }

        public static void Test_ListContents()
        {
            Console.WriteLine("Running Test_ListContents...");

            Chest chest = new Chest(capacity: 10);
            LeatherArmor armor = new LeatherArmor();
            HealthPotion potion = new HealthPotion();

            chest.AddItem(armor);
            chest.AddItem(potion);

            Console.WriteLine("Expected Output:");
            Console.WriteLine("Contents");
            Console.WriteLine("=================");
            Console.WriteLine("Armor      | Leather Armor        |     3kg | $  100");
            Console.WriteLine("Potion     | Health Potion        |     1kg | $   10");

            Console.WriteLine("Actual Output:");
            chest.ListContents();
            Console.WriteLine("ListContents test completed. Manually verify output.");
        }

        public static void Test_AddOverweightItemToClothBag()
        {
            Console.WriteLine("Running Test_AddOverweightItemToClothBag...");

            ClothBag clothBag = new ClothBag(capacity: 5);
            LeatherArmor armor = new LeatherArmor();
            HealthPotion potion = new HealthPotion();

            var result1 = clothBag.AddItem(armor); // 3 kg
            var result2 = clothBag.AddItem(potion); // +1 kg, total 4 kg
            var result3 = clothBag.AddItem(armor); // Another 3 kg, should exceed 5 kg limit

            Console.WriteLine(result1 == AddResult.Success ? "Passed" : "Failed");
            Console.WriteLine(result2 == AddResult.Success ? "Passed" : "Failed");
            Console.WriteLine(result3 == AddResult.Overweight ? "Passed" : "Failed");
        }

        public static void Test_AddWrongTypeItemToPotionCase()
        {
            Console.WriteLine("Running Test_AddWrongTypeItemToPotionCase...");

            PotionCase potionCase = new PotionCase(capacity: 3);
            Sword sword = new Sword();
            HealthPotion potion = new HealthPotion();

            var result1 = potionCase.AddItem(potion); // Should succeed
            var result2 = potionCase.AddItem(sword);  // Should fail due to type restriction

            Console.WriteLine(result1 == AddResult.Success ? "Passed" : "Failed");
            Console.WriteLine(result2 == AddResult.WrongType ? "Passed" : "Failed");
        }

        public static void Test_HealthPotionDrinkMethod()
        {
            Console.WriteLine("Running Test_HealthPotionDrinkMethod...");

            HealthPotion potion = new HealthPotion();
            Console.WriteLine("Expected Output: Glug, glug, glug! You feel better!");
            Console.WriteLine("Actual Output:");
            potion.Drink();
            Console.WriteLine("Drink method test completed. Manually verify output.");
        }
    }
}
