using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace July7DaysProject
{
    public partial class comboSelect : Form
    {
        public comboSelect()
        {
            InitializeComponent();
        }

        private void comboSelect_Load(object sender, EventArgs e)
        {
            cb3.Items.Add("Year");
            cb3.Items.Add("Student");
    
            

        }

        private void cb3_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb4.Items.Clear();

            if (cb3.SelectedItem == "Year")
            {
                cb4.Items.Add("2022");
                cb4.Items.Add("2023");
                cb4.Items.Add("2024");
                cb4.Items.Add("2005");
            }
            else if (cb3.SelectedItem == "Student")
            {
                cb4.Items.Add("Mg Mg");
                cb4.Items.Add("Su Su");

            }
        }

        private void ch1_Click(object sender, EventArgs e)
        {
            string text = cb3.Text;
            if (text == "Year")
            {
                MessageBox.Show("Year" + cb4.Text);
            }
            else
            {
                MessageBox.Show("Student" + cb4.Text);
            }
        }
           
    }
}
