using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project
{
    public partial class FbillingInvoice : Form
    {
        private int bookingId;
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\L\Project\Project\App_Data\Database1.mdf;Integrated Security=True";

        public FbillingInvoice(int bookingID, string guestName, string roomType, decimal roomRate, DateTime checkIn, DateTime checkOut)
        {
            InitializeComponent();
            bookingId = bookingID;

            lblGuestName.Text = guestName;
            lblRoomType.Text = roomType;
            lblRoomRate.Text = roomRate.ToString("C");
            lblCheckInDate.Text = checkIn.ToShortDateString();
            lblCheckOutDate.Text = checkOut.ToShortDateString();

            int nights = (checkOut - checkIn).Days;
            lblNights.Text = nights.ToString();
            lblRoomCharges.Text = (nights * roomRate).ToString("C");
            CalculateTotal();
        }

        private void CalculateTotal()
        {
            try
            {
                decimal roomCharges = decimal.Parse(lblRoomCharges.Text, System.Globalization.NumberStyles.Currency);
                decimal additional = 0;
                decimal discount = 0;

                if (txtAdditionalCharges != null && !string.IsNullOrWhiteSpace(txtAdditionalCharges.Text))
                {
                    decimal.TryParse(txtAdditionalCharges.Text, out additional);
                }
                decimal.TryParse(txtDiscount.Text, out discount);

                decimal subtotal = roomCharges + additional;
                decimal discountAmount = subtotal * (discount / 100);
                decimal total = subtotal - discountAmount;

                lblTotalAmount.Text = total.ToString("C");
            }
            catch
            {
                MessageBox.Show("Error calculating total.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtAdditionalCharges_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void btnSaveInvoice_Click(object sender, EventArgs e)
        {
            try

            {
             

                decimal total = decimal.Parse(lblTotalAmount.Text, System.Globalization.NumberStyles.Currency);
                
                decimal additional = string.IsNullOrWhiteSpace(txtAdditionalCharge.Text) ? 0 : Convert.ToDecimal(txtAdditionalCharge.Text);

                decimal discount = string.IsNullOrWhiteSpace(txtDiscount.Text) ? 0 : Convert.ToDecimal(txtDiscount.Text);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Invoices (BookingID, TotalAmount, AdditionalCharges, Discount) VALUES (@BookingID, @Total, @Additional, @Discount)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@BookingID", bookingId);
                    cmd.Parameters.AddWithValue("@Total", total);
                    cmd.Parameters.AddWithValue("@Additional", additional);
                    cmd.Parameters.AddWithValue("@Discount", discount);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Invoice saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving invoice: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printing not yet implemented.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblCheckInDate_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FbillingInvoice_Load(object sender, EventArgs e)
        {

        }
    }
}

