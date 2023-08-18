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

namespace InsertUpdateDb
{
    public partial class InsertForm : Form
    {
        public InsertForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\HP\Documents\DB.mdf;Integrated Security=True;Connect Timeout=30");
            connect.Open();
            string query = "insert into Shop values('"+textBox1.Text+"','"+textBox2.Text+"')";
            SqlCommand cmd = new SqlCommand(query, connect);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Query Inserted");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\HP\Documents\DB.mdf;Integrated Security=True;Connect Timeout=30");
            connect.Open();
            string query = "select * from Shop";
            SqlCommand cmd = new SqlCommand(query, connect);
            SqlDataReader rdr = cmd.ExecuteReader();
            string msg = "";
            while (rdr.Read())
            {
                msg += rdr[0].ToString() + "_" + rdr[1] + "\n";
            }
                rdr.Close();
                connect.Close();
                MessageBox.Show(msg);
            
           
        }
    }
}
