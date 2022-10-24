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
    public partial class Form_Addcourse : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        public Form_Addcourse()
        {
            InitializeComponent();
        }

        private void label_return_signup_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form_User().Show();
        }

        private void Button_course_save_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                if (string.IsNullOrEmpty(tx_courseid.Text) && string.IsNullOrEmpty(combo_coursename.Text))
                {
                    //if any field is empty then do something
                    MessageBox.Show("Course Name or Course ID is invalid", "Recheck entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    sqlCon.Open();//Connection established
                    SqlCommand cmd = new SqlCommand("INSERT INTO Course_info(CourseID,CourseName,Section,Semester) VALUES(@courseid,@coursename,@section,@semester)", sqlCon);
                    cmd.Parameters.AddWithValue("@courseid", tx_courseid.Text);
                    cmd.Parameters.AddWithValue("@coursename", combo_coursename.Text.ToString());
                    cmd.Parameters.AddWithValue("@section", tx_section.Text);
                    cmd.Parameters.AddWithValue("@semester", tx_semester.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Course information of " + combo_coursename.Text + " is succesfully saved");
                    sqlCon.Close();
                    this.Hide();
                    new Form_Browse().Show();
                }
            }
        }

        private void combo_coursename_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

