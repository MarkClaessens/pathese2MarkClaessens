using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Common;
using System.Configuration;
using Oracle.ManagedDataAccess.Client;

namespace oim
{
    public class Database
    {
        Zoekers zoeker;
        int nummer = -1;
        public Database()
        {
            zoeker = new Zoekers();
        }
        public void loadfilms()
        {
            using (DbConnection con = OracleClientFactory.Instance.CreateConnection())
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectieStr"].ConnectionString;
                con.Open();
                DbCommand com = OracleClientFactory.Instance.CreateCommand();
                com.Connection = con;
                com.CommandText = "SELECT * FROM FILM";
                DbDataReader reader = com.ExecuteReader();
                try
                {
                    //dropdownmenu

                    while (reader.Read())
                    {
                        zoeker.addfilm(reader.GetInt32(0), reader.GetString(1).Trim(), reader.GetString(2).Trim(), reader.GetInt32(3), reader.GetString(4).Trim(), reader.GetString(5).Trim(), reader.GetString(6).Trim());
                    }

                }
                catch
                {
                    
                }
            }
        }
        public void loadbioscopen()
        {
            using (DbConnection con = OracleClientFactory.Instance.CreateConnection())
            {

                DbCommand comp = OracleClientFactory.Instance.CreateCommand();
                comp.Connection = con;
                comp.CommandText = "SELECT * FROM bioscoop";
                DbDataReader rd = comp.ExecuteReader();
                try
                {
                    //dropdownmenu

                    while (rd.Read())
                    {
                        zoeker.addbioscoop(rd.GetString(0).Trim(), rd.GetString(1).Trim(), rd.GetString(2).Trim());
                    }
                }
                catch
                {

                }
            }
        }
        public int loadgebruikers()
        {
            using (DbConnection con = OracleClientFactory.Instance.CreateConnection())
            {
                DbCommand comm = OracleClientFactory.Instance.CreateCommand();
                comm.Connection = con;
                comm.CommandText = "SELECT * FROM gebruiker";
                DbDataReader read = comm.ExecuteReader();
                try
                {
                    //dropdownmenu
                    int moviecount = 1;
                    while (read.Read())
                    {
                        moviecount++;
                        zoeker.addgebruiker(read.GetInt32(0), read.GetString(1).Trim(), read.GetString(2).Trim(), read.GetString(4).Trim(), read.GetString(5).Trim(), read.GetString(6).Trim());
                    }                    
                    return moviecount;
                }
                catch
                {

                }
            }
            return -1;
        }
        public void koopticketsnel(Gebruiker gebruiker)
        {
            using (DbConnection con = OracleClientFactory.Instance.CreateConnection())
            {
                try
                {
                    int aantalticks = -1; ;
                    con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectieStr"].ConnectionString;
                    con.Open();
                    DbCommand comm = OracleClientFactory.Instance.CreateCommand();
                    comm.Connection = con;
                    comm.CommandText = "SELECT COUNT(*) from TICKET";
                    DbDataReader reader = comm.ExecuteReader();
                    while (reader.Read())
                    {
                        aantalticks = reader.GetInt32(0) + 1;
                    }
                    DbCommand com = OracleClientFactory.Instance.CreateCommand();
                    com.Connection = con;
                    com.CommandText = "insert into ticket(ticketNR, gebruikerNR, filmNR) values(" + aantalticks + "," + gebruiker.gebruikerNR + "," + nummer+ ")";
                    com.ExecuteNonQuery();
                }
                catch
                {
                    
                }

            }
        }
        public string getfilmsnel(string filmnaam)
        {
            using (DbConnection con = OracleClientFactory.Instance.CreateConnection())
            {

                con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectieStr"].ConnectionString;
                con.Open();
                DbCommand com = OracleClientFactory.Instance.CreateCommand();
                com.Connection = con;
                com.CommandText = "SELECT FILMNAAM, filmNR FROM FILM WHERE filmnaam like '%" + filmnaam + "%' AND rownum < 2";
                DbDataReader reader = com.ExecuteReader();
                try
                {
                    //dropdownmenu

                    while (reader.Read())
                    {
                                               
                        nummer = reader.GetInt32(1);
                        return reader.GetString(0).Trim();
                    }

                }
                catch
                {
                    
                }
                return null;
            }
        }
        public void koopticketbijfilm(Gebruiker gebruiker, Kijkfilm film)
        {
            try
            {
                using (DbConnection con = OracleClientFactory.Instance.CreateConnection())
                {

                    int aantalticks = -1; ;
                    con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectieStr"].ConnectionString;
                    con.Open();
                    DbCommand comm = OracleClientFactory.Instance.CreateCommand();
                    comm.Connection = con;
                    comm.CommandText = "SELECT COUNT(*) from TICKET";
                    DbDataReader reader = comm.ExecuteReader();
                    while (reader.Read())
                    {
                        aantalticks = reader.GetInt32(0) + 1;
                    }
                    DbCommand com = OracleClientFactory.Instance.CreateCommand();
                    com.Connection = con;
                    com.CommandText = "insert into ticket(ticketNR, gebruikerNR, filmNR) values(" + aantalticks + "," + gebruiker.gebruikerNR + "," + film.id + ")";
                    com.ExecuteNonQuery();
                }
            }
            catch
            {
                
            }
        }
        public List<Kijkfilm> haalfilmsop(Gebruiker gebruker)
        {
            List<Kijkfilm> filmsgebruiker = new List<Kijkfilm>();
            using (DbConnection con = OracleClientFactory.Instance.CreateConnection())
            {                
                con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectieStr"].ConnectionString;
                con.Open();
                DbCommand com = OracleClientFactory.Instance.CreateCommand();
                com.Connection = con;
                com.CommandText = "SELECT f.FILMNAAM from TICKET t, FILM f WHERE t.FILMNR = f.FILMNR AND GEBRUIKERNR = " + gebruker.gebruikerNR;
                DbDataReader reader = com.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        Kijkfilm film = zoeker.getfilm(reader.GetString(0).Trim());
                        filmsgebruiker.Add(film);
                    }
                    return filmsgebruiker;
                }
                catch
                {
                    
                }

            }
            return null;
        }
        public void register(string voornaam, string achternaam, string geboortedatum, string geslacht, string email, string ww)
        {
            try
            {
                //maakt met de gegevens die je invoert een account aan in de database
                using (DbConnection con = OracleClientFactory.Instance.CreateConnection())
                {                    
                    con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectieStr"].ConnectionString;
                    con.Open();
                    DbCommand com = OracleClientFactory.Instance.CreateCommand();
                    com.Connection = con;
                    com.CommandText = "insert into gebruiker values(" + nummer + ",'" + voornaam + "','" + achternaam + "','" + geboortedatum + "','" + geslacht + "','" + email + "','" + ww + "')";
                    com.ExecuteNonQuery();                        
                    zoeker.addgebruiker(nummer, voornaam, achternaam, geslacht, email, ww);                       
                }
            }
            catch
            {
                
            }
        }
    }
}