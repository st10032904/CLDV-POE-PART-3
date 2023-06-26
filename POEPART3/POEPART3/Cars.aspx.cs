using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace POEPART3
{
    public partial class Cars : System.Web.UI.Page
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
                    SqlCommand cmd = new SqlCommand("Select * from Vehicle", con);
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
                SqlCommand cmd = new SqlCommand("DELETE FROM Vehicle WHERE carNo = " + txtCarNumber.Text, con);
                SqlDataReader dr = cmd.ExecuteReader();
                lblComplete.Text = "Completed";

            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int available = 0;
            if (rbnAvailable.Checked)
            {
                available = 1;
            }
            string cs = ConfigurationManager.ConnectionStrings["POE"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Vehicle SET carNo = " + txtCarNumber.Text +", ModelID = " + txtModelID.Text +", kilometresTravelled = " + txtKilometresTravelled.Text +", available = " + available + ", ServiceKilometres = " + txtServiceKilometres.Text + " WHERE carNo = " + txtCarNumber.Text, con);
                SqlDataReader dr = cmd.ExecuteReader();
                lblComplete.Text = "Completed";

            }

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            //Boolean available = false;
            //String available = "False";
            int available = 0;
            if (rbnAvailable.Checked)
            {
                available = 1;
            }
            string cs = ConfigurationManager.ConnectionStrings["POE"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Vehicle(Carno, ModelID, kilometresTravelled, available, ServiceKilometres) VALUES(" + txtCarNumber.Text + "," + txtModelID.Text + "," + txtKilometresTravelled.Text + "," + available + "," + txtServiceKilometres.Text + ")", con);
                SqlDataReader dr = cmd.ExecuteReader();
                lblComplete.Text = "Completed";
                
            }
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Response.Redirect("Main.aspx");
        }
    }
    }


        
    
