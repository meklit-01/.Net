
using System;
using System.Collections.Generic;

// Represents one customer's top-up information
public class TopUp
{
    public string CustomerName { get; set; } = "";
    public string Network { get; set; } = "";
    public decimal Amount { get; set; }
    public decimal Bonus { get; set; }
    public decimal Total { get; set; }
}

class Program
{
    static void Main()
    {
        // Create a list to store five customer top-ups
        List<TopUp> topUps = new List<TopUp>();

        // Collect information for five customers
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"\n========== Customer {i + 1} ==========");

            // Get customer name
            string name;

            while (true)
            {
                Console.Write("Enter customer name: ");
                name = Console.ReadLine()?.Trim() ?? "";

                if (!string.IsNullOrWhiteSpace(name))
                {
                    break;
                }

                Console.WriteLine("Name cannot be empty. Try again.");
            }

            // Get network name
            string network;

            while (true)
            {
                Console.Write("Enter network (Ethio Telecom / Safaricom): ");
                network = Console.ReadLine()?.Trim() ?? "";

                if (!string.IsNullOrWhiteSpace(network))
                {
                    break;
                }

                Console.WriteLine("Network cannot be empty. Try again.");
            }

            // Get and validate top-up amount
            decimal amount;

            while (true)
            {
                Console.Write("Enter top-up amount (ETB): ");

                string input = Console.ReadLine() ?? "";

                if (decimal.TryParse(input, out amount) &&
                    amount > 0m &&
                    amount <= 5000m)
                {
                    break;
                }

                Console.WriteLine(
                    "Invalid amount! Enter a number greater than 0 and not exceeding 5000 ETB."
                );
            }

            // Determine bonus rate using a switch expression
            decimal bonusRate = network.ToLowerInvariant() switch
            {
                "ethio telecom" => 0.05m,
                "safaricom" => 0.03m,
                _ => 0m
            };

            // Calculate network bonus
            decimal bonus = amount * bonusRate;

            // Add an extra 20 ETB for top-ups of 1000 ETB or more
            if (amount >= 1000m)
            {
                bonus += 20m;
            }

            // Calculate final top-up value
            decimal total = amount + bonus;

            // Create a customer object
            TopUp customer = new TopUp
            {
                CustomerName = name,
                Network = network,
                Amount = amount,
                Bonus = bonus,
                Total = total
            };

            // Add customer to the list
            topUps.Add(customer);

            Console.WriteLine("Customer top-up recorded successfully!");
        }

        // Display the final report
        Console.WriteLine("\n\n");
        Console.WriteLine("==============================================================");
        Console.WriteLine("                 TELEBIRR TOP-UP REPORT");
        Console.WriteLine("==============================================================");

        // Display table headings
        Console.WriteLine(
            $"{"Customer",-15} {"Network",-18} {"Amount",12} {"Bonus",12} {"Total",12}"
        );

        Console.WriteLine(new string('-', 72));

        // Calculate and display grand total
        decimal grandTotal = 0m;

        foreach (TopUp customer in topUps)
        {
            Console.WriteLine(
                $"{customer.CustomerName,-15} " +
                $"{customer.Network,-18} " +
                $"{customer.Amount,12:N2} " +
                $"{customer.Bonus,12:N2} " +
                $"{customer.Total,12:N2}"
            );

            grandTotal += customer.Total;
        }

        // Display grand total row
        Console.WriteLine(new string('-', 72));

        Console.WriteLine(
            $"{"GRAND TOTAL",-46} {grandTotal,23:N2}"
        );

        Console.WriteLine("==============================================================");

        Console.WriteLine("\nThank you for using TeleBirr Top-Up Calculator!");
    }
}
