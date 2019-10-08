using System.Collections.Generic;

namespace TicketTracker.Models
{
    public class TicketSystem
    {
        List<Ticket> log { get; set; }

        public void PrintAll()
        {

        }
        public void ViewTicket(int index)
        {

        }
        public void NewTicket() { }
        public void CloseTicket() { }

        public TicketSystem()
        {
            log = new List<Ticket>();
        }
    }
}