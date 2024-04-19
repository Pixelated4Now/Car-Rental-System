using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace Registration
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=RegistrationDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(email.Text!="" && password.Text!="" && u_name.Text!="" && con_pass.Text!="")
            {
                if (password.Text == conpass.Text)
                {
                    int v = check(email.Text);
                    if (v != 1)
                    {
                        try
                        {
                            connection.Open();
                            SqlCommand command = new SqlCommand("insert into RegistrationTbl values(@u_name,@email,@password)", connection);
                            command.Parameters.AddWithValue("@email", email.Text);
                            command.Parameters.AddWithValue("@u_name", password.Text);
                            command.Parameters.AddWithValue("@password", u_name.Text);
                            command.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("Registered Successfully!");
                            password.Text = "";
                            email.Text = "";
                            u_name.Text = "";
                            conpass.Text = "";
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("An error occurred during registration. Please try again later.");
                            Console.WriteLine($"Registration failed: {ex.Message}");
                        }
                    }
                    else
                    {
                        MessageBox.Show("You are already registered");
                    }
                }
                else
                {
                    MessageBox.Show("Password does not match");
                }
            }
            else
            {
                MessageBox.Show("Fill in the empty fields!");
            }
        }

        int check(string email)
        {
            connection.Open();
            string query = "select count(*) from RegistrationTbl where email='" + email + "'";
            SqlCommand command= new SqlCommand(query, connection);
            int v=(int)command.ExecuteScalar();
            connection.Close();
            return v;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void conpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void u_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
