using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace oim
{
    public class Gebruiker
    {
        public int gebruikerNR { get; set; }
        public string voornaam { get; set; }
        public string achternaam { get; set; }
        public string geslacht { get; set; }
        public string email { get; set; }
        public string wachtwoord { get; set; }

        public Gebruiker(int gebruikNr, string voornaam, string achternaam, string geslacht, string email, string wachtwoord)
        {
            this.gebruikerNR = gebruikNr;
            this.voornaam = voornaam;
            this.achternaam = achternaam;            
            this.geslacht = geslacht;
            this.email = email;
            this.wachtwoord = wachtwoord;
        }
    }
}