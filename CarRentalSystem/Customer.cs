using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {         
            DataTable customersTable = GetCustomersData();
           
            dataGridView1.DataSource = customersTable;
            txtCustomerID.Focus();
        }
        private DataTable GetCustomersData()
        {         
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\OneDrive - NSBM\Assignments\1st year 3rd sem\C#\C#Project\C#Project\Database1.mdf;Integrated Security=True");
            DataTable dt = new DataTable();

            try
            {
                con.Open();
                string query = "SELECT * FROM Customers"; 
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }

            return dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtName.Text, "^[a-zA-Z]+$"))
            {
                MessageBox.Show("Please enter a name containing only alphabetical characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }          
            if (!Regex.IsMatch(txtPhoneNo.Text, "^\\d{10}$"))
            {
                MessageBox.Show("Please enter a valid phone number with 10 digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Please enter a customer name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Please enter a customer address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtPhoneNo.Text))
            {
                MessageBox.Show("Please enter a customer phone number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\OneDrive - NSBM\Assignments\1st year 3rd sem\C#\C#Project\C#Project\Database1.mdf;Integrated Security=True");

            try
            { 
                con.Open();
               
                string insertQuery = $"INSERT INTO Customers (Name, Address, PhoneNo) VALUES (@Name, @Address, @PhoneNo)";
                
                SqlCommand cmd = new SqlCommand(insertQuery, con);

                
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@PhoneNo", txtPhoneNo.Text);

                
                int rowsAffected = cmd.ExecuteNonQuery();

               
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("An error occurred while adding the customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {            
                con.Close();
            }           
            txtCustomerID.Text = ""; 
            txtName.Text = "";
            txtAddress.Text = "";
            txtPhoneNo.Text = "";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            
            int customerIDToEdit;

            
            if (int.TryParse(txtCustomerID.Text, out customerIDToEdit))
            {             
            }
            else
            {
                MessageBox.Show("Please enter a valid customer ID to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }      
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\OneDrive - NSBM\Assignments\1st year 3rd sem\C#\C#Project\C#Project\Database1.mdf;Integrated Security=True");

            try
            {
                con.Open();
               
                string updateQuery = $"UPDATE Customers SET Name = @Name, Address = @Address, PhoneNo = @PhoneNo WHERE CustomerID = @CustomerID";

                SqlCommand cmd = new SqlCommand(updateQuery, con);

                
                string name = txtName.Text;
                string address = txtAddress.Text;
                string phoneNo = txtPhoneNo.Text;

               
                cmd.Parameters.AddWithValue("@CustomerID", customerIDToEdit);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@PhoneNo", phoneNo);

                
                int rowsAffected = cmd.ExecuteNonQuery();

               
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Customer information updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    txtName.Text = "";
                    txtAddress.Text = "";
                    txtPhoneNo.Text = "";
                }
                else
                {
                    MessageBox.Show("An error occurred while updating the customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            int customerIDToDelete;

            
            if (int.TryParse(txtCustomerID.Text, out customerIDToDelete))
            {
                
            }
            else
            {
                MessageBox.Show("Please enter a valid customer ID to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this customer?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
              
                SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\OneDrive - NSBM\Assignments\1st year 3rd sem\C#\C#Project\C#Project\Database1.mdf;Integrated Security=True");

                try
                {
                    con.Open();

                    
                    string deleteQuery = $"DELETE FROM Customers WHERE CustomerID = @CustomerID";

                   
                    SqlCommand cmd = new SqlCommand(deleteQuery, con);

                   
                    cmd.Parameters.AddWithValue("@CustomerID", customerIDToDelete);

                    
                    int rowsAffected = cmd.ExecuteNonQuery();

                    
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Customer deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                        txtName.Text = "";
                        txtAddress.Text = "";
                        txtPhoneNo.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("An error occurred while deleting the customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCustomerID.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            txtPhoneNo.Text = "";
        }
    }
}
