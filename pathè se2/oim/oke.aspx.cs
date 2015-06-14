﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Common;
using System.Configuration;
using Oracle.ManagedDataAccess.Client;

namespace oim
{
    public partial class oke : System.Web.UI.Page
    {
        Zoekers zoeker;
        bool ingelogd = false;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ingelogd"] == null)
            {
                Session["ingelogd"] = ingelogd;
            }            
            zoeker = new Zoekers();
            Session["zoeker"] = zoeker;
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
                        Session["moviecount"] = moviecount;
                }
                catch
                {

                }
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Session["filmnaam"] = "Jurrasic World";
            Response.Redirect("film.aspx");
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Session["filmnaam"] = "Spy";
            Response.Redirect("film.aspx");
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            Session["filmnaam"] = "Minions";
            Response.Redirect("film.aspx");
        }

        protected void Btnzoek_Click(object sender, EventArgs e)
        {
            using (DbConnection con = OracleClientFactory.Instance.CreateConnection())
            {

                con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectieStr"].ConnectionString;
                con.Open();
                DbCommand com = OracleClientFactory.Instance.CreateCommand();
                com.Connection = con;
                com.CommandText = "SELECT FILMNAAM, filmNR FROM FILM WHERE filmnaam like '%"+tbfilmnaam.Text+"%' AND rownum < 2";
                DbDataReader reader = com.ExecuteReader();
                try
                {
                    //dropdownmenu

                    while (reader.Read())
                    {

                        Tbcheckedfilm.Text = reader.GetString(0).Trim();
                        Btnkoop.Enabled = true;
                        Session["nummer"] = reader.GetInt32(1);
                    }

                }
                catch
                {

                }
            }
        }

        protected void Btnkoop_Click(object sender, EventArgs e)
        {
            if(Session["ingelogdaccount"] != null)
            {
                Gebruiker gebruiker = (Gebruiker)Session["ingelogdaccount"];
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
                    com.CommandText = "insert into ticket(ticketNR, gebruikerNR, filmNR) values(" + aantalticks + "," + gebruiker.gebruikerNR + "," + (int)Session["nummer"] + ")";
                    com.ExecuteNonQuery();
                }
            }
            else
            {
                Response.Redirect("mypathe.aspx");
            }
            
        }

        
        
    }
}