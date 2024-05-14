using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        product f2 = new product();
        showproduct f3 = new showproduct();
        customer f4 = new customer();
        showcustomer f5 = new showcustomer();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ok_Click(object sender, EventArgs e)
        {
            f2.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            f3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            f5.Show();
        }

      
    }
}
