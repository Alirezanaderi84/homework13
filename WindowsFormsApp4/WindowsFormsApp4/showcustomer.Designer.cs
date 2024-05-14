namespace WindowsFormsApp4
{
    partial class showcustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Customers = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Customers
            // 
            this.Customers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Customers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Customers.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customers.FormattingEnabled = true;
            this.Customers.ItemHeight = 23;
            this.Customers.Location = new System.Drawing.Point(12, 12);
            this.Customers.Name = "Customers";
            this.Customers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Customers.Size = new System.Drawing.Size(432, 232);
            this.Customers.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // showcustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(456, 355);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Customers);
            this.Name = "showcustomer";
            this.Text = "showcustomer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.showcustomer_FormClosing);
            this.Load += new System.EventHandler(this.showcustomer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Customers;
        private System.Windows.Forms.Button button1;
    }
}