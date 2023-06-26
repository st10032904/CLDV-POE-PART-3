using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;



namespace POEPART3
{
    public partial class Main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /*{
            if (!IsPostBack)
            {
                GVbind();
            }
        }
        protected void GVbind()
        {
            string cs = ConfigurationManager.ConnectionStrings["POE"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from Vehicle", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    GridView1.DataSource = dr;
                    GridView1.DataBind();
                }
            }
        }
        */
        protected void Button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Response.Redirect("Cars.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Response.Redirect("Drivers.aspx");
        }

        protected void btnInspector_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Response.Redirect("Inspectors.aspx");
        }

        protected void btnRental_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Response.Redirect("Rental.aspx");
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Response.Redirect("Return.aspx");
        }

        protected void btnHelp_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Response.Redirect("Help.aspx");
        }
    }
}


        
   