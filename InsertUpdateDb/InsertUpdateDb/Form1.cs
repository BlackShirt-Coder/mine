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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\HP\Documents\DB.mdf;Integrated Security=True;Connect Timeout=30");
            connect.Open();
            string query = "update Shop set ItemName='RedMi' where ItemId=1";
            SqlCommand cmd = new SqlCommand(query, connect);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Query Updated");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\HP\Documents\DB.mdf;Integrated Security=True;Connect Timeout=30");
            connect.Open();
            string query = "delete from Shop where ItemId=1";
            SqlCommand cmd = new SqlCommand(query, connect);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Query Deleted");
        }
    }
}
