using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Azure;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;

namespace LoginPage_ContactKeeper
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();

        }



        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void Label6_Click(object sender, EventArgs e)
        {

        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtcustomername_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
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
        private void UpdateData(int SNo, string CustomerName, string Business, string Contact, string Email, string TallySNo, string Remarks, string Response, string Address)
        {
            SqlConnection con = new SqlConnection("Data Source=KoushiLap;Initial Catalog=contactkeeperdetails;Integrated Security=True;Trust Server Certificate=True");

            con.Open();

            string Updatequery = "Update Customerdetails SET CustomerName = @CustomerName , Business = @Business, Contact = @Contact, Email = @Email, TallySNo = @TallySNo, Remarks = @Remarks, Response = @Response, Address = @Address WHERE SNo = @SNo )";
            using (SqlCommand cmd = new SqlCommand(Updatequery, con))

            {
                try
                {
                    cmd.Parameters.AddWithValue("@SNo", SNo);
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
                        MessageBox.Show("Updated Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Not Inserted");
                    }

                    con.Close();
                }


                catch (Exception ex)
                {
                    MessageBox.Show("ERROR" + ex.Message);
                }
            }
        }

        public static void DeleteCustomer(int SNo)
        //public static void DeleteCustomer(int SNo, string CustomerName, string Business, int Contact, string Email, string TallySNo, string Remarks, string Response, string Address)

        {
            SqlConnection con = new SqlConnection("Data Source=KoushiLap;Initial Catalog=contactkeeperdetails;Integrated Security=True;Trust Server Certificate=True");
            string sql = " DELETE FROM Customerdetails WHERE SNo = @SNo";

            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@SNo", SNo);
                try
                {
                    int rowsaff = cmd.ExecuteNonQuery();
                    if (rowsaff > 0)
                    {
                        MessageBox.Show("Successfully deleted!");
                    }
                    else
                    {
                        MessageBox.Show("Not Inserted");
                    }


                }


                catch (Exception ex)
                {
                    MessageBox.Show("ERROR" + ex.Message);
                }

            }
            //cmd.CommandType = CommandType.Text;            
            con.Close();

        }

        private void textsno_TextChanged(object sender, EventArgs e)
        {

        }
        public static void DisplayandSearch(object sender, DataGridView dgv)
        {

            SqlConnection con = new SqlConnection("Data Source=KoushiLap;Initial Catalog=contactkeeperdetails;Integrated Security=True;Trust Server Certificate=True");
            SqlCommand cmd = new SqlCommand("SELECT SNo, CustomerName, Business, Contact, Address, Email, TallySNo, Remarks, Response from CustomerDetails ORDER by SNo ASC", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv.DataSource = dt;
            con.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();

        }

        internal static void DisplayandSearch(string v, object dataGridView)
        {
            throw new NotImplementedException();
        }
    }
}

















/*
       private void buttonDelete_Click(object sender, EventArgs e)
       {

           // Get the values from the TextBoxes or other input controls
           int SNo = Int32.Parse(textsno.Text);

           string CustomerName = txtcustomername.Text;
           string Business = txtbusiness.Text;
           int Contact= Int32.Parse(txtcontact.Text);
           string Email = txtemail.Text;
           string TallySNo = txtTallysno.Text;
           string Remarks = txtRemarks.Text;
           string Response = txtRemarks.Text;
           string Address = txtaddress.Text;
           //DeleteCustomer(SNo, CustomerName, Business, Contact, Email, TallySNo, Remarks, Response, Address);

       //DeleteCustomer(SNo);


   }
       */


// cmd.Parameters.AddWithValue("@SNo",SqlDbType.Int).Value = SNo;
/*
 cmd.Parameters.AddWithValue("@CustomerName",SqlDbType.VarChar).Value = CustomerName;
     cmd.Parameters.AddWithValue("@Contact", SqlDbType.Int).Value = Contact;
     cmd.Parameters.AddWithValue("@Address", SqlDbType.VarChar).Value = Address;
     cmd.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = Email;
     cmd.Parameters.AddWithValue("@TallySNo", SqlDbType.VarChar).Value = TallySNo;
     cmd.Parameters.AddWithValue("@Remarks", SqlDbType.VarChar).Value = Remarks;
     cmd.Parameters.AddWithValue("@Response", SqlDbType.VarChar).Value = Response;

     cmd.Parameters.AddWithValue("@Business", Business);
 cmd.Parameters.AddWithValue("@Contact", Contact);
 cmd.Parameters.AddWithValue("@Address", Address);
 cmd.Parameters.AddWithValue("@Email", Email);
 cmd.Parameters.AddWithValue("@TallySNo", TallySNo);
 cmd.Parameters.AddWithValue("@Remarks", Remarks);
 cmd.Parameters.AddWithValue("@Response", Response);

 */










////cmd.Parameters.AddWithValue("CustomerName", txtcustomername.Text);
//cmd.Parameters.AddWithValue("Business", txtbusiness.Text);
//cmd.Parameters.AddWithValue("Contact", txtcontact.Text);
//cmd.Parameters.AddWithValue("Email", txtemail.Text);
//cmd.Parameters.AddWithValue("Address", txtaddress.Text);
//

// Turn on IDENTITY_INSERT
//cmd.CommandText = "SET IDENTITY_INSERT Customerdetails ON";

// Insert statement with explicit column list
/*
cmd.CommandText = "INSERT INTO Customerdetails (SNo, CustomerName, Business, Contact, Email, Address) VALUES ('"NULL"','" + txtcustomername.Text + "','" + txtbusiness.Text + "','" + int.Parse(txtcontact.Text) + "','" + txtemail.Text + "','" + txtaddress.Text + "'");               /*
cmd.Parameters.AddWithValue("ID", null);
cmd.Parameters.AddWithValue("CustomerName", txtcustomername.Text);
cmd.Parameters.AddWithValue("Business", txtbusiness.Text );
cmd.Parameters.AddWithValue("Contact", int.Parse(txtcontact.Text));
cmd.Parameters.AddWithValue("Email", txtemail.Text);
cmd.Parameters.AddWithValue("Address", txtaddress.Text);

cmd.ExecuteNonQuery();

// Turn off IDENTITY_INSERT
cmd.CommandText = "SET IDENTITY_INSERT Customerdetails OFF";
cmd.ExecuteNonQuery();
*/
/* 
  SqlConnection con = new SqlConnection("Data Source=KoushiLap;Initial Catalog=contactkeeperdetails;Integrated Security=True;TrustServerCertificate=True");
  con.Open();
  SqlCommand cmd =new SqlCommand( "INSERT INTO Customerdetails VALUES (NULL,'"+txtcustomername.Text+ "','"+txtbusiness.Text+ "','"+ int.Parse(txtcontact.Text)+ "','"+txtemail.Text+ "','"+txtaddress.Text+"')",con);            
  cmd.ExecuteNonQuery();
  MessageBox.Show("Success!");
  con.Close();
'" + textsno.Text + "','" + txtcustomername.Text + "','" + txtbusiness.Text + "','" + txtcontact.Text + "','" + txtemail.Text + "','" + txtaddress.Text + "')"
*/