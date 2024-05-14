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
    public partial class showproduct : Form
    {

        public showproduct()
        {
            InitializeComponent();

        }

        private void showproduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
        private void showproduct_Load(object sender, EventArgs e)
        {
            products.Items.Add("Product Type,Name,Product Id,Price");
            string file = "product.csv";
            if (!File.Exists(file))
            {
                products.Items.Add("No information to show ");

            }

            else
            {
                string[] total = File.ReadAllLines("product.csv");
                for (int i = 0; i < total.Length; i++)
                {
                    products.Items.Add(total[i]);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            products.Items.Clear();
            products.Items.Add("Product Type,Name,Product Id,Price");
            if (!File.Exists("product.csv"))
            {
                products.Items.Add("No information to show ");

            }

            else
            {
                string[] total = File.ReadAllLines("product.csv");
                for (int i = 0; i < total.Length; i++)
                {
                    products.Items.Add(total[i]);
                }
            }
        }
    }
}
