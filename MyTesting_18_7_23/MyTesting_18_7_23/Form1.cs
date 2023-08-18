using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTesting_18_7_23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cb1.Items.Add("First Year");
            cb1.Items.Add("Second Year");
            cb1.Items.Add("Third Year");
            cb1.Items.Add("Four Year");
        }

        private void add_Click(object sender, EventArgs e)
        {
            string sarthar = cb1.SelectedItem.ToString() ;
            MessageBox.Show(sarthar);
        }
    }
}