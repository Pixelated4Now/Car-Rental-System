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
using System.Xml.Linq;

namespace CarRentalSystem
{
    public partial class Customers : Form
    {
        string customerID; // Global variable to store the ID of the selected customer when editing or deleting.

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\User\OneDrive - NSBM\23.1 Y1 S3\CS107.3\CRMS\CarRentalSystem\CarRental.mdf';Integrated Security=True");

        public Customers()
        {
            InitializeComponent();
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            DataTable customersTable = GetCustomersData();

            CustomerDGV.DataSource = customersTable;
            
        }

        // Retrieves data from the Customers table in the DB.
        private DataTable GetCustomersData()
        {
            
            DataTable dt = new DataTable();

            try
            {
                string query = "SELECT * FROM Customers";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            return dt;
        }


        // When the user selects a cell in the table, the data in that row automatically fills up the form.
        private void CustomerDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            customerID = CustomerDGV.Rows[e.RowIndex].Cells[0].Value.ToString();

            txtName.Text = CustomerDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtContactNo.Text = CustomerDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtLicense.Text = CustomerDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtAddress.Text = CustomerDGV.Rows[e.RowIndex].Cells[4].Value.ToString();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ValidateCustomer vc = new ValidateCustomer();
            if (vc.CustomerNameCheck(txtName.Text) && vc.ContactNoCheck(txtContactNo.Text) && vc.LicenseCheck(txtLicense.Text) && vc.AddressCheck(txtAddress.Text))
            {

                try
                {
                    con.Open();

                    string insertQuery = $"INSERT INTO Customers (CustomerName, ContactNo, LicenseNumber, CustomerAddress) VALUES (@Name, @PhoneNo, @License, @Address);";

                    SqlCommand cmd = new SqlCommand(insertQuery, con);


                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@PhoneNo", txtContactNo.Text);
                    cmd.Parameters.AddWithValue("@License", txtLicense.Text);
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);



                    int rowsAffected = cmd.ExecuteNonQuery();


                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Customer added successfully!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        DataTable customersTable = GetCustomersData();

                        CustomerDGV.DataSource = customersTable;
                    }
                    else
                    {
                        MessageBox.Show("An error occurred while adding the customer.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();

                    txtName.Text = "";
                    txtAddress.Text = "";
                    txtContactNo.Text = "";
                    txtLicense.Text = "";
                }
            }

            
        }



        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (customerID == "")
            {

                MessageBox.Show("Please select the customer whose information is to be edited.", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                
            } else { 
                ValidateCustomer vc = new ValidateCustomer();
            if (vc.CustomerNameCheck(txtName.Text) && vc.ContactNoCheck(txtContactNo.Text) && vc.LicenseCheck(txtLicense.Text) && vc.AddressCheck(txtAddress.Text))
                {
                    try
                    {
                        con.Open();

                        string updateQuery = $"UPDATE Customers SET CustomerName = @Name, ContactNo = @PhoneNo, LicenseNumber = @License, CustomerAddress = @Address WHERE CustomerID = @CustomerID";

                        SqlCommand cmd = new SqlCommand(updateQuery, con);


                        cmd.Parameters.AddWithValue("@CustomerID", customerID);
                        cmd.Parameters.AddWithValue("@Name", txtName.Text);
                        cmd.Parameters.AddWithValue("@PhoneNo", txtContactNo.Text);
                        cmd.Parameters.AddWithValue("@License", txtLicense.Text);
                        cmd.Parameters.AddWithValue("@Address", txtAddress.Text);



                        int rowsAffected = cmd.ExecuteNonQuery();


                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Customer information updated successfully!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            DataTable customersTable = GetCustomersData();

                            CustomerDGV.DataSource = customersTable;

                        }
                        else
                        {
                            MessageBox.Show("An error occurred while updating the customer. Please try again.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close();

                        txtName.Text = "";
                        txtAddress.Text = "";
                        txtLicense.Text = "";
                        txtContactNo.Text = "";
                        customerID = "";
                    }
                }
            

                
            }
            
        }

        

        private void btnDelete_Click(object sender, EventArgs e)
        {


            if (customerID == "")
            {

                MessageBox.Show("Please select the customer to be deleted.", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this customer?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {


                    try
                    {
                        con.Open();


                        string deleteQuery = $"DELETE FROM Customers WHERE CustomerID = @CustomerID";


                        SqlCommand cmd = new SqlCommand(deleteQuery, con);


                        cmd.Parameters.AddWithValue("@CustomerID", customerID);


                        int rowsAffected = cmd.ExecuteNonQuery();


                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Customer deleted successfully!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            DataTable customersTable = GetCustomersData();

                            CustomerDGV.DataSource = customersTable;

                        }
                        else
                        {
                            MessageBox.Show("An error occurred while deleting the customer.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close();


                        txtName.Text = "";
                        txtAddress.Text = "";
                        txtLicense.Text = "";
                        txtContactNo.Text = "";
                        customerID = "";
                    }
                }
            }


           



        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtAddress.Text = "";
            txtLicense.Text = "";
            txtContactNo.Text = "";
            customerID = "";
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        // Changes the colour of text in the textbox when the user starts typing in it.
        private void txtSearchByID_Enter(object sender, EventArgs e)
        {
            
            if (txtSearchByID.Text == " Search for customer by ID")
            {
                txtSearchByID.Text = "";
                txtSearchByID.ForeColor = Color.Black;
            }
        }


        //Changes the text in the textbox back to the placeholder text if it is empty.
        private void txtSearchByID_Leave(object sender, EventArgs e)
        {

            if (txtSearchByID.Text == " ")
            {
                txtSearchByID.Text = " Search for customer ny ID";
                txtSearchByID.ForeColor = Color.Silver;
            }
        }


        // Refreshes the table/datagrid to show all its records.
        private void btnRefresh_Click(object sender, EventArgs e)
        {

            DataTable customersTable = GetCustomersData();

            CustomerDGV.DataSource = customersTable;

            //Resets the searchbox to its placeholder text.
            txtSearchByID.Text = " Search for customer by ID";
            txtSearchByID.ForeColor = Color.Silver;
        }


        // Search function to filter out only the record for the customer whose ID is typed into the serach bar.
        private void txtSearchByID_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchByID.TextLength >= 1)
            {
                try
                {
                    string query = $"SELECT * FROM Customers WHERE CustomerID LIKE '{txtSearchByID.Text}%'";

                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    adapter.Fill(dt);
                    CustomerDGV.DataSource = dt;

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
        }



    }
}

