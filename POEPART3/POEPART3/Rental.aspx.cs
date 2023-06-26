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
    public partial class Rental : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnRead_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["POE"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from Rental", con);
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
                string query = "INSERT INTO Rental(rentalID, carNo, inspectorID, driverID, rentalFee, startDate, endDate) " +
                    "VALUES(@rentalID, @carNo, @inspectorID, @driverID, @rentalFee, @startDate, @endDate)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@rentalID", txtRentalID.Text);
                    cmd.Parameters.AddWithValue("@carNo", txtCarNumber.Text);
                    cmd.Parameters.AddWithValue("@inspectorID", txtInspectorID.Text);
                    cmd.Parameters.AddWithValue("@driverID", txtDriverID.Text);
                    cmd.Parameters.AddWithValue("@rentalFee", txtRentalFee.Text);
                    cmd.Parameters.AddWithValue("@startDate", txtStartDate.Text);
                    cmd.Parameters.AddWithValue("@endDate", txtEndDate.Text);

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

        protected void btnHome_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Response.Redirect("Main.aspx");
        }
    }
}