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

namespace ado_database_connect
{
    public partial class InsertForm : Form
    {
        public InsertForm()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
           SqlConnection connect= new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\shoon lai kyi\ado database connect\3cs1.mdf;Integrated Security=True;Connect Timeout=30");
           connect.Open();
           string query = "Insert into Student values(4,'swe swe','Bago')";
           SqlCommand cmd = new SqlCommand(query,connect);
           cmd.ExecuteNonQuery();
           MessageBox.Show("Query Inserted");
            // swe swe naing is a fool.swe swe naing is very beautiful
        }
    }
}
