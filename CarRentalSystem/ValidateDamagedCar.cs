using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSystem
{
    public class ValidateDamagedCar : ValidateCarData
    {

        //Presence check for the damage notes.
        public bool DamageNotesPresenceCheck(string damageNotes)
        {
            if (damageNotes == "")
            {
                MessageBox.Show("Please enter the details of the damage sustained by the car.", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }
    }
}
