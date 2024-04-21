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

namespace  CarRentalSystem
{
    public partial class Damageform : Form
    {
        public Damageform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\KY Kinson\\Desktop\\car rental\\damage report form\\Damageform\\Damageform\\Damageformdata.mdf\";Integrated Security=True");// TODO: This line of code loads data into the 'damageformDataSet.Damageform' table. You can move, or remove it, as needed.
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\KY Kinson\\Desktop\\car rental\\damage report form\\Damageform\\Damageform\\Damageformdata.mdf\";Integrated Security=True");// TODO: This line of code loads data into the 'damageformDataSet.Damageform' table. You can move, or remove it, as needed.
            c
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\KY Kinson\\Desktop\\car rental\\damage report form\\Damageform\\Damageform\\Damageformdata.mdf\";Integrated Security=True");// TODO: This line of code loads data into the 'damageformDataSet.Damageform' table. You can move, or remove it, as needed.
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\KY Kinson\\Desktop\\car rental\\damage report form\\Damageform\\Damageform\\Damageformdata.mdf\";Integrated Security=True");// TODO: This line of code loads data into the 'damageformDataSet.Damageform' table. You can move, or remove it, as needed.
            con.Open();
            

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
