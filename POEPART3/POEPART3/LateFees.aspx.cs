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
    public partial class LateFees : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGetFees_Click(object sender, EventArgs e)
        {
            int rentalId;
            if (int.TryParse(txtRentalID.Text, out rentalId))
            {
                int daysOver = CalculateDaysOver(rentalId);
                txtDaysOver.Text = daysOver.ToString();

                int lateFee = CalculateLateFee(daysOver);
                txtFees.Text = lateFee.ToString();
            }
            else
            {
                
            }
        }

        public int CalculateDaysOver(int rentalId)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["POE"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = @"SELECT DATEDIFF(day, Rental.endDate, ReturnManagement.returnDate) AS DaysOver
                        FROM Rental
                        INNER JOIN ReturnManagement ON Rental.RentalId = ReturnManagement.RentalId
                        WHERE Rental.RentalId = @rentalId";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@rentalId", rentalId);
                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        int daysOver = Convert.ToInt32(result);
                        return daysOver;
                    }
                }
            }

            return 0; 
        }

        public int CalculateLateFee(int daysOver)
        {
            
            int lateFee = daysOver * 500;
            return lateFee;
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Response.Redirect("Return.aspx");
        }
    }
}