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
    public partial class Edit_Option : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        public Edit_Option()
        {
            InitializeComponent();
        }

        private void Button_course_editdone_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                if (string.IsNullOrEmpty(tx_courseid.Text) && string.IsNullOrEmpty(tx_coursename.Text) && string.IsNullOrEmpty(tx_section.Text))
                {
                    OperationMessage.Visible = true;
                    OperationMessage.Text = "All fields are empty";
                }
                else
                {
                    if (tx_coursename.Text.Length == 0)
                    {
                        OperationMessage.Visible = true;
                        OperationMessage.Text = "Course name cannot be empty";
                    }
                    else
                    {
                        //Check if username exist in database
                        sqlCon.Open();
                        SqlCommand cmd1 = new SqlCommand("SELECT * FROM Course_info where username=@username", sqlCon);
                        cmd1.Parameters.AddWithValue("@username", Signin_Form.username);
                        SqlDataReader dataread;
                        dataread = cmd1.ExecuteReader();
                        if (dataread.Read() is true)
                        {
                            dataread.Close();
                           // OperationMessage.Visible = true;
                           // OperationMessage.Text = "Username exist in database, enter other informations to update";
                            //SqlCommand cmd = new SqlCommand("SELECT * FROM Course_info where username=' " + this.tx_username.Text+  " '", sqlCon);
                            //SqlDataAdapter da = new SqlDataAdapter(cmd);
                            //DataTable dt = new DataTable();
                            //da.Fill(dt);
                            //grid1.DataSource = dt;
                            //grid1.Visible = true;

                            SqlCommand cmd2 = new SqlCommand("SELECT * FROM Course_info where CourseID=@courseid", sqlCon);
                            cmd1.Parameters.AddWithValue("@courseid", tx_courseid.Text);
                            //Add a datareader here for match check and then insert rest inside another if-else loop
                            SqlDataReader dataread1;
                            dataread1 = cmd1.ExecuteReader();
                            if (dataread1.Read() is true)
                            {
                                dataread1.Close();
                                //OperationMessage.Visible = true;
                                //OperationMessage.Text = "Course ID Found, enter other informations to continue";

                                if (tx_coursename.Text.Length == 0 || tx_courseid.Text.Length == 0)
                                {
                                    OperationMessage.Visible = true;
                                    OperationMessage.Text = "Course ID or course name cannot be empty.";
                                }
                                else
                                {
                                    if (tx_section.Text.Length == 0)
                                    {
                                        OperationMessage.Visible = true;
                                        OperationMessage.Text = "Section cannot be empty.";
                                    }
                                    else
                                    {
                                        if (tx_semester.Text.Length == 0)
                                        {
                                            OperationMessage.Visible = true;
                                            OperationMessage.Text = "Semester cannot be empty.";
                                        }
                                        else
                                        {
                                            // dataread.Close();
                                            // sqlCon.Open();//Connection established
                                            SqlCommand cmda = new SqlCommand("UPDATE Course_info  set  CourseID=@cid, CourseName=@cname, Section=@sec, Semester =@sem where username=@user", sqlCon);
                                            // cmd.Parameters.AddWithValue("@id", int.Parse(tx_userid.Text));
                                            cmda.Parameters.AddWithValue("@user", Signin_Form.username);
                                            cmda.Parameters.AddWithValue("@cid", tx_courseid.Text);
                                            cmda.Parameters.AddWithValue("@cname", tx_coursename.Text);
                                            cmda.Parameters.AddWithValue("@sec", tx_section.Text);
                                            cmda.Parameters.AddWithValue("@sem", tx_semester.Text);
                                            cmda.ExecuteNonQuery();
                                            ////////////////////////////Upto this part updates the data
                                            SqlDataAdapter da2 = new SqlDataAdapter(cmda);
                                            DataTable dt2 = new DataTable();
                                            da2.Fill(dt2);
                                            // grid1.DataSource = dt2;
                                            // grid1.Visible = true;
                                            //OperationMessage.Visible = true;
                                            //OperationMessage.Text = "Course Edited Successfully!";
                                            MessageBox.Show("Course Edited Successfully");
                                            this.Hide();
                                            new Form_Browse().Show();
                                            ////////////////////////////////Edit complete
                                        }
                                    }
                                }
                            }
                            else
                            {
                                dataread1.Close();
                                OperationMessage.Visible = true;
                                OperationMessage.Text = "Course id not found, enter correct course id";
                            }
                        }
                        else //if (dataread.Read() is false)
                        {
                            dataread.Close();
                            OperationMessage.Visible = true;
                            OperationMessage.Text = "You don't seem to have this course added yet";
                        }
                    }
                }
            }
        }

        private void label_return_signin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form_User().Show();
        }
    }
}
