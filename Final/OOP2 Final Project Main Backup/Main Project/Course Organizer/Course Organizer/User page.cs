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
    public partial class Form_User : Form
    {
        public Form_User()
        {
            InitializeComponent();
        }

        private void label_logoutuserform_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Welcome().Show();
        }

        private void Button_Addcourse_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form_Addcourse().Show();
        }

        private void Button_Browsecourse_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form_Browse().Show();
        }

        private void Button_Editcourse_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Edit_Option().Show();
        }

        private void label_User_Click(object sender, EventArgs e)
        {
            
        }

        private void Form_User_Load(object sender, EventArgs e)
        {
            label_User.Text = Signin_Form.username;
        }
    }
}
