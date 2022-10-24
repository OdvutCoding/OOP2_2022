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
    public partial class Signup_Form : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=XARVIS;Initial Catalog=Course Organizer;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        public Signup_Form()
        {
            InitializeComponent();
        }

        private void label_Password_Click(object sender, EventArgs e)
        {

        }

        private void label_return_signup_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Welcome().Show();
        }

        private void Button_agree_continue_Click_1(object sender, EventArgs e)
        {
            if (txt_username.Text == " " && txt_pw.Text == " " && txt_pw_retype.Text == " ")
            {
                MessageBox.Show("Username & Password fields are empty", "Sign up Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_pw.Text == txt_pw_retype.Text)
            {
                conn.Open();
                string register = "INSERT INTO Registration VALUES  (' " +txt_username.Text + " ' , ' "+txt_pw.Text+" ')";
                cmd = new SqlCommand(register, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                txt_username.Clear();
                txt_pw.Clear();
                txt_pw_retype.Clear();
                //txt_username.Text = " ";
                //txt_pw.Text = " ";
                //txt_pw_retype.Text = " ";

                MessageBox.Show("Account created successfully","Registration Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                new Signin_Form().Show();
            }
            else if(txt_username.Text == "Admin")
            {
                MessageBox.Show("You cannot create an account named Admin", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_username.Clear();
                txt_username.Focus();
            }
            else
            {
                MessageBox.Show("Passwords did not match, Please retype password correctly", "Registration Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txt_pw.Clear();
                txt_pw_retype.Clear();
                txt_pw.Focus();
            }
        }

        private void Signup_Form_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txt_pw.PasswordChar = checkBoxShowPass.Checked ? '\0' : '*';
            txt_pw_retype.PasswordChar = checkBoxShowPass.Checked ? '\0': '*';
        }

        private void Clear_signup_Click(object sender, EventArgs e)
        {
            txt_username.Text = " ";
            txt_pw.Text = " ";
            txt_pw_retype.Text = " ";
            txt_username.Focus();
        }
    }
}
