using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace oim
{
    public class Ticket
    {
        public int ticketNR { get; set; }
        public int gebruikerNR { get; set; }
        public int FilmNR { get; set; }

        public Ticket(int ticketNR, int gebruikerNR, int filmNR)
        {
            this.ticketNR = ticketNR;
            this.gebruikerNR = gebruikerNR;
            this.FilmNR = filmNR;
        }
        
    }
}