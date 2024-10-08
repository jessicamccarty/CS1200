﻿// Author: Jessica McCarty
// Date: October 7, 2024
// Description: Create a console application that prompts the user to provide the total purchase price of their item and the tax rate owed. The result should be output with the
// purchase price, tax rate %, amount of tax, and the total owed. 




// Enter the purchase price
using System.Threading.Tasks.Dataflow;

Console.Write("Enter the purchase price: ");
decimal purchasePrice = Convert.ToDecimal(Console.ReadLine());

// Enter the tax rate
Console.Write("Enter the tax rate: ");
decimal taxRate = Convert.ToDecimal(Console.ReadLine());

// Determine tax
decimal totalTax = purchasePrice * taxRate / 100;

// Determine total
decimal totalPrice = purchasePrice + totalTax;

// Output: For your $100 purchase, a 7.5% tax is $7.50 for a total of $107.50.
Console.Write($"For your ${purchasePrice:F2} purchase, a {taxRate}% tax is ${totalTax:F2} for a total of ${totalPrice:F2}.");