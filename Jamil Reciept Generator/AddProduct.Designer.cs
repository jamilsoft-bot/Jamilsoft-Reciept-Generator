namespace Jamil_Reciept_Generator
{
    partial class AddProduct
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.totalbox = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.quntbox = new System.Windows.Forms.TextBox();
            this.ratebox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 359);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(26, 20);
            this.textBox1.TabIndex = 0;
            // 
            // totalbox
            // 
            this.totalbox.Location = new System.Drawing.Point(30, 268);
            this.totalbox.Name = "totalbox";
            this.totalbox.Size = new System.Drawing.Size(100, 20);
            this.totalbox.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(57, 118);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(210, 20);
            this.textBox3.TabIndex = 2;
            // 
            // quntbox
            // 
            this.quntbox.Location = new System.Drawing.Point(47, 195);
            this.quntbox.Name = "quntbox";
            this.quntbox.Size = new System.Drawing.Size(100, 20);
            this.quntbox.TabIndex = 3;
            this.quntbox.Text = "quant";
            // 
            // ratebox
            // 
            this.ratebox.Location = new System.Drawing.Point(167, 195);
            this.ratebox.Name = "ratebox";
            this.ratebox.Size = new System.Drawing.Size(100, 20);
            this.ratebox.TabIndex = 4;
            this.ratebox.Text = "rate";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(30, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 496);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ratebox);
            this.Controls.Add(this.quntbox);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.totalbox);
            this.Controls.Add(this.textBox1);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox totalbox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox quntbox;
        private System.Windows.Forms.TextBox ratebox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}