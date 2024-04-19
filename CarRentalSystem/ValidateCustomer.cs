using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CarRentalSystem
{
    public class ValidateCustomer
    {

        public bool CustomerNameCheck(string name)
        {
            //Presence check for the name.
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter the customer's name.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Type check for the name.
            if (!Regex.IsMatch(name, "^[a-zA-Z]+$"))
            {
                MessageBox.Show("Please enter a name containing only alphabetical characters.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public bool ContactNoCheck(string contactNo)
        {
            // Presence check for the contact number.
            if (string.IsNullOrEmpty(contactNo))
            {
                MessageBox.Show("Please enter a customer phone number.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Format and length check for the contact number.
            if (!Regex.IsMatch(contactNo, "^\\d{10}$"))
            {
                MessageBox.Show("Please enter a valid phone number with 10 digits.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public bool AddressCheck(string address)
        {
            // Presece check for the address.
            if (string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Please enter the customer's address.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }


        public bool LicenseCheck(string license)
        {
            // Presece check for the license number.
            if (string.IsNullOrEmpty(license))
            {
                MessageBox.Show("Please enter the customer's license number.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }




    }
}
