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
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into [Table] values (@CarID,@RegNo,@Model,@DamageType)", con);
            cmd.Parameters.AddWithValue("@CarID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@RegNo", int.Parse(textBox2.Text));
            cmd.Parameters.AddWithValue("@Model", textBox3.Text);
            cmd.Parameters.AddWithValue("@DamageType", textBox4.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("data saved");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\KY Kinson\\Desktop\\car rental\\damage report form\\Damageform\\Damageform\\Damageformdata.mdf\";Integrated Security=True");// TODO: This line of code loads data into the 'damageformDataSet.Damageform' table. You can move, or remove it, as needed.
            con.Open();
            SqlCommand cmd = new SqlCommand("update [Table] set RegNo=@RegNo, Model= @Model, DamageType= @DamageType where CarID = @CarID",con);
            cmd.Parameters.AddWithValue("@CarID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@RegNo", int.Parse(textBox2.Text));
            cmd.Parameters.AddWithValue("@Model", textBox3.Text);
            cmd.Parameters.AddWithValue("@DamageType", textBox4.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("data updated");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\KY Kinson\\Desktop\\car rental\\damage report form\\Damageform\\Damageform\\Damageformdata.mdf\";Integrated Security=True");// TODO: This line of code loads data into the 'damageformDataSet.Damageform' table. You can move, or remove it, as needed.
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete [Table] where CarID=@ID");
            cmd.Parameters.AddWithValue("@CarID", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\KY Kinson\\Desktop\\car rental\\damage report form\\Damageform\\Damageform\\Damageformdata.mdf\";Integrated Security=True");// TODO: This line of code loads data into the 'damageformDataSet.Damageform' table. You can move, or remove it, as needed.
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from [Table]", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable(); 
            da.Fill(dt);
            dataGridView1.DataSource = dt;

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
