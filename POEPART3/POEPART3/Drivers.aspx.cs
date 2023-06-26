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
    public partial class Drivers : System.Web.UI.Page
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
                SqlCommand cmd = new SqlCommand("Select * from Driver", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    GridView1.DataSource = dr;
                    GridView1.DataBind();

                }
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["POE"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Driver WHERE driverID = " + txtDriverID.Text, con);
                SqlDataReader dr = cmd.ExecuteReader();
                lblComplete.Text = "Completed";

            }
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["POE"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string query = "INSERT INTO Driver(driverID, firstName, lastName, Adress, Email, phoneNumber) " +
                    "VALUES(@driverID, @firstName, @lastName, @address, @email, @phoneNumber)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@driverID", txtDriverID.Text);
                    cmd.Parameters.AddWithValue("@firstName", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@lastName", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@address", txtAdress.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@phoneNumber", txtPhoneNumber.Text);

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

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["POE"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string query = "UPDATE Driver SET driverID = @newDriverID, firstName = @firstName, lastName = @lastName, Adress = @address, Email = @email, phoneNumber = @phoneNumber WHERE driverID = @existingDriverID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@newDriverID", txtDriverID.Text);
                    cmd.Parameters.AddWithValue("@firstName", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@lastName", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@address", txtAdress.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@phoneNumber", txtPhoneNumber.Text);
                    cmd.Parameters.AddWithValue("@existingDriverID", txtDriverID.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        lblComplete.Text = "Update successful.";
                    }
                    else
                    {
                        lblComplete.Text = "Update failed.";
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