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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }

        private void Button_Signin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Signin_Form().Show();
        }

        private void Button_SignUP_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Signup_Form().Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Guest_User().Show();
        }

        private void Button_Signin_MouseHover(object sender, EventArgs e)
        {
            Button_Signin.ForeColor = Color.Orange;
        }

        private void Button_Signin_MouseLeave(object sender, EventArgs e)
        {
            Button_Signin.ForeColor = Color.White;
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Orange;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.BlueViolet;
        }
    }
}
