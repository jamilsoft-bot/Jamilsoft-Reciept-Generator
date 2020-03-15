using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jamil_Reciept_Generator
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 rate = int.Parse(ratebox.Text);
            Int32 qunt = int.Parse(quntbox.Text);
            int famount = rate * qunt;

            totalbox.Text = famount.ToString();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // Form1 form1 = new Form1();

            //form1.dataGridView1.Rows.Add("test");
        }
    }
}
