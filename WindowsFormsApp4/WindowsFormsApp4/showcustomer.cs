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
    public partial class showcustomer : Form
    {
        public showcustomer()
        {
            InitializeComponent();
        }

        private void showcustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void showcustomer_Load(object sender, EventArgs e)
        {
            Customers.Items.Add("First Name,Last Name,Phone Number,Address");
            string file = "customer.csv";
            if (!File.Exists(file))

                Customers.Items.Add("No information to show");

            else
            {
                string[] total = File.ReadAllLines("customer.csv");
                for (int i = 0; i < total.Length; i++)
                {
                    Customers.Items.Add(total[i]);

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Customers.Items.Clear();
            Customers.Items.Add("First Name,Last Name,Phone Number,Address");
            if (!File.Exists("customer.csv"))

                Customers.Items.Add("No information to show");

            else
            {
                string[] total = File.ReadAllLines("customer.csv");
                for (int i = 0; i < total.Length; i++)
                {
                    Customers.Items.Add(total[i]);

                }
            }

        }

        
    }

}