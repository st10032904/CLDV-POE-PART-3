using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace POEPART3
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["POE"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs)) { 
                SqlDataAdapter sda = new SqlDataAdapter("select count (*) from login where username ='" + txtUsername.Text + "'and Password ='" + txtPassword.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Dispose();
                Response.Redirect("Main.aspx");
            }
            else
            {
                lblComplete.Text = "Please check your login details";
            }
            }
        }
    }
}