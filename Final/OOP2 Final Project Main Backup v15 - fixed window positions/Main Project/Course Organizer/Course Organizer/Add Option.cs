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
                //Implemented nested if-else
                if (string.IsNullOrEmpty(combo_courseid.Text) && string.IsNullOrEmpty(combo_coursename.Text)) //All field empty or null check
                {
                    //if any field is empty then do something
                   // MessageBox.Show("Course Name or Course ID is invalid", "Recheck entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Prompt.Visible = true;
                    Prompt.Text = "Course Name or Course ID is invalid. Recheck entry.";
                }
                else
                {
                    if(combo_coursename.Text.Length==0)
                    {
                        Prompt.Visible = true;
                        Prompt.Text = "Course name is empty. Please select a course name.";
                    }
                    else 
                    {
                        if (combo_courseid.Text.Length == 0) //Course ID empty check
                        {
                            Prompt.Visible = true;
                            Prompt.Text = "Course ID is empty. Please select a course ID.";
                        }
                        else
                        {
                            if (combo_section.Text.Length == 0) //Section empty check
                            {
                                Prompt.Visible = true;
                                Prompt.Text = "Please select a section.";
                            }
                            else
                            {
                                if(combo_semester.Text.Length==0)
                                {
                                    Prompt.Visible = true;
                                    Prompt.Text = "Please select a semester.";
                                }
                                else
                                {
                                    //Data insertion started
                                    /////////////////////////////////////////////////////////////////////////////
                                    sqlCon.Open();//Connection established
                                                  //Defining sql query for connected database
                                    SqlCommand cmd = new SqlCommand("INSERT INTO Course_info(Username,CourseID,CourseName,Section,Semester) VALUES(@user,@courseid,@coursename,@section,@semester)", sqlCon);
                                    //Retreiving value from set fields
                                    cmd.Parameters.AddWithValue("@user", Form_User.user);
                                    cmd.Parameters.AddWithValue("@courseid", combo_courseid.Text);
                                    cmd.Parameters.AddWithValue("@coursename", combo_coursename.Text.ToString());
                                    cmd.Parameters.AddWithValue("@section", combo_coursename.Text);
                                    cmd.Parameters.AddWithValue("@semester", combo_semester.Text);
                                    //Query execution
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Course information of " + combo_coursename.Text + " is succesfully saved");
                                    sqlCon.Close(); //Connection closed
                                                    //Data insertion completed
                                                    //Moving into browse form
                                    this.Hide();
                                    new Form_Browse().Show();
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

