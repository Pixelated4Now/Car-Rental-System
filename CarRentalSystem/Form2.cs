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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //the place that we put the data base connection sqlconnection con = new sqlconnection .............

        private void Form2_Load(object sender, EventArgs e)
        {
          /* // Retrive the number of cars from the data base
            string queryCars = " SELECT COUNT (*) FROM CarsTbl;";
            SqlDataAdapter adapter = new SqlDataAdapter(queryCars,con);
            DataSet dt = new DataSet();
            adapter.Fill(dt,"carsTbl");
            lblCars.Text = dt.Tables[0].Rows[0][0].ToString();
            //retrive the number of customers from the data base
            string queryCustomers = " SELECT COUNT (*) FROM CustomersTbl;";
            SqlDataAdapter adapter1 = new SqlDataAdapter(queryCustomers, con);
            DataSet dt1 = new DataSet();
            adapter.Fill(dt1, "CustomersTbl");
            lblCustomers.Text =dt1.Tables[0].Rows[0][0].ToString();
            //retrive the number of rented cars from data table
            string queryrentedRentedCars = " SELECT COUNT (*) FROM CarsTbl;";
            SqlDataAdapter adapter2 = new SqlDataAdapter(queryrentedRentedCars, con);
            DataSet dt2 = new DataSet();
            adapter.Fill(dt2, "TblCars");
            lblRentedCars.Text = dt2.Tables[0].Rows[0][0].ToString();
            //retrieve the number of rented cars from the table
            string queryDamageCars = " SELECT COUNT (*) FROM DamageCarsTbl;";
            SqlDataAdapter adapter3 = new SqlDataAdapter(queryDamageCars, con);
            DataSet dt3 = new DataSet();
            adapter.Fill(dt3, "DamgeCarsTbl");
            lblDmageCars.Text = dt3.Tables[0].Rows[0][0].ToString();*/

        } 

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void butLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void butCustomers_Click(object sender, EventArgs e)
        {
         /*   this.Hide();
            Customers cus = new customers();
            cus.Show();*/

        }

        private void butCars_Click(object sender, EventArgs e)
        {
           /* this.Hide();
            cars vehi = new cars();
            vehi.show();*/
        }

        private void butBookings_Click(object sender, EventArgs e)
        {
           /* this.Hide();
            Bookings book = new Bookings();
            book.show();*/
        }

        private void butReturns_Click(object sender, EventArgs e)
        {
            /* this.Hide();
           Returns retrn = new Returns();
           retrn.show();*/
        }

        private void butDamages_Click(object sender, EventArgs e)
        {
            /* this.Hide();
           Damages dmg = new Damages();
           dmg.show();*/
        }
    }
}
