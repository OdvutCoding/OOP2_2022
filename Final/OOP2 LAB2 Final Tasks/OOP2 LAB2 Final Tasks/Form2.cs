using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace OOP2_LAB2_Final_Tasks
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
 
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            //if(textBox1.Text.ToString() !=null)
            if (textBox1.Text.Length > 0)
            {
                listBox1.Items.Add(textBox1.Text);
            }
            else
            {
                MessageBox.Show(" Name cannot be empty", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button_count_Click(object sender, EventArgs e)
        {
            Label_count.Text = "Count :  "+ listBox1.Items.Count.ToString();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button_sort_Click(object sender, EventArgs e)
        {

            listBox1.Sorted = true; //Ascending Order
            // For Descending sorting order
            /*
                        ArrayList list = new ArrayList();
            
            foreach(object o in listBox1.Items)
            {
                list.Add(o);
            }
            list.Sort();
            list.Reverse();
            listBox1.Items.Clear();
            foreach (object o in list)
            {
                listBox1.Items.Add(o);
            }
            */
        }
    }
}
