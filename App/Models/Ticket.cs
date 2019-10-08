using TicketTracker.Interfaces;

namespace TicketTracker.Models
{
    public class Ticket : ITicket
    {
        public string Title { get; private set; }
        public string Description { get; set; }

        public void PrintDescription() { }

        public Ticket(string title, string desc)
        {
            Title = title;
            Description = desc;
        }

    }
}