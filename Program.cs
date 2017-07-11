using System;
using System.Collections.Generic;

namespace tuples
{
    class Program
    {
        static void Main(string[] args)
        {
    List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>();

    transactions.Add(("hammer", 2.00, 1));
    transactions.Add(("nails", 3.50, 2));
    transactions.Add(("screwdriver", 1.75, 1));
    transactions.Add(("shovel", 5.50, 1));
    transactions.Add(("rake", 4.25, 1));

    int totalItems = 0;

    double totalSales = 0.0;

    foreach ((string product, double amount, int quanity) t in transactions)
            Console.WriteLine("Hello World!");
        }
    }
}
