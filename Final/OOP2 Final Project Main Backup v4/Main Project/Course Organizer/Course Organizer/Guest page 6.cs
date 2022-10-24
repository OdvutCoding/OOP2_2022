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
    public partial class Guest_page_6 : Form
    {
        public Guest_page_6()
        {
            InitializeComponent();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Guest_page_5().Show();
        }

        private void Guest_page_6_Load(object sender, EventArgs e)
        {

        }

        private void Guestpage6Prev_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Guest_page_5().Show();
        }

        private void Guestpage6Next_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Guest_page_7().Show();
        }
    }
}
