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
    public partial class Guest_page_7 : Form
    {
        public Guest_page_7()
        {
            InitializeComponent();
        }

        private void Label_CTA_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Signup_Form().Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Signin_Form().Show();
        }

        private void Label_CTA_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.RoyalBlue;
            Label_CTA.ForeColor = Color.White;
            label1.ForeColor = Color.White;
            label2.ForeColor=Color.White;
        }

        private void Label_CTA_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.White;
            Label_CTA.ForeColor = Color.SteelBlue;
            label1.ForeColor = Color.RoyalBlue;
            label2.ForeColor = Color.SteelBlue;
        }

        private void Guest_page_7_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.White;
            Label_CTA.ForeColor = Color.SteelBlue;
            label1.ForeColor = Color.RoyalBlue;
            label2.ForeColor = Color.SteelBlue;
        }
    }
}
