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
    public partial class Admin_Panel : Form
    {
        public Admin_Panel()
        {
            InitializeComponent();
        }

        private void Admin_Panel_Load(object sender, EventArgs e)
        {

        }

        private void label_return_admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Welcome().Show();
        }
    }
}
