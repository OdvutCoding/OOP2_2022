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
using System.Configuration;

namespace Course_Organizer
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }
        static string mycon = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        public static string usertype;
        //public static string username;
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (textbox_user.Text == " " || textbox_pass.Text == " ")
            {
                MessageBox.Show("Username or Password field is empty", "Please fill them", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                SqlConnection con = new SqlConnection(mycon);
                con.Open();
                SqlDataAdapter command = new SqlDataAdapter("SELECT usertype FROM user_table WHERE username like ' " + textbox_user.Text + " ' COLLATE SQL_Latin_General_CP1_CS_AS and password like ' " + textbox_pass + " ' COLLATE SQL_Latin_General_CP1_CS_AS  ", con);
                DataTable dt = new DataTable();
                command.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    usertype = dt.Rows[0][0].ToString();
                    if (usertype == "ADMIN")
                    {
                        con.Close();
                        //username = textbox_username.Text;
                        this.Hide();
                        new Admin_Panel().Show();

                    }
                    else if (usertype == "USER")
                    {
                        con.Close();
                        //username = textbox_username.Text;
                        this.Hide();
                        new Form_User().Show();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Username and Password");
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void showpasscheck_CheckedChanged(object sender, EventArgs e)
        {
            if (showpasscheck.Checked == true)
            {
                textbox_pass.UseSystemPasswordChar = false;
            }
            else
            {
                textbox_pass.UseSystemPasswordChar = true;
            }
        }

        private void SignIn_Load(object sender, EventArgs e)
        {
            textbox_user.Focus();
        }
    }
}
