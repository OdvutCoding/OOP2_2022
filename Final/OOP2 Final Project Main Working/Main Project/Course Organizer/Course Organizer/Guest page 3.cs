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
    public partial class Guest_page_3 : Form
    {
        public Guest_page_3()
        {
            InitializeComponent();
        }

        private void Guestpage3Prev_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Welcome().Show();
        }

        private void Guestpage3Next_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Guest_page_4().Show();
        }
    }
}
