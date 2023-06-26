using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace POEPART3
{
    public partial class Return : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRead_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["POE"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from ReturnManagement", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    GridView1.DataSource = dr;
                    GridView1.DataBind();

                }
            }
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["POE"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string query = "INSERT INTO ReturnManagement(rentalID, returnDate, DaysOver) " +
                    "VALUES(@rentalID, @returnDate, @DaysOver)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@rentalID", txtRentalID.Text);
                    cmd.Parameters.AddWithValue("@returnDate", txtReturnDate.Text);
                    cmd.Parameters.AddWithValue("@DaysOver", txtDaysOver.Text);
                    
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        lblComplete.Text = "Insertion successful.";
                    }
                    else
                    {
                        lblComplete.Text = "Insertion failed.";
                    }
                }
            }
        }

        protected void btnLateFees_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Response.Redirect("LateFees.aspx");
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Response.Redirect("Main.aspx");
        }
    }
}