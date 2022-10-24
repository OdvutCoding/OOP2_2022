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
    public partial class Guest_page_2 : Form
    {
        public Guest_page_2()
        {
            InitializeComponent();
        }

        private void Guest_page_2_Load(object sender, EventArgs e)
        {

        }

        private void Guestpage2Next_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Guest_page_3().Show();
        }

        private void Guestpage2text1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Guestpage2Prev_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Guest_User().Show();
        }
    }
}
