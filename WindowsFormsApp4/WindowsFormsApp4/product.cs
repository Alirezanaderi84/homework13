using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class product : Form
    {
        public product()
        {
            InitializeComponent();
        }

        private void product_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void product_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
                string type = textBox1.Text.Trim();
                string name = textBox2.Text.Trim();
                string productid = textBox3.Text.Trim();
                string price = textBox4.Text.Trim();
            if (string.IsNullOrEmpty(type) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(productid) || string.IsNullOrEmpty(price))
            {
                MessageBox.Show("Complete boxes");
            }
            else
            {
                string total = type + ',' + name + ',' + productid + "," + price + "\n";
                File.AppendAllText("product.csv", total);
                MessageBox.Show("Information saved succesfully");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
            
            
            
        }
    }
}
