using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2_LAB2_Final_Tasks
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_num1.Text.Length > 0 && textBox_num2.Text.Length > 0)
            {
                int a = int.Parse(textBox_num1.Text.ToString());
                int b = int.Parse(textBox_num2.Text.ToString());
                labelResult.Text = "Result = " + (a + b).ToString();
                labelResult.Visible = true;
                labelResult.ForeColor = Color.Violet;
                textBox_num1.Clear();
                textBox_num2.Clear();
                textBox_num1.Focus();
            }
            else
            {
                MessageBox.Show(" Enter values in both text box", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox_num1.Text.Length > 0 && textBox_num2.Text.Length > 0)
            {
                int a = int.Parse(textBox_num1.Text.ToString());
                int b = int.Parse(textBox_num2.Text.ToString());
                labelResult.Text = "Result = " + (a - b).ToString();
                labelResult.Visible = true;
                labelResult.ForeColor = Color.Violet;
                textBox_num1.Clear();
                textBox_num2.Clear();
                textBox_num1.Focus();
            }
            else
            {
                MessageBox.Show(" Enter values in both text box", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox_num1.Text.Length > 0 && textBox_num2.Text.Length > 0)
            {
                int a = int.Parse(textBox_num1.Text.ToString());
                int b = int.Parse(textBox_num2.Text.ToString());
                labelResult.Text = "Result = " + (a * b).ToString();
                labelResult.Visible = true;
                labelResult.ForeColor = Color.Violet;
                textBox_num1.Clear();
                textBox_num2.Clear();
                textBox_num1.Focus();
            }
            else
            {
                MessageBox.Show(" Enter values in both text box", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox_num1.Text.Length > 0 && textBox_num2.Text.Length > 0)
            {
                int a = int.Parse(textBox_num1.Text.ToString());
                int b = int.Parse(textBox_num2.Text.ToString());
                labelResult.Text = "Result = " + (a / b).ToString();
                labelResult.Visible = true;
                labelResult.ForeColor = Color.Violet;
                textBox_num1.Clear();
                textBox_num2.Clear();
                textBox_num1.Focus();
            }
            else
            {
                MessageBox.Show(" Enter values in both text box", "Warning" ,MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox_num1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_next_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form2().Show();
            
        }
    }
}
