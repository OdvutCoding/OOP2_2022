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
    public partial class Course_Page : Form
    {
        public Course_Page()
        {
            InitializeComponent();
        }

        private void labe_course_name_Click(object sender, EventArgs e)
        {

        }

        private void Button_courseinfo_edit_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Edit_Option().Show();
        }

        private void label_return_signup_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form_Browse().Show();
        }

        private void label_next_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Progression1().Show();
        }
    }
}
