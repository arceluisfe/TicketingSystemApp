using System;
using TicketSystemApp.Models;

Console.WriteLine("================================");
Console.WriteLine("   TICKET SYSTEM INITIALIZED   ");
Console.WriteLine("================================");

var newTicket = new Ticket 
{ 
    Id = 101, 
    Title = "Network Connectivity Issue", 
    Description = "User in El Coyol reporting slow speeds." 
};

Console.WriteLine($"Ticket ID: {newTicket.Id}");
Console.WriteLine($"Subject:   {newTicket.Title}");
Console.WriteLine($"Created:   {newTicket.CreatedAt}");
Console.WriteLine("================================");