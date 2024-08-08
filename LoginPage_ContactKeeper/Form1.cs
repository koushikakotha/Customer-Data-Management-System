using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LoginPage_ContactKeeper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=KoushiLap;Initial Catalog=contactkeeperdetails;Integrated Security=True;TrustServerCertificate=True");
            SqlCommand cmd = new SqlCommand("select * from Logindetails where Username='" + txtusername.Text + "' and Password='" + txtpassword.Text + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            string cmbItemValue = comboBox1.SelectedItem.ToString();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["Usertype"].ToString() == cmbItemValue)
                    {
                        MessageBox.Show("Success Login " + dt.Rows[i][2]);
                        if (comboBox1.SelectedIndex == 0)
                        {
                            Form2 f = new Form2();
                            f.Show();
                            this.Hide();
                        }
                        else
                        {
                            Form3 f3 = new Form3();
                            f3.Show();

                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Login");
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid Login");
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) 
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
            }
        }
    }
}