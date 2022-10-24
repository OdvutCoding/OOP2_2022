using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2_LAB_Final_Task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
                {
                MessageBox.Show(radioButton1.Text);
            }
            else if(radioButton2.Checked==true)
                    {
                MessageBox.Show(radioButton2.Text);
            }
            else if (radioButton3.Checked == true)
            {
                MessageBox.Show(radioButton3.Text);
            }
            else if (radioButton4.Checked == true)
            {
                MessageBox.Show(radioButton4.Text);
            }
            else 
            {
                MessageBox.Show("Please select from one of the radio buttons");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                this.BackColor = System.Drawing.Color.Red;
            }
            else if (radioButton6.Checked == true)
            {
                this.BackColor = System.Drawing.Color.Green;
            }
            else 
            {
                MessageBox.Show("Please select one of the colors");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
            {
                groupBox2.BackColor = System.Drawing.Color.Blue;
            }
            else if (radioButton8.Checked == true)
            {
                groupBox2.BackColor = System.Drawing.Color.Yellow;
            }
            else
            {
                MessageBox.Show("Please select one of the colors");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
