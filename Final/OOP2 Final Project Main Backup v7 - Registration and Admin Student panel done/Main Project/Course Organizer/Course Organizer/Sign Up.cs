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
    public partial class Signup_Form : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        //SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connstring"].ConnectionString);
        // SqlConnection conn = new SqlConnection(@"Data Source=XARVIS;Initial Catalog=Course Organizer;Integrated Security=True");
      //  SqlCommand cmd = new SqlCommand();
        //SqlDataAdapter da = new SqlDataAdapter();
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
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                if (string.IsNullOrEmpty(txt_username.Text) && string.IsNullOrEmpty(txt_pw.Text) && string.IsNullOrEmpty(txt_pw_retype.Text))
                {
                    /////////Step 1 : Empty Field check - all field
                    Prompt.Visible = true;
                    Prompt.Text = "Username and Password fields are empty. " + " Sign up Failed.";
                }
                else
                {
                    if(txt_username.Text.Length==0)
                    {
                        Prompt.Visible = true;
                        Prompt.Text = "Username field is empty. " + " Input Username.";
                    }
                    else
                    {
                        if(txt_pw.Text.Length==0 || txt_pw_retype.Text.Length==0)
                        {
                            Prompt.Visible = true;
                            Prompt.Text = "Any of the password field is empty. " + " Input Password.";
                        }
                        else
                        {
                            sqlCon.Open();//Connection established
                            SqlCommand cmd = new SqlCommand("SELECT * FROM Reg_table where username=@user", sqlCon);
                            cmd.Parameters.AddWithValue("user", txt_username.Text);
                            SqlDataReader dataread;
                            dataread = cmd.ExecuteReader();
                            if (dataread.Read())
                            {
                                // MessageBox.Show("Username already exists!", "Try a different username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                sqlCon.Close();
                                Prompt.Visible = true;
                                Prompt.Text = "Username already exists! " + " Try a different username";
                            }
                            else
                            {
                                ///////Finally Registering
                                dataread.Close();
                                SqlCommand cmd1 = new SqlCommand("INSERT INTO Reg_table  (username,  password) VALUES (@u, @p)", sqlCon);
                                cmd1.Parameters.AddWithValue("@u", this.txt_username.Text);
                                cmd1.Parameters.AddWithValue("@p", this.txt_pw.Text);
                                cmd1.ExecuteNonQuery();
                                sqlCon.Close();
                                txt_username.Clear();
                                txt_pw.Clear();
                                txt_pw_retype.Clear();
                                MessageBox.Show("Account created successfully", "Registration Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //Prompt.Visible = true;
                               // Prompt.Text = "Account created successfully " + " Registration Complete";
                                this.Hide();
                                new Signin_Form().Show();
                            }
                        }
                    }
                }
            }
        }

        private void Signup_Form_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txt_pw.PasswordChar = checkBoxShowPass.Checked ? '\0' : '*';
            txt_pw_retype.PasswordChar = checkBoxShowPass.Checked ? '\0' : '*';
        }

        private void Clear_signup_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_pw.Clear();
            txt_pw_retype.Clear();
            txt_username.Focus();
        }
    }
}
