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

namespace CarRentalSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\User\OneDrive - NSBM\23.1 Y1 S3\CS107.3\CRMS\CarRentalSystem\CarRental.mdf';Integrated Security=True");


        private void Dashbaord_Load(object sender, EventArgs e)
        {
          // Retrieve the total number of cars from the database.

            string queryCars = "SELECT COUNT (*) FROM Cars;";
            SqlDataAdapter adapter = new SqlDataAdapter(queryCars,conn);
            DataSet dt = new DataSet();
            adapter.Fill(dt,"TotalCars");
            lblTotalCars.Text = dt.Tables[0].Rows[0][0].ToString();



            // Retrieve the number of customers from the data base
            string queryCustomers = " SELECT COUNT (*) FROM Customers;";
            adapter = new SqlDataAdapter(queryCustomers, conn);
            DataSet dt1 = new DataSet();
            adapter.Fill(dt1, "Customers");
            lblCustomers.Text =dt1.Tables[0].Rows[0][0].ToString();


            // Retrieve the number of available (not rented) cars from data table
            string queryAvailableCars = " SELECT COUNT (*) FROM Cars WHERE CarStatus = 'AVAILABLE';";
            adapter = new SqlDataAdapter(queryAvailableCars, conn);
            DataSet dt2 = new DataSet();
            adapter.Fill(dt2, "AvailableCars");
            lblAvailableCars.Text = dt2.Tables[0].Rows[0][0].ToString();

            // Retrieve the number of rented cars from data table
            string queryrentedRentedCars = " SELECT COUNT (*) FROM Cars WHERE CarStatus = 'RENTED';";
            adapter = new SqlDataAdapter(queryrentedRentedCars, conn);
            DataSet dt3 = new DataSet();
            adapter.Fill(dt3, "RentedCars");
            lblRentedCars.Text = dt3.Tables[0].Rows[0][0].ToString();


            // Retrieeve the number of damaged cars from the table
            string queryDamageCars = " SELECT COUNT (*) FROM Cars WHERE CarStatus='IN REPAIR';";
            adapter = new SqlDataAdapter(queryDamageCars, conn);
            DataSet dt4 = new DataSet();
            adapter.Fill(dt4, "DamgedCars");
            lblDamagedCars.Text = dt4.Tables[0].Rows[0][0].ToString();

        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
