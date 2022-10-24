using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Course_Organizer
{
    public partial class Signin_Form : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=XARVIS;Initial Catalog=Course Organizer;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        public static string username;
        public Signin_Form()
        {
            InitializeComponent();
        }

        private void Signin_Form_Load(object sender, EventArgs e)
        {

        }

        private void textbox_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_return_signin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Welcome().Show();
        }

        private void Button_login_Click(object sender, EventArgs e)
        {
            
            conn.Open();
            string login = "SELECT * FROM Registration WHERE username =  ' " + textbox_username.Text + " ' and password = ' " + textBox_password.Text + " ' ";
            cmd = new SqlCommand(login, conn) ;
            SqlDataReader dr = cmd. ExecuteReader();
            

            if (dr.Read() == true)
            {
                username = textbox_username.Text;
                conn.Close();
                this.Hide();
                new Form_User().Show();
            }
            else if (dr.Read() == true && username == "admin")
            {
                username = textbox_username.Text;
                conn.Close();
                this.Hide();
                new Admin_Panel().Show();
            }
            else 
            {
                MessageBox.Show("Invalid Username or Password, Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
                textbox_username.Clear();
                textBox_password.Clear();
                textbox_username.Focus();
                conn.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Admin_Panel().Show();
        }

        private void checkBoxShowpass2_CheckedChanged(object sender, EventArgs e)
        {
            textBox_password.PasswordChar = checkBoxShowpass2.Checked ? '\0' : '*';
        }
    }
}
