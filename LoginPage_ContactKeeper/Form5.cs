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
    public partial class Form5 : Form
    {
        private DataGridView dataGridView;

        public Form5()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /*
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

        /*
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
        */
    }

}
