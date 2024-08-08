using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPage_ContactKeeper
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtcustomername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textsno_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbusiness_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcontact_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTallysno_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRemarks_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            //string SNo = textsno.Text;
            string CustomerName = txtcustomername.Text;
            string Business = txtbusiness.Text;
            string Contact = txtcontact.Text;
            string Email = txtemail.Text;
            string TallySNo = txtTallysno.Text;
            string Remarks = txtRemarks.Text;
            string Response = txtRemarks.Text;
            string Address = txtaddress.Text;
            InsertData(CustomerName, Business, Contact, Email, TallySNo, Remarks, Response, Address);
        }
        private void InsertData(string CustomerName, string Business, string Contact, string Email, string TallySNo, string Remarks, string Response, string Address)
        {
            SqlConnection con = new SqlConnection("Data Source=KoushiLap;Initial Catalog=contactkeeperdetails;Integrated Security=True;Trust Server Certificate=True");
            try
            {
                con.Open();

                string Insertquery = "INSERT INTO Customerdetails (CustomerName, Business, Contact, Email, TallySNo, Remarks, Response, Address) VALUES (@CustomerName, @Business, @Contact, @Email, @TallySNo, @Remarks, @Response, @Address)";
                using (SqlCommand cmd = new SqlCommand(Insertquery, con))

                {
                    // cmd.Parameters.AddWithValue("@SNo", SNo);
                    cmd.Parameters.AddWithValue("@CustomerName", CustomerName);
                    cmd.Parameters.AddWithValue("@Business", Business);
                    cmd.Parameters.AddWithValue("@Contact", Contact);
                    cmd.Parameters.AddWithValue("@Address", Address);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@TallySNo", TallySNo);
                    cmd.Parameters.AddWithValue("@Remarks", Remarks);
                    cmd.Parameters.AddWithValue("@Response", Response);


                    //cmd.CommandText = "SET IDENTITY_INSERT Customerdetails ON";
                    int rowsaff = cmd.ExecuteNonQuery();
                    if (rowsaff > 0)
                    {
                        MessageBox.Show("Success! ");
                    }
                    else
                    {
                        MessageBox.Show("Not Updated");
                    }

                    con.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }
    }
}
