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
    public partial class Form_Addcourse : Form
    {
        public Form_Addcourse()
        {
            InitializeComponent();
        }

        private void label_return_signup_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form_User().Show();
        }

        private void Button_course_save_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form_Browse().Show();
        }
    }
}
