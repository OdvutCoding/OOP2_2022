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
    public partial class Admin_Dashboard : Form
    {
        public Admin_Dashboard()
        {
            InitializeComponent();
        }

        private void Button_Adminpanel_Student_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Admin_Panel().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminPanelCourse().Show();
        }

        private void label_return_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Signin_Form().Show();
        }
    }
}
