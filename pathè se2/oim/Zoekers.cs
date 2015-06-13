using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace oim
{
    public class Zoekers
    {
        List<Kijkfilm> filmlijst;

        public Zoekers()
        {
            filmlijst = new List<Kijkfilm>();
        }

        public void addfilm(string FILMNAAM,string GENRE,int DUUR,string REGISSEUR,string TAAL,string LINK)
        {
            Kijkfilm film = new Kijkfilm(FILMNAAM, GENRE, DUUR, REGISSEUR, TAAL, LINK);
            filmlijst.Add(film);
        }
        public Kijkfilm getfilm(string filmnaam)
        {
            foreach(Kijkfilm filmpje in filmlijst)
            {
                if(filmpje.FILMNAAM == filmnaam)
                {
                    return filmpje;
                }
            }

            return null;
        }

    }
}