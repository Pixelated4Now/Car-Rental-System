using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSystem
{
    public partial class Menu : UserControl
    {
        
        public Menu()
        {
            InitializeComponent();
            
        }


        // Dashboard.
        private void lblDashboard_MouseEnter(object sender, EventArgs e)
        {
            lblDashboard.BackColor = Color.FromArgb(108, 82, 117);
        }

        private void lblDashboard_MouseLeave(object sender, EventArgs e)
        {
            lblDashboard.BackColor = Color.FromArgb(53, 49, 96);
        }

        private void lblDashboard_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            var mainForm = this.Parent as Form;

            d.Show();
            mainForm.Hide();

        }


        //Logout button
        private void lblLogOut_Click(object sender, EventArgs e)
        {
            lblLogOut.BackColor = Color.FromArgb(108, 82, 117);
            Application.Exit();
        }

       

        private void lblLogOut_MouseEnter(object sender, EventArgs e)
        {
            lblLogOut.BackColor = Color.FromArgb(108, 82, 117);
        }

        private void lblLogOut_MouseLeave(object sender, EventArgs e)
        {
            lblLogOut.BackColor = Color.FromArgb(53, 49, 96);
        }



        // Cars
        private void lblCars_Click(object sender, EventArgs e)
        {
            Car c = new Car();
            var mainForm = this.Parent as Form;

            c.Show();
            mainForm.Hide();

        }
        private void lblCars_MouseEnter(object sender, EventArgs e)
        {
            lblCars.BackColor = Color.FromArgb(108, 82, 117);
        }

        private void lblCars_MouseLeave(object sender, EventArgs e)
        {
            lblCars.BackColor = Color.FromArgb(53, 49, 96);
        }



        // Customers
        private void lblCustomers_Click(object sender, EventArgs e)
        {
            Customers c = new Customers();
            var mainForm = this.Parent as Form;

           c.Show();
            mainForm.Hide();

        }
        private void lblCustomers_MouseEnter(object sender, EventArgs e)
        {
            lblCustomers.BackColor = Color.FromArgb(108, 82, 117);
        }

        private void lblCustomers_MouseLeave(object sender, EventArgs e)
        {
            lblCustomers.BackColor = Color.FromArgb(53, 49, 96);
        }

        // Booking
        private void lblBooking_Click(object sender, EventArgs e)
        {
            //Car c = new Car();
            var mainForm = this.Parent as Form;

            //c.Show();
            mainForm.Hide();

        }
        private void lblBooking_MouseEnter(object sender, EventArgs e)
        {
            lblBooking.BackColor = Color.FromArgb(108, 82, 117);
        }

        private void lblBooking_MouseLeave(object sender, EventArgs e)
        {
            lblBooking.BackColor = Color.FromArgb(53, 49, 96);
        }



        // Return
        private void lblReturn_Click(object sender, EventArgs e)
        {
            Car c = new Car();
            var mainForm = this.Parent as Form;

            c.Show();
            mainForm.Hide();

        }
        private void lblReturn_MouseEnter(object sender, EventArgs e)
        {
            lblReturn.BackColor = Color.FromArgb(108, 82, 117);
        }

        private void lblReturn_MouseLeave(object sender, EventArgs e)
        {
            lblReturn.BackColor = Color.FromArgb(53, 49, 96);
        }

        // Damage
        private void lblDamage_Click(object sender, EventArgs e)
        {
            Car c = new Car();
            var mainForm = this.Parent as Form;

            c.Show();
            mainForm.Hide();

        }
        private void lblDamage_MouseEnter(object sender, EventArgs e)
        {
            lblDamage.BackColor = Color.FromArgb(108, 82, 117);
        }

        private void lblDamage_MouseLeave(object sender, EventArgs e)
        {
            lblDamage.BackColor = Color.FromArgb(53, 49, 96);
        }


    }
}
