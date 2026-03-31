using TicketingSystemApp.Models;
using System.Collections.Generic;

// This is our "Database" in memory
List<Ticket> ticketInbox = new List<Ticket>();
bool running = true;
int nextId = 101;

while (running)
{
    Console.Clear();
    Console.WriteLine("=== TICKET MANAGEMENT DASHBOARD ===");
    Console.WriteLine($"Current Tickets in System: {ticketInbox.Count}");
    Console.WriteLine("1. Create New Ticket");
    Console.WriteLine("2. View All Tickets");
    Console.WriteLine("3. Exit");
    Console.Write("\nSelect an option: ");

    string? choice = Console.ReadLine();

    if (choice == "1")
    {
        Console.Write("Enter Subject: ");
        string title = Console.ReadLine() ?? "No Title";
        
        Console.Write("Enter Description: ");
        string desc = Console.ReadLine() ?? "No Description";
        
        Console.Write("Priority (Low/Medium/High): ");
        string priority = Console.ReadLine() ?? "Low";

        ticketInbox.Add(new Ticket { 
            Id = nextId++, 
            Title = title, 
            Description = desc, 
            Priority = priority 
        });
        
        Console.WriteLine("\nTicket added! Press any key to return to menu...");
        Console.ReadKey();
    }
    else if (choice == "2")
    {
        Console.WriteLine("\n--- ALL ACTIVE TICKETS ---");
        foreach (var t in ticketInbox)
        {
            Console.WriteLine($"[{t.Priority.ToUpper()}] ID: {t.Id} - {t.Title}");
        }
        Console.WriteLine("--------------------------");
        Console.Write("Press any key to return...");
        Console.ReadKey();
    }
    else if (choice == "3")
    {
        running = false;
    }
}

Console.WriteLine("System Closed. Data cleared from memory.");