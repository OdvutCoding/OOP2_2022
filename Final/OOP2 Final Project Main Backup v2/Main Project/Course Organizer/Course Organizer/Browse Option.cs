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
        }

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
    }
}
