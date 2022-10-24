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
    public partial class Signin_Form : Form
    {
        //SqlConnection conn = new SqlConnection(@"Data Source=XARVIS;Initial Catalog=Course Organizer;Integrated Security=True");
        //SqlCommand cmd = new SqlCommand();
        // SqlDataAdapter da = new SqlDataAdapter();
        string connectionString = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        public static string username;
        public Signin_Form()
        {
            InitializeComponent();
        }
        //public static string mycon = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        public static int usertype;
        //public static string usertype;
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

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                //////Empty Field check
                if (string.IsNullOrEmpty(textbox_username.Text) && string.IsNullOrEmpty(textBox_password.Text))
                {
                    Prompt.Visible = true;
                    Prompt.Text = "Username or Password fields are empty " + " Sign in Failed";
                }
                else
                {
                    if(textbox_username.Text=="Admin" && textBox_password.Text=="admin")
                    {
                        this.Hide();
                        new Admin_Dashboard().Show();
                    }
                    else
                    {
                        sqlCon.Open();//Connection established
                        SqlCommand cmd = new SqlCommand("SELECT * FROM user_table where username=@user and password=@pass", sqlCon);
                        cmd.Parameters.AddWithValue("user", textbox_username.Text);
                        cmd.Parameters.AddWithValue("pass", textBox_password.Text);
                        SqlDataReader dataread;
                        dataread = cmd.ExecuteReader();
                        if (dataread.Read())
                        {
                            sqlCon.Close();
                            username = this.textbox_username.Text;
                            Prompt.Visible = true;
                            Prompt.Text = "Login Successfull.  " +this.textbox_username.Text;
                            textBox_password.Clear();
                            textbox_username.Clear();
                            this.Hide();
                            new Form_User().Show();
                        }
                    //SqlDataAdapter DatAdptr = new SqlDataAdapter("SELECT COUNT (*) FROM user_table where username=' " + this.textbox_username.Text + " 'and password=' " + this.textBox_password.Text + " '", sqlCon); ;
                    //DataTable dt = new DataTable();
                    //DatAdptr.Fill(dt);
                    //if (dt.Rows[0][0].ToString() == "1")
                    //{
                    //    sqlCon.Close();
                    //   Prompt.Visible = true;
                    //   Prompt.Text = "Login Successfull";
                    //  //this.Hide();
                    //  new Form_User().Show();

                                //}
                       else
                        {
                            Prompt.Visible = true;
                            Prompt.Text = "Incorrect credentials. Provice correct login info.";
                        }
                    }
                }
                    //{//Database match check
                    //    sqlCon.Open();//Connection established
                    //    SqlCommand cmd = new SqlCommand("SELECT * FROM user_table where username=@user and password=@pass", sqlCon);
                    //    cmd.Parameters.AddWithValue("user",textbox_username.Text);
                    //    cmd.Parameters.AddWithValue("pass",textBox_password.Text);
                    //    SqlDataReader dataread;
                    //    dataread = cmd.ExecuteReader();
                    //    if (dataread.Read())
                    //    {
                    //        dataread.Close();
                    //        //SqlCommand cmd2 = new SqlCommand("SELECT COUNT (*) user_table where username=' "+textbox_username.Text + " 'and password=' "+textBox_password.Text+ " '", sqlCon);
                    //        //cmd2.Parameters.AddWithValue("@userid", int.Parse(textbox_username.Text));
                    //        SqlDataAdapter da = new SqlDataAdapter("SELECT COUNT (*) FROM user_table where username=' " + this.textbox_username.Text + " 'and password=' " + this.textBox_password.Text + " '", sqlCon);
                    //        DataTable dt = new DataTable();
                    //        da.Fill(dt);
                    //        if(dt.Rows[0][0].ToString()=="1")
                    //        {
                    //            int file = dt.Rows[0].Field<int>(3);
                    //            if(usertype==1)
                    //            {
                    //                sqlCon.Close();
                    //                Prompt.Visible = true;
                    //                Prompt.Text = "Admin Login Successfull";
                    //                //this.Hide();
                    //                new Admin_Dashboard().Show();
                    //            }
                    //            else
                    //            {
                    //                sqlCon.Close();
                    //                Prompt.Visible = true;
                    //                Prompt.Text = "Login Successfull";
                    //                //this.Hide();
                    //                new Form_User().Show();
                    //            }
                    //        }
                    //        else
                    //        {
                    //            Prompt.Visible = true;
                    //            Prompt.Text = "User does not exist! Would you like to create an account instead?";
                    //            /*sqlCon.Open();//Connection established
                    //            SqlCommand cmd1 = new SqlCommand("SELECT * FROM user_table where username=@user and password=@pass", sqlCon);
                    //            cmd.Parameters.AddWithValue("user", textbox_username.Text);
                    //            cmd.Parameters.AddWithValue("pass", textBox_password.Text);
                    //            SqlDataReader dataread1;
                    //            dataread1 = cmd.ExecuteReader();
                    //            if (dataread1.Read())
                    //            {
                    //                sqlCon.Close();
                    //                this.Hide();
                    //                new Form_User().Show();*/
                    //        }
                    //    }
                    // }
                }
          }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Admin_Dashboard().Show();
        }

        private void checkBoxShowpass2_CheckedChanged(object sender, EventArgs e)
        {
            textBox_password.PasswordChar = checkBoxShowpass2.Checked ? '\0' : '*';
        }
    }
}
