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
    public partial class registreer : System.Web.UI.Page
    {
        Database database;
        protected void Page_Load(object sender, EventArgs e)
        {
            database = new Database();
        }

        protected void btnconfirm_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                database.register(Tbvoornaam.Text, Tbachternaam.Text, Tbgeboortedatum.Text, Tbgeslacht.Text, Tbemail.Text, Tbww.Text);
                Response.Redirect("mypathe.aspx");
            }            
        }
    }
}