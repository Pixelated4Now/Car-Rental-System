using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSystem
{
    public partial class Cars : Form
    {
        public Cars()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\User\OneDrive - NSBM\23.1 Y1 S3\CS107.3\CarRentalSystem\CarRentalSystem\CarRental.mdf';Integrated Security=True");



        // Changes the colour of text in the textbox when the user starts typing in it.
        private void txtSearchByNum_Enter(object sender, EventArgs e)
        {
            if (txtSearchByNum.Text == " Search for car by number plate")
            {
                txtSearchByNum.Text = "";
                txtSearchByNum.ForeColor = Color.Black;
            }
        }


        //Changes the text in the textbox back to the placeholder text if it is empty.
        private void txtSearchByNum_Leave(object sender, EventArgs e)
        {

            if (txtSearchByNum.Text == "")
            {
                txtSearchByNum.Text = " Search for car by number plate";
                txtSearchByNum.ForeColor = Color.Silver;
            }
        }


        // Close the application when the '×' is clicked.
        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




        // Function to populate the dataset.
        private void Populate()
        {
            string query = "SELECT * FROM Cars;";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

            DataSet dataset = new DataSet();
            adapter.Fill(dataset, "Cars");

            CarDGV.DataSource = dataset.Tables[0];
        }


        private void Cars_Load(object sender, EventArgs e)
        {

            Populate();
        }


        // When the user selects a cell in the table, the data in that row automatically fills up the form.
        private void CarDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNumPlate.Text = CarDGV.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtBrand.Text = CarDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtModel.Text = CarDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPrice.Text = CarDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
            cbStatus.SelectedItem = CarDGV.Rows[e.RowIndex].Cells[4].Value.ToString();
            
        }


        
        // Clearing the form.
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtModel.Text = txtBrand.Text = txtNumPlate.Text = txtPrice.Text = "";
            cbStatus.SelectedIndex = -1;
        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Creating an object of the class used to validate data about the car.
            ValidateCarData validateCarData = new ValidateCarData();


            if (validateCarData.NumberPlatePresenceCheck(txtNumPlate.Text) && validateCarData.BrandPresenceCheck(txtBrand.Text) && validateCarData.ModelPresenceCheck(txtModel.Text) && validateCarData.CarStatusPresenceCheck(cbStatus.SelectedIndex) && validateCarData.RatePerDayChecks(txtPrice.Text)) 
            {
                
                try
                {
                    string query = $"INSERT INTO Cars VALUES('{txtNumPlate.Text}', '{txtBrand.Text}', '{txtModel.Text}', {txtPrice.Text}, '{cbStatus.SelectedItem.ToString()}');";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Car added successfully.", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Populate();  // Refreshes the table to show the new car.

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                finally
                {
                    txtBrand.Text = txtNumPlate.Text = txtModel.Text = txtPrice.Text = "";
                    cbStatus.SelectedIndex = -1;
                }
            }
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtNumPlate.Text == "")
            {
                MessageBox.Show("Please select the car to be removed.", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string query = $"DELETE FROM Cars WHERE NumberPlate = '{txtNumPlate.Text}';";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Car deleted successfully.", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Populate();  // Refreshes the table..

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                finally
                {
                    txtBrand.Text = txtNumPlate.Text = txtModel.Text = txtPrice.Text = "";
                    cbStatus.SelectedIndex = -1;
                }


            }
        }




        private void btnEdit_Click(object sender, EventArgs e)
        {
            ValidateCarData validateCarData = new ValidateCarData();

            if (validateCarData.NumberPlatePresenceCheck(txtNumPlate.Text) && validateCarData.BrandPresenceCheck(txtBrand.Text) && validateCarData.ModelPresenceCheck(txtModel.Text) && validateCarData.CarStatusPresenceCheck(cbStatus.SelectedIndex) && validateCarData.RatePerDayChecks(txtPrice.Text))
            
            {
                try
                {
                    string query = $"UPDATE Cars SET Brand = '{txtBrand.Text}', Model = '{txtModel.Text}', CarStatus = '{cbStatus.SelectedItem.ToString()}', RatePerDay = {txtPrice.Text} WHERE NumberPlate ='{txtNumPlate.Text}';";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Car updated successfully.", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Populate();  // Refreshes the table/datagrid to show the updated car details.

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                finally
                {
                    txtBrand.Text = txtNumPlate.Text = txtModel.Text = txtPrice.Text = "";
                    cbStatus.SelectedIndex = -1;
                }
            }
        }



        // Refreshes the table/datagrid to show all its records.
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Populate();
            //Clears the selection in the combobox.
            cbAvailability.SelectedIndex = -1;
            //Resets the searchbox to its placeholder text.
            txtSearchByNum.Text = " Search for car by number plate";
            txtSearchByNum.ForeColor = Color.Silver;
        }



        // Functionality of the search feature to filter out avilable, rented and damaged cars.
        private void cbAvailability_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string status;
            if (cbAvailability.SelectedIndex == 0)
                status = "AVAILABLE";
            else if (cbAvailability.SelectedIndex == 1)
                status = "IN REPAIR";
            else
                status = "RENTED";


            string query = $"SELECT * FROM Cars WHERE CarStatus = '{status}' ;";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

            DataSet dataset = new DataSet();
            adapter.Fill(dataset, "Cars");

            CarDGV.DataSource = dataset.Tables[0];
        }


        // Search function to filter out only the record for the car whose number plate is typed into the serach bar.
        private void txtSearchByNum_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchByNum.TextLength >= 3)
            {
                try
                {
                    string query = $"SELECT * FROM Cars WHERE NumberPlate LIKE '{txtSearchByNum.Text}%'";

                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.Fill(dt);
                    CarDGV.DataSource = dt;

                } catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
        }



    }
}



