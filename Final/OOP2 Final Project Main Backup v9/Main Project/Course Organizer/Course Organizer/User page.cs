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
    public partial class Form_User : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        public Form_User()
        {
            InitializeComponent();
        }
        public static string user;

        private void label_logoutuserform_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Welcome().Show();
        }

        private void Button_Addcourse_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("select Username from Course_info where Username=@user",sqlCon);
                cmd.Parameters.AddWithValue("user", label_User.Text);
                SqlDataReader nrd = cmd.ExecuteReader();
                if(nrd.Read())
                {
                    sqlCon.Close();
                    MessageBox.Show("Maximum limit for adding course reached. Edit course instead");
                }
                else
                {
                    this.Hide();
                    new Form_Addcourse().Show();
                }
            }
        }

        private void Button_Browsecourse_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form_Browse().Show();
        }

        private void Button_Editcourse_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Edit_Option().Show();
        }

        private void label_User_Click(object sender, EventArgs e)
        {
            
        }

        private void Form_User_Load(object sender, EventArgs e)
        {
           label_User.Text = Signin_Form.username;
            user = label_User.Text;
        }
    }
}
