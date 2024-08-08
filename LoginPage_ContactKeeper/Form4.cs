using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPage_ContactKeeper
{
    public partial class Form4 : Form
    {
        
        public Form4()
        {
            InitializeComponent();


        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Display();

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
        public void Display()
        {

            Form2.DisplayandSearch("SELECT SNo, CustomerName, Business, Contact, Address, Email, TallySNo, Remarks, Response from Customerdetails ORDER by SNo ASC", dataGridView);

        }



        private void dataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                int SNo = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[2].Value);
                string customerName = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                string business = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                string contact = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                string email = dataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                string tallySNo = dataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
                string remarks = dataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
                string response = dataGridView.Rows[e.RowIndex].Cells[9].Value.ToString();
                string address = dataGridView.Rows[e.RowIndex].Cells[10].Value.ToString();

            }
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Do you want to delete this record?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    int SNo = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[2].Value);
                    Form2.DeleteCustomer(SNo);

                    Display();
                }
                return;

            }
        }


        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            //Form2.DisplayandSearch("SELECT SNo, CustomerName, Business, Contact, Address, Email, TallySNo, Remarks, Response from Customerdetails WHERE CustomerName LIKE'%"+ textSearch.Text +"%'", dataGridView);
            SqlConnection con = new SqlConnection("Data Source=KoushiLap;Initial Catalog=contactkeeperdetails;Integrated Security=True;Trust Server Certificate=True");
            try
            {
                con.Open();

                string selectquery = "SELECT SNo, CustomerName, Business, Contact, Address, Email, TallySNo, Remarks, Response from Customerdetails WHERE CONCAT([CustomerName], [Business], [Contact], [Address], [Email], [TallySNo], [Remarks], [Response]) LIKE'%" + textSearch.Text + "%'";
                using (SqlCommand cmd = new SqlCommand(selectquery, con))
                {
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        dataGridView.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("No record found.", "Error");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message), "Error");
            }
            finally
            {
                con.Close();
            }
        }
    }
}




























/*
 private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Get the values from the TextBoxes or other input controls
            string SNo = textsno.Text;
            string CustomerName = txtcustomername.Text;
            string Business = txtbusiness.Text;
            string Contact = txtcontact.Text;
            string Email = txtemail.Text;
            string TallySNo = txtTallysno.Text;
            string Remarks = txtRemarks.Text;
            string Response = txtRemarks.Text;
            string Address = txtaddress.Text;
            DeleteCustomer(SNo, CustomerName, Business, Contact, Email, TallySNo, Remarks, Response, Address);
        
    }
 */

/*
        
        private void buttonDelete_Click(int SNo, int Contact)
        {
            int SNo = Int32.Parse(txts);
            int Contact = Int32.Parse("Contact");
            string CustomerName = "@CustomerName";
            string Business = "@Business";
            string Email = "@Email";
            string TallySNo = "@TallySNo";
            string Remarks = "@Remarks";
            string Response = "@Response";
            string Address = "@Address";
         
            DeleteCustomer(SNo, CustomerName, Business, Contact, Email, TallySNo, Remarks, Response, Address);
        }
        */

/*
public static void DeleteCustomer(int SNo, string CustomerName, string Business, int Contact, string Email, string TallySNo, string Remarks, string Response, string Address)
//public static void DeleteCustomer(string SNo)
{
    SqlConnection con = new SqlConnection("Data Source=KoushiLap;Initial Catalog=contactkeeperdetails;Integrated Security=True;Trust Server Certificate=True");
    string querysql = "DELETE FROM Customerdetails WHERE SNo = @SNo AND CustomerName = @CustomerName AND Business =@Business AND Contact = @Contact AND Address = @Address AND Email = @Email AND TallySNo = @TallySNo AND Remarks = @Remarks AND Response = @Response";

    using (SqlCommand cmd = new SqlCommand(querysql, con))
    {
        try
        {
            con.Open();
            cmd.Parameters.Add("@SNo", SqlDbType.Int).Value = SNo;

            cmd.Parameters.AddWithValue("@CustomerName", SqlDbType.VarChar).Value = CustomerName;
            cmd.Parameters.AddWithValue("@Business", SqlDbType.VarChar).Value = Business;
            cmd.Parameters.AddWithValue("@Contact", SqlDbType.Int).Value = Contact;
            cmd.Parameters.AddWithValue("@Address", SqlDbType.VarChar).Value = Address;
            cmd.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = Email;
            cmd.Parameters.AddWithValue("@TallySNo", SqlDbType.VarChar).Value = TallySNo;
            cmd.Parameters.AddWithValue("@Remarks", SqlDbType.VarChar).Value = Remarks;
            cmd.Parameters.AddWithValue("@Response", SqlDbType.VarChar).Value = Response;



            int rowsaff = cmd.ExecuteNonQuery();
            if (rowsaff > 0)
            {
                MessageBox.Show("Successfully deleted!");
            }
            else
            {
                MessageBox.Show("Not Deleted");
            }

            con.Close();
        }


        catch (Exception ex)
        {
            MessageBox.Show("ERROR" + ex.Message);
        }


    }
    //cmd.CommandType = CommandType.Text;            


}
*/
