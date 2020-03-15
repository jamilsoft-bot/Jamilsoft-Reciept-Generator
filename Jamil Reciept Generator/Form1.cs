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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            
        }

        

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            string savepath = "C:\\Users\\Jamilsoft\\Documents\\Nusaiba\\"+ Namebox.Text +"#"+ Randlable.Text + ".rtf";

            richTextBox1.SaveFile(savepath);
            printDialog1.Document = printDocument1;

            DialogResult rd = printDialog1.ShowDialog();
            if(rd == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
        string Doctoprint;

        

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {



            //e.Graphics.DrawImage(pictureBox1.Image, 0, 0);

            System.Drawing.Font myfont = new System.Drawing.Font("Microsoft Sans Serif", 7);
            e.Graphics.DrawString("\n\n", myfont,System.Drawing.Brushes.Black,3,5);
            
            e.Graphics.DrawString(richTextBox1.Text, myfont, System.Drawing.Brushes.Black, 15, 18);
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        string Operation = "";
        double FirstNumber = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("please Add Payment Method");
            }
            System.Random random = new Random();
            int invoice = random.Next();
            Randlable.Text = invoice.ToString();


            Doctoprint = "                 NUSAIBA GLOBAL CONCEPT LTD\n";
            Doctoprint += "          Murtala Muhd Way, opp BIC Bauchi,\n                                     Bauchi State\n";
            Doctoprint += "                Tell:- 08068036010, 08036752851\n";
            Doctoprint += "\n\n\n";

            Doctoprint += "Invoice No: #" + Randlable.Text +"\n\n";
            Doctoprint += "Date : "  + dateTimePicker1.Text + "\n\n";
            
            Doctoprint +="Name: " + Namebox.Text + "\n";
            Doctoprint += "Address" + AddressBox.Text + "\n\n";
            Doctoprint += "                SERVICES" + "\n";
            Doctoprint += "------------------------------------------------------------------------------------\n";
            foreach (DataGridViewRow rw in dataGridView1.Rows)
            {
                Doctoprint += rw.Cells[0].Value + "  " + rw.Cells[1].Value + "            " + rw.Cells[2].Value + "            " + rw.Cells[3].Value +"          "+ rw.Cells[4].Value + "\n";
            }
            
            Doctoprint += "-----------------------------------------------------------------------------------" + "\n";
            Doctoprint += "Payment Method:-                                 " + comboBox1.SelectedItem.ToString();
            //Doctoprint += "\nSub Total                             NGN" + SubTotalBox.Text +"\n";
            //Doctoprint += "Tax :                                 NGN" + Taxbox.Text + "\n";
            Doctoprint += "\nTotal:-                                                  NGN"+ NoTotalBox.Text + "\n";
            Doctoprint += "\n\n\n";
           Doctoprint += ".................................................";


            Doctoprint += "\n\n\n\nThanks for your Patronage!";

            richTextBox1.Text = Doctoprint;

            
        }

        

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 nw = new Form1();
            nw.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            update up = new update();
            up.Show();
        }

        private void licenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            update up = new update();
            up.Show();

            //foreach (DataGridViewRow rw in dataGridView1.Rows)
            //{
            //   // Doctoprint += rw.Cells[0].Value + "  " + rw.Cells[1].Value + "            " + rw.Cells[2].Value + "            " + rw.Cells[3].Value + "          " + rw.Cells[4].Value + "\n";

            //    //Int32 rate = int.Parse(rw.Cells[2].Value.ToString());
            //    //Int32 IntQuantity = int.Parse(rw.Cells[3].Value.ToString());
            //    //rw.Cells[4].Value = (rate * IntQuantity).ToString();
                
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void n1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void n2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void n3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void n4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void n5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void n6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void n7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void n8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void n9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void n0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void bad_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "+";
        }

        private void bsub_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "-";

        }

        private void bmul_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "*";
        }

        private void bdiv_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "/";
        }

        private void bequal_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(textBox1.Text);

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    textBox1.Text = "Cannot divide by zero";

                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    textBox1.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }


        }

        private void bc_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void OpenDbBtn_Click(object sender, EventArgs e)
        {
            process1.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string savepath = "C:\\Users\\Jamilsoft\\Documents\\Nusaiba\\";

            openFileDialog1.InitialDirectory = savepath;
            //openFileDialog1.ShowDialog();
            DialogResult result = openFileDialog1.ShowDialog();

            if(result == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            Namebox.Text = "";
            AddressBox.Text = "";
            NoTotalBox.Text = "";
            richTextBox1.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (panel1.Visible)
            {
                MessageBox.Show("Calculator Is Already Display");
            }
            panel1.Show();
        }

        private void n0_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //AddProduct product = new AddProduct();

            // product.Show();

            //dataGridView1.Rows.Add("test 1");
        }
    }
    }

