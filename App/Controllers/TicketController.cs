using System;
using TicketTracker.Models;

namespace TicketTracker.Controllers
{
    public class TicketController
    {
        TicketSystem ticketSystem;
        Boolean active;
        public void Run()
        {
            ticketSystem = new TicketSystem();
            active = true;
            Console.Clear();
            Console.WriteLine(@"
___________.__        __           __ ___________                     __                 
\__    ___/|__| ____ |  | __ _____/  |\__    ___/___________    ____ |  | __ ___________ 
  |    |   |  |/ ___\|  |/ // __ \   __\|    |  \_  __ \__  \ _/ ___\|  |/ // __ \_  __ \
  |    |   |  \  \___|    <\  ___/|  |  |    |   |  | \// __ \\  \___|    <\  ___/|  | \/
  |____|   |__|\___  >__|_ \\___  >__|  |____|   |__|  (____  /\___  >__|_ \\___  >__|   
                   \/     \/    \/                          \/     \/     \/    \/       
            ");
            ticketSystem.PrintAll();
            while (active)
            {
                System.Console.WriteLine("What would you like to do? (view / new / quit)");
                string choice = Console.ReadLine();
                GetUserInput(choice);
            }
        }
        public void GetUserInput(string choice)
        {
            switch (choice.ToLower())
            {
                case "view":
                case "new":
                case "quit":
                    active = false;
                    break;
            }
        }
    }
}