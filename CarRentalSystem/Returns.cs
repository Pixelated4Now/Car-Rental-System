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
using System.Windows.Input;

namespace Returns
{
    public partial class Returns : Form
    {
        public Returns()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\HP\\OneDrive - NSBM\\Documents\\Returns.mdf\";Integrated Security=True;Connect Timeout=30");
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (car_id.Text != "" && cus_id.Text != "" && date.Text != "" && days_elapsed.Text != "" && fines.Text != "")
                {
                    int v = check(car_id.Text);
                    if (v != 1)
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand("Insert into ReturnTbl values(@c_id,@cu_id,@date,@d_elap,@p_fines)", connection);
                        command.Parameters.AddWithValue("@c_id", car_id.Text);
                        command.Parameters.AddWithValue("@cu_id", cus_id.Text);
                        command.Parameters.AddWithValue("@date", Convert.ToDateTime(date.Text));
                        command.Parameters.AddWithValue("@d_elap", days_elapsed.Text);
                        command.Parameters.AddWithValue("@p_fines", fines.Text);
                        command.ExecuteNonQuery();
                        connection.Close();
                        car_id.Text = "";
                        cus_id.Text = "";
                        days_elapsed.Text = "";
                        fines.Text = "";
                    }
                }

            }
            catch (SqlException ex)
            {

            }

        int check(string car_id)
            {
                connection.Open();
                string query = "select count(^) from ReturnsTbl where car_id='" + car_id + "'";
                SqlCommand command = new SqlCommand(query, connection);
                int v = (int)command.ExecuteScalar();
                connection.Close();
                return v;
            }

        }
    }
}

