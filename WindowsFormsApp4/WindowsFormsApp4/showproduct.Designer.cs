namespace WindowsFormsApp4
{
    partial class showproduct
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
            this.products = new System.Windows.Forms.ListBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // products
            // 
            this.products.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.products.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.products.FormattingEnabled = true;
            this.products.ItemHeight = 23;
            this.products.Location = new System.Drawing.Point(12, 12);
            this.products.Name = "products";
            this.products.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.products.Size = new System.Drawing.Size(432, 234);
            this.products.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // showproduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(456, 398);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.products);
            this.Name = "showproduct";
            this.Text = "showproduct";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.showproduct_FormClosing);
            this.Load += new System.EventHandler(this.showproduct_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox products;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button1;
    }
}