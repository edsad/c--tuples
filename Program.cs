using System;
using System.Collections.Generic;

namespace tuples
{
    class Program
    {
        static void Main(string[] args)
        {
    List<(string product, float amount, int quantity)> transactions = new List<(string, float, int)>();

    transactions.Add(("hammer", 2.00f, 1));
    transactions.Add(("nails", 3.50f, 2));
    transactions.Add(("screwdriver", 1.75f, 1));
    transactions.Add(("shovel", 5.50f, 1));
    transactions.Add(("rake", 4.25f, 1));

    int totalItems = 0;

    float totalSales = 0.00f;

    foreach ((string product, float amount, int quantity) t in transactions){

    totalItems += t.quantity;
    totalSales += t.amount * (float) t.quantity;
    }

            Console.WriteLine($"Items Sold Today: {totalItems}");
            Console.WriteLine($"Total Revenue: {totalSales:C}");
        }
    }
}
