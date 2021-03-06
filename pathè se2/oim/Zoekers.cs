﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace oim
{
    public class Zoekers
    {
        List<onderdeel> onderdelen;
        List<Gebruiker> gebruikers;
        //deze class zorgt ervoor dat alles op zijn plek gezet wordt en dat alles er weer uitgehaald wordt
             
        public Zoekers()
        {
            onderdelen = new List<onderdeel>();
            gebruikers = new List<Gebruiker>();
            
        }
        
        public void addfilm(int id, string FILMNAAM, string GENRE, int DUUR, string REGISSEUR, string TAAL, string LINK)
        {        
            //maakt een film aan en voegt die toe aan de lijst met films en bioscopen
                onderdeel film = new Kijkfilm(id, FILMNAAM, GENRE, DUUR, REGISSEUR, TAAL, LINK);
                onderdelen.Add(film);
        }
        public void addbioscoop(string bioscoopnaam, string description, string path)
        {
            //maakt een bioscoop aan en voegt die toe aan de lijst met films en bioscopen
            Bioscoop bioscoop = new Bioscoop(bioscoopnaam, description, path);
            onderdelen.Add(bioscoop);
        }
        public void addgebruiker(int gebruikNr, string voornaam, string achternaam, string geslacht, string email, string wachtwoord)
        {
            //maakt een gebruiker aan en voegt die toe aan de lijst met gebruikers
            Gebruiker gebruiker = new Gebruiker(gebruikNr, voornaam, achternaam, geslacht, email, wachtwoord);
            gebruikers.Add(gebruiker);
            
        }
        public Kijkfilm getfilm(string filmnaam)
        {
            //zoekt een film met de naam die gelijk is aan de mee gegeven string
            foreach (onderdeel onderdeeltje in onderdelen)
            {
                if (onderdeeltje is Kijkfilm)
                {
                    if (onderdeeltje.naam == filmnaam)
                    {
                        return (Kijkfilm)onderdeeltje;
                    }
                }
            }

            return null;
        }
        public Bioscoop getbioscoop(string bioscoopnaam)
        {
            //zoekt een bioscoop met de naam die gelijk is aan de mee gegeven string
            foreach (onderdeel onderdeeltje in onderdelen)
            {
                if (onderdeeltje is Bioscoop)
                {
                    if (onderdeeltje.naam == bioscoopnaam)
                    {
                        return (Bioscoop)onderdeeltje;
                    }

                }

                
            }
            return null;
        }
        public Gebruiker login(string email, string ww)
        {
            //zoekt een gebruiker met de naam die gelijk is aan de mee gegeven string
            foreach (Gebruiker gebruker in gebruikers)
            {
                if(gebruker.email == email && gebruker.wachtwoord == ww)
                {
                    return gebruker;
                }
            }
            return null;
        }
    }
}