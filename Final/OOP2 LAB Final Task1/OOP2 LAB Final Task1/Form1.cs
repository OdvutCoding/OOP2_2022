using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2_LAB_Final_Task1
{
    public partial class ComboBox : Form
    {
      
        public ComboBox()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (textBoxitems.Text!="")
            {
                if(comboBoxitems.Items.Contains(textBoxitems.Text))
                {
                    MessageBox.Show("Item Already Exists");
                }
                else
                {
                    comboBoxitems.Items.Add(textBoxitems.Text);
                    textBoxitems.Clear();
                    textBoxitems.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please fill the text box first");
            }
        }

        private void Count_Click(object sender, EventArgs e)
        {
            int count = comboBoxitems.Items.Count;
            MessageBox.Show("Total count:" + count);
        }

        private void Sort_Click(object sender, EventArgs e)
        {
            comboBoxitems.Sorted = true;
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            comboBoxitems.Items.RemoveAt(comboBoxitems.SelectedIndex);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            comboBoxitems.Items.Clear();
        }
    }
}
