using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Organizer
{
    public partial class Form_Browse : Form
    {
        public Form_Browse()
        {
            InitializeComponent();
            listcollection.Clear();
            foreach(string str in listBox_courses.Items)
            {
                listcollection.Add(str);
                //tx_search.CharacterCasing = CharacterCasing.Upper;
            }
        }

        List<string> listcollection = new List<string>();
        private void Form6_Load(object sender, EventArgs e)
        {
 
        }

        private void label_return_signup_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form_User().Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Course_Page().Show();
        }

        private void tx_search_TextChanged(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(tx_search.Text) == false)
            //{
            //    listBox_courses.DataSource = listBox1.Items;
            //}
            //else
            //{
            //    if(tx_search.Text==listBox_courses.Text)
            //    {
            //        listBox_courses.Items.Add(tx_search.Text);
            //    }
            //    else
            //    {
            //        Prompt.Visible = true;
            //        Prompt.Text = "Course match not found";
            //    }
            //}
            if (string.IsNullOrEmpty(tx_search.Text) == false)
            {
                listBox_courses.Items.Clear();
                foreach (string str in listcollection)
                {
                    if (str.StartsWith(tx_search.Text))
                    {
                        listBox_courses.Items.Add(str);
                    }
                }
            }
            else if (tx_search.Text == " ")
            {

                foreach (string str in listcollection)
                {
                    //listBox_courses.Items.Clear();
                    listBox_courses.DataSource = listBox1.Items;
                }
            }
        }

        private void listBox_courses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_courses.SelectedItem.ToString() == "Object Oriented Programming 2")
            {
                this.Hide();
                new Course_Page().Show();
            }
            else if (listBox_courses.SelectedItem.ToString() == "Numerical Methods for Science & Engineering")
            {
                this.Hide();
                new Math5_courseinfo().Show();
            }
        }
    }
}
