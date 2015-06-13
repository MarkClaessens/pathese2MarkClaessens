using System;
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
        protected void Page_Load(object sender, EventArgs e)
        {
            zoeker = new Zoekers();
            Session["zoeker"] = zoeker;
            using (DbConnection con = OracleClientFactory.Instance.CreateConnection())
            {
                if (con == null)
                {
                    //return "Error! No Connection";
                }
                con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectieStr"].ConnectionString;
                con.Open();
                DbCommand com = OracleClientFactory.Instance.CreateCommand();
                if (com == null)
                {
                    //return "Error! No Command";
                }
                com.Connection = con;
                com.CommandText = "SELECT FILMNAAM,GENRE,DUUR,REGISSEUR,TAAL,LINK FROM FILM";
                DbDataReader reader = com.ExecuteReader();
                try
                {
                    //dropdownmenu
                    
                    while (reader.Read())
                    {
                        zoeker.addfilm(reader.GetString(0).Trim(), reader.GetString(1).Trim(), reader.GetInt32(2), reader.GetString(3).Trim(), reader.GetString(4).Trim(), reader.GetString(5).Trim());
                    }
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
    }
}