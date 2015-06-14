using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace oim
{
    public class Kijkfilm : onderdeel
    {
        public int id { get; set; }
        public string GENRE { get; set; }
        public int DUUR { get; set; }
        public string REGISSEUR { get; set; }
        public string TAAL { get; set; }
       

        public Kijkfilm(int id, string filmnaam, string genre, int duur, string regisseur, string taal, string link) : base(filmnaam, link)
        {
            this.id = id;
            this.GENRE = genre;
            this.DUUR = duur;
            this.REGISSEUR = regisseur;
            this.TAAL = taal;            
        }

    }
}