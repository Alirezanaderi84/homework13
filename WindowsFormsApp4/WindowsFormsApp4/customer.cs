using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class customer : Form
    {
        public customer()
        {
            InitializeComponent();
        }

        private void customer_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void customer_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstname = textBox1.Text.Trim();
            string lastname = textBox2.Text.Trim();
            string phonenumber = textBox3.Text.Trim();
            string address = textBox4.Text;
            if (string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(lastname) || string.IsNullOrEmpty(phonenumber) || string.IsNullOrEmpty(address))
                MessageBox.Show("complete boxes");
            else
            {
                string total = firstname + ',' + lastname + ',' + phonenumber + "," + address + "\n";
                File.AppendAllText("customer.csv", total);
                MessageBox.Show("information saved successfully");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }

        }   
    }
}

        
     

