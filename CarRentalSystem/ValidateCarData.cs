using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSystem
{
    public class ValidateCarData
    {
        //Presence check for the number plate of the car - it MUST be provided by the user.
        public bool NumberPlatePresenceCheck(string carNumPlate)
        {
            if (string.IsNullOrEmpty(carNumPlate))
            {
                MessageBox.Show("Please provide the number plate of the car.", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return false;
            }  
            else
                return true;
        }

        public bool BrandPresenceCheck(string brand)
        {
            if (string.IsNullOrEmpty(brand))
            {
                MessageBox.Show("Please provide the brand of the car.", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }


        public bool ModelPresenceCheck(string carNumPlate)
        {
            if (string.IsNullOrEmpty(carNumPlate))
            {
                MessageBox.Show("Please provide the respective model of the car.", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }


        //Presence check for the status of the car - it MUST be provided by the user.
        public bool CarStatusPresenceCheck(int selectedIndex)
        {
            if (selectedIndex < 0)
            {
                MessageBox.Show("Please select the current status of the car.", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }

        public bool RatePerDayChecks(string ratePerDay)
        {
            if (string.IsNullOrEmpty(ratePerDay))
            {
                MessageBox.Show("Please provide the rate per day appertaining to the car.", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return false;
            }
            // Type check to ensure that the rate/day is a numeric value.
            else if (!(int.TryParse(ratePerDay, out int result)))
            {
                MessageBox.Show("The rate per day should be a numeric value.", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return false;
            }
            // Range check to ensure the rate/day is a reasonable amount.
            else if (result < 10000 || result > 60000 )
            {
                MessageBox.Show("The rate per day is out of range.", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return false;
            }
                
            return true;
        }


    }
}
