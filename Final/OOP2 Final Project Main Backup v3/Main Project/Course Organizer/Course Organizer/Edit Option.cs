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
    public partial class Edit_Option : Form
    {
        public Edit_Option()
        {
            InitializeComponent();
        }

        private void Button_course_editdone_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form_Browse().Show();
        }

        private void label_return_signin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form_User().Show();
        }
    }
}
