using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace oim
{
    public class Kijkfilm
    {
        public string FILMNAAM { get; set; }
        public string GENRE { get; set; }
        public int DUUR { get; set; }
        public string REGISSEUR { get; set; }
        public string TAAL { get; set; }
        public string LINK { get; set; }

        public Kijkfilm(string filmnaam, string genre, int duur, string regisseur, string taal, string link)
        {
            this.FILMNAAM = filmnaam;
            this.GENRE = genre;
            this.DUUR = duur;
            this.REGISSEUR = regisseur;
            this.TAAL = taal;
            this.LINK = link;
        }

    }
}