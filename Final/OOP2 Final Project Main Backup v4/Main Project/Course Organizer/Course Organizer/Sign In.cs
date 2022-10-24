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

      //  public static string username;
        public Signin_Form()
        {
            InitializeComponent();
        }
        public static string mycon = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
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
           // MessageBox.Show(textbox_username.ToString()); 
          //  MessageBox.Show(textBox_password.ToString());
          /*  
            try 
            {               
                if (string.IsNullOrEmpty(textbox_username.Text) && string.IsNullOrEmpty(textBox_password.Text))
                {
                    //if any field is empty then do something
                    MessageBox.Show("Username or Password fields are empty", "Sign in Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //Database Check
                SqlConnection con = new SqlConnection(mycon);
                //SqlDataAdapter sda = new SqlDataAdapter("SELECT usertype FROM user_table WHERE username =' " + this.textbox_username.Text + " ' and password =' " + this.textBox_password.Text +);
                SqlDataAdapter sda = new SqlDataAdapter("SELECT usertype FROM Test_table WHERE username like ' " + this.textbox_username.Text + " 'COLLATE SQL_Latin1_General_CP1_CS_AS   and password like ' " + this.textBox_password.Text + " ' COLLATE SQL_Latin1_General_CP1_CS_AS ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                //DataSet ds = new DataSet();
               // sda.Fill(ds);
                //if (dt.Rows.Count==1)
                if(dt.Rows.Count == 1)//(ds.Tables[0].Rows.Count==1)
                {
                    usertype = dt.Rows[0][0].ToString();
                    //int file = dt.Rows[0].Field<int>(3);
                    if(usertype=="ADMIN") // (usertype==1)
                    {
                        this.Hide();
                        new Admin_Panel().Show();
                    }
                    else
                    {
                        this.Hide();
                        new Form_User().Show();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hello! I am catch function");
            }
            finally 
            {
                MessageBox.Show("Database is such a pain");
            }*/
          
           //Lecturer's Way 
            string sql = "select * from user_table where  username = ' " +this.textbox_username.Text + " ' and password = ' " +this.textBox_password.Text + " ';   "; //this query is not even executing
            //string sql = "select * from user_table where username = 'Crust' and password = '123' ";
            SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["connstring"].ConnectionString);

            sqlCon.Open();//1st step connection
            SqlCommand sqlCom = new SqlCommand(sql, sqlCon); //2nd Query Command
            SqlDataAdapter sdAdapter = new SqlDataAdapter(sqlCom); //3rd Execute Command
            //DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            sdAdapter.Fill(dt);
            //sdAdapter.Fill(ds); //4th store inserted input in dataset 

            //if (ds.Tables[0].Rows.Count == 1)
            if(dt.Rows.Count==1)
            {
                MessageBox.Show("Login Successfull");

                //if (ds.Tables[0].Rows[0][0].ToString().Equals("ADMIN"))
                int file = dt.Rows[0].Field<int>(3);
                if (usertype ==1)
                {
                    this.Hide();
                    new Admin_Panel().Show();
                }
                else
                {
                    this.Hide();
                    new Form_User().Show();
                }
            }
            else
            {
                MessageBox.Show("Login Failed");
            }
            sqlCon.Close();
         
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

        private void Login_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form_User().Show();
         /*   MessageBox.Show("Alert");
            try
            {
                if (string.IsNullOrEmpty(textbox_username.Text) && string.IsNullOrEmpty(textBox_password.Text))
                {
                    //if any field is empty then do something
                    MessageBox.Show("Username or Password fields are empty", "Sign in Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //Database Check
                SqlConnection con = new SqlConnection(mycon);
                SqlDataAdapter sda = new SqlDataAdapter("SELECT usertype FROM user_table WHERE username ='" + this.textbox_username.Text + "'", " and password ='" + this.textBox_password.Text + "'");
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    int file = dt.Rows[0].Field<int>(3);
                    if (usertype == 1)
                    {
                        this.Hide();
                        new Admin_Panel().Show();
                    }
                    else
                    {
                        this.Hide();
                        new Form_User().Show();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }*/
        }
    }
}
