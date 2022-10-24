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

            
                //Implement Nested if-else
                //Step 1 - Empty field check
                //Step 2- Password match check
                //Step 3 - Duplicate check
                if (string.IsNullOrEmpty(txt_username.Text) && string.IsNullOrEmpty(txt_pw.Text) && string.IsNullOrEmpty(txt_pw_retype.Text))
            {
                /////////Empty Field check
                //MessageBox.Show("Username or Password fields are empty", "Sign up Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Prompt.Visible = true;
                Prompt.Text= "Username or Password fields are empty "+ " Sign up Failed";
            }
            else
            {
                if(txt_pw.Text != txt_pw_retype.Text) //txt_paw not equal txt_retype pw
                {
                    //MessageBox.Show("Passwords did not match, Please retype password correctly", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Prompt.Visible = true;
                    Prompt.Text = "Passwords did not match, Please retype password correctly "+ " Registration Failed";
                    txt_pw.Clear();
                    txt_pw_retype.Clear();
                    txt_pw.Focus();
                }
                else
                {
                    ///////////Duplicate username check 
                    /*  string sql = "select* from user_table where  username = ' " + this.txt_username.ToString()+" ' ";
                       SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["connstring"].ConnectionString);
                       sqlCon.Open();//1st step connection
                       SqlCommand sqlCom = new SqlCommand(sql, sqlCon); //2nd Query Command
                       SqlDataAdapter sdAdapter = new SqlDataAdapter(sqlCom); //3rd Execute Command
                       DataSet ds = new DataSet();
                       sdAdapter.Fill(ds); //4th store inserted input in dataset
                   */
                    sqlCon.Open();//Connection established
                    SqlCommand cmd = new SqlCommand("SELECT * FROM user_table where username=@user", sqlCon);
                        cmd.Parameters.AddWithValue("user", txt_username.Text);
                    SqlDataReader dataread;
                    dataread = cmd.ExecuteReader();
                        if (dataread.Read())
                        {
                            // MessageBox.Show("Username already exists!", "Try a different username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Prompt.Visible = true;
                            Prompt.Text = "Username already exists! "+" Try a different username";
                            sqlCon.Close();
                        }
                        else
                        {
                            ///////Finally Registering
                            sqlCon.Open();
                            SqlCommand cmd1 = new SqlCommand("INSERT INTO user_table  (username,  password, usertype) VALUES (@u, @p, @t)", sqlCon);
                            cmd1.Parameters.AddWithValue("@u", txt_username.Text);
                            cmd1.Parameters.AddWithValue("@p", txt_pw.Text);
                            cmd1.Parameters.AddWithValue("@t", 2);
                            sqlCon.Open();
                            cmd1.ExecuteNonQuery();
                            sqlCon.Close();
                            txt_username.Clear();
                            txt_pw.Clear();
                            txt_pw_retype.Clear();
                            //MessageBox.Show("Account created successfully", "Registration Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Prompt.Visible = true;
                            Prompt.Text = "Account created successfully " + " Registration Complete";
                            this.Hide();
                            new Signin_Form().Show();
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
