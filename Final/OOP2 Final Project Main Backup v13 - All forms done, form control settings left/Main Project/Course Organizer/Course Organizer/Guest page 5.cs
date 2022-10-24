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
    public partial class Guest_page_5 : Form
    {
        public Guest_page_5()
        {
            InitializeComponent();
        }

        private void Guestpage3text1_Click(object sender, EventArgs e)
        {

        }

        private void Guestpage5Next_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Guest_page_6().Show();
        }

        private void Guestpage5Prev_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Guest_page_4().Show();
        }
    }
}
