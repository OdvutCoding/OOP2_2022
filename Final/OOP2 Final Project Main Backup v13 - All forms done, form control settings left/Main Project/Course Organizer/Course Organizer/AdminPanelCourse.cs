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
    public partial class AdminPanelCourse : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        public AdminPanelCourse()
        {
            InitializeComponent();
        }

        private void label_return_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Admin_Dashboard().Show();
        }

        private void ShowAll_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();//Connection established
                //C# Codes goes here
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Course_info", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                //method 1 - for showing all data in a table
                grid1.DataSource = dtbl;
                grid1.Visible = true;
                sqlCon.Close();
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                if (string.IsNullOrEmpty(tx_username.Text))
                {
                    OperationMessage.Visible = true;
                    OperationMessage.Text = "You must put a Username to search!";
                }
                else
                {
                    sqlCon.Open();//Connection established
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Course_info where username=@user", sqlCon);
                    cmd.Parameters.AddWithValue("@user", tx_username.Text);
                    // cmd.Parameters.AddWithValue("@id", int.Parse(tx_userid.Text.ToString()));
                    SqlDataReader dataread;
                    dataread = cmd.ExecuteReader();

                    if (dataread.Read())
                    {
                        dataread.Close();
                        OperationMessage.Visible = true;
                        OperationMessage.Text = "Entry Match Found!";
                        SqlCommand cmd2 = new SqlCommand("SELECT * FROM Course_info where username=@user", sqlCon);
                        cmd2.Parameters.AddWithValue("@user", tx_username.Text);
                        SqlDataAdapter da = new SqlDataAdapter(cmd2);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        grid1.DataSource = dt;
                        grid1.Visible = true;
                    }
                    else
                    {
                        grid1.Visible = false;
                        OperationMessage.Visible = true;
                        OperationMessage.Text = "Entry does not exist";
                    }
                }
            }
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                if (string.IsNullOrEmpty(tx_username.Text) && string.IsNullOrEmpty(tx_courseid.Text) && string.IsNullOrEmpty(tx_coursename.Text) && string.IsNullOrEmpty(tx_section.Text))
                {
                    OperationMessage.Visible = true;
                    OperationMessage.Text = "All required fields are empty";
                }
                else
                {
                    if (tx_username.Text.Length == 0)
                    {
                        OperationMessage.Visible = true;
                        OperationMessage.Text = "Username cannot be empty";
                    }
                    else
                    {
                        if (tx_courseid.Text.Length == 0)
                        {
                            OperationMessage.Visible = true;
                            OperationMessage.Text = "Course ID cannot be empty";
                        }
                        else
                        {
                            if (tx_coursename.Text.Length == 0)
                            {
                                OperationMessage.Visible = true;
                                OperationMessage.Text = "Course Name cannot be empty";
                            }
                            else
                            {
                                if (tx_section.Text.Length == 0)
                                {
                                    OperationMessage.Visible = true;
                                    OperationMessage.Text = "Section cannot be empty";
                                }
                                else
                                {
                                    if (tx_semester.Text.Length == 0)
                                    {
                                        OperationMessage.Visible = true;
                                        OperationMessage.Text = "Semester cannot be empty";
                                    }
                                    else
                                    {
                                        sqlCon.Open();//Connection established
                                        SqlCommand cmd = new SqlCommand("INSERT INTO Course_info  (Username,  CourseID, CourseName, Section, Semester) VALUES (@user, @cid, @cname, @sec, @sem)", sqlCon);
                                        //   cmd.Parameters.AddWithValue("@id", int.Parse(tx_userid.Text));
                                        cmd.Parameters.AddWithValue("@user", tx_username.Text);
                                        cmd.Parameters.AddWithValue("@cid", tx_courseid.Text);
                                        cmd.Parameters.AddWithValue("@cname", tx_coursename.Text);
                                        cmd.Parameters.AddWithValue("@sec", tx_section.Text);
                                        cmd.Parameters.AddWithValue("@sem", tx_semester.Text);
                                        //    cmd.Parameters.AddWithValue("@type", int.Parse(tx_usertype.Text));
                                        cmd.ExecuteNonQuery();
                                        sqlCon.Close();
                                        OperationMessage.Visible = true;
                                        OperationMessage.Text = "Entry Inserted Successfully!";
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                if (string.IsNullOrEmpty(tx_username.Text) && string.IsNullOrEmpty(tx_courseid.Text) && string.IsNullOrEmpty(tx_coursename.Text) && string.IsNullOrEmpty(tx_section.Text))
                {
                    OperationMessage.Visible = true;
                    OperationMessage.Text = "All required fields are empty";
                }
                else
                {
                    if (tx_username.Text.Length == 0)
                    {
                        OperationMessage.Visible = true;
                        OperationMessage.Text = "Username cannot be empty";
                    }
                    else
                    {
                        //Check if username exist in database
                        sqlCon.Open();
                        SqlCommand cmd1 = new SqlCommand("SELECT * FROM Course_info where username=@username", sqlCon);
                        cmd1.Parameters.AddWithValue("@username", tx_username.Text);
                        SqlDataReader dataread;
                        dataread = cmd1.ExecuteReader();
                        if (dataread.Read() is true)
                        {
                            dataread.Close();
                            OperationMessage.Visible = true;
                            OperationMessage.Text = "Username exist in database, enter other informations to update";
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
                                    OperationMessage.Text = "Course ID or Name cannot be empty.";
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
                                            cmda.Parameters.AddWithValue("@user", tx_username.Text);
                                            cmda.Parameters.AddWithValue("@cid", tx_courseid.Text);
                                            cmda.Parameters.AddWithValue("@cname", tx_coursename.Text);
                                            cmda.Parameters.AddWithValue("@sec", tx_section.Text);
                                            cmda.Parameters.AddWithValue("@sem", tx_semester.Text);
                                            cmda.ExecuteNonQuery();
                                            ////////////////////////////Upto this part updates the data
                                            SqlDataAdapter da2 = new SqlDataAdapter(cmda);
                                            DataTable dt2 = new DataTable();
                                            da2.Fill(dt2);
                                            grid1.DataSource = dt2;
                                            grid1.Visible = true;
                                            sqlCon.Close();
                                            OperationMessage.Visible = true;
                                            OperationMessage.Text = "Entry Updated Successfully!";
                                            ////////////////////////////////This part shows the updated data in gridview
                                        }
                                    }
                                }
                            }
                            else
                            {
                                dataread1.Close();
                                OperationMessage.Visible = true;
                                OperationMessage.Text = "Matching entry not found, enter correct course id";
                            }
                        }
                        else //if (dataread.Read() is false)
                        {
                            dataread.Close();
                            OperationMessage.Visible = true;
                            OperationMessage.Text = "Username does not exist in database, enter correct username to continue";
                        }
                    }
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                if (string.IsNullOrEmpty(tx_username.Text) && string.IsNullOrEmpty(tx_courseid.Text) && string.IsNullOrEmpty(tx_coursename.Text) && string.IsNullOrEmpty(tx_section.Text))
                {
                    OperationMessage.Visible = true;
                    OperationMessage.Text = "All required fields are empty";
                }
                else
                {
                    if (tx_username.Text.Length == 0)
                    {
                        OperationMessage.Visible = true;
                        OperationMessage.Text = "Username cannot be empty";
                    }
                    else
                    {
                        sqlCon.Open();//Connection established
                        SqlCommand cmd = new SqlCommand("DELETE Course_info where Username=@user", sqlCon);
                        cmd.Parameters.AddWithValue("@user", tx_username.Text);
                        //cmd.Parameters.AddWithValue("@id", int.Parse(tx_userid.Text));
                        cmd.ExecuteNonQuery();
                        sqlCon.Close();
                        OperationMessage.Visible = true;
                        OperationMessage.Text = "Entry Deleted Successfully!";
                    }
                }
            }
        }

        private void Count_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand counter = new SqlCommand("select count (*) from Course_info ", sqlCon);
                var counting = counter.ExecuteScalar();
                OperationMessage.Text = counting.ToString();
                sqlCon.Close();
            }
        }
    }
}

///////////////////////////////////////////////////////////////////////////////////
///////TRIALS AND ERRORS 
//else
//{
//    if (tx_courseid.Text.Length == 0)
//    {
//        OperationMessage.Visible = true;
//        OperationMessage.Text = "Course ID cannot be empty";
//    }
//    else
//    {
//        dataread.Close();
//        SqlCommand cmd2 = new SqlCommand("SELECT * FROM Course_info where CourseID=@courseid", sqlCon);
//        cmd1.Parameters.AddWithValue("@courseid", tx_courseid.Text);
//        //Add a datareader here for match check and then insert rest inside another if-else loop
//        SqlDataReader dataread1;
//        dataread1 = cmd1.ExecuteReader();
//        if (dataread1.Read() is true)
//        {
//            dataread1.Close();
//            OperationMessage.Visible = true;
//            OperationMessage.Text = "Matching Entry Found,  Insert other data to update";
//            ////////////////////Matching Finished, Moving  to updating checks
//        }
//        else if (dataread1.Read() is false)
//        {
//            dataread1.Close();
//            OperationMessage.Visible = true;
//            OperationMessage.Text = "Matching entry not Found,  please insert correct course id";
//        }
//        else
//        {
//            if (tx_coursename.Text.Length == 0)
//            {
//                OperationMessage.Visible = true;
//                OperationMessage.Text = "Course Name cannot be empty.";
//            }
//            else
//            {
//                if (tx_section.Text.Length == 0)
//                {
//                    OperationMessage.Visible = true;
//                    OperationMessage.Text = "Section cannot be empty.";
//                }
//                else
//                {
//                    if (tx_semester.Text.Length == 0)
//                    {
//                        OperationMessage.Visible = true;
//                        OperationMessage.Text = "Semester cannot be empty.";
//                    }
//                    else
//                    {
//                        // dataread.Close();
//                        // sqlCon.Open();//Connection established
//                        SqlCommand cmd = new SqlCommand("UPDATE Course_info  set  CourseID=@cid, CourseName=@cname, Section=@sec, Semester =@sem where username=@user", sqlCon);
//                        // cmd.Parameters.AddWithValue("@id", int.Parse(tx_userid.Text));
//                        cmd.Parameters.AddWithValue("@user", tx_username.Text);
//                        cmd.Parameters.AddWithValue("@cid", tx_courseid.Text);
//                        cmd.Parameters.AddWithValue("@cname", tx_coursename.Text);
//                        cmd.Parameters.AddWithValue("@sec", tx_section.Text);
//                        cmd.Parameters.AddWithValue("@sem", tx_semester.Text);
//                        cmd.ExecuteNonQuery();
//                        ////////////////////////////Upto this part updates the data
//                        SqlDataAdapter da = new SqlDataAdapter(cmd);
//                        DataTable dt = new DataTable();
//                        da.Fill(dt);
//                        grid1.DataSource = dt;
//                        grid1.Visible = true;
//                        OperationMessage.Visible = true;
//                        OperationMessage.Text = "Entry Updated Successfully!";
//                        ////////////////////////////////This part shows the updated data in gridview



//using (SqlConnection sqlCon = new SqlConnection(connectionString))
//{
//    if (string.IsNullOrEmpty(tx_username.Text) && string.IsNullOrEmpty(tx_courseid.Text) && string.IsNullOrEmpty(tx_coursename.Text) && string.IsNullOrEmpty(tx_section.Text))
//    {
//        OperationMessage.Visible = true;
//        OperationMessage.Text = "All required fields are empty";
//    }
//    else
//    {
//        if (tx_username.Text.Length == 0)
//        {
//            OperationMessage.Visible = true;
//            OperationMessage.Text = "Username cannot be empty";
//        }
//        else
//        {
//            //Check if username exist in database
//            sqlCon.Open();
//            SqlCommand cmd1 = new SqlCommand("SELECT * FROM Course_info where username=@username", sqlCon);
//            cmd1.Parameters.AddWithValue("@username", tx_username.Text);
//            //Add a datareader here for match check and then insert rest inside another if-else loop
//            SqlDataReader dataread;
//            dataread = cmd1.ExecuteReader();
//            if (dataread.Read())
//            {
//                dataread.Close();
//                OperationMessage.Visible = true;
//                OperationMessage.Text = "Username exist in database, enter Course ID to continue";
//                //Again checking course ID with another if statement and reader
//                if (tx_courseid.Text.Length == 0)
//                {
//                    OperationMessage.Visible = true;
//                    OperationMessage.Text = "Course ID cannot be empty";
//                }
//                else
//                {
//                    dataread.Close();
//                    SqlCommand cmd2 = new SqlCommand("SELECT * FROM Course_info where CourseID=@courseid", sqlCon);
//                    cmd1.Parameters.AddWithValue("@courseid", tx_courseid.Text);
//                    //Add a datareader here for match check and then insert rest inside another if-else loop
//                    SqlDataReader dataread1;
//                    dataread1 = cmd1.ExecuteReader();
//                    if (dataread1.Read())
//                    {
//                        dataread1.Close();
//                        OperationMessage.Visible = true;
//                        OperationMessage.Text = "Matching Entry Found,  Insert other data to update";
//                        ////////////////////Matching Finished, Moving  to updating checks

//                        if (tx_coursename.Text.Length == 0)
//                        {
//                            OperationMessage.Visible = true;
//                            OperationMessage.Text = "Course Name cannot be empty.";
//                        }
//                        else
//                        {
//                            if (tx_section.Text.Length == 0)
//                            {
//                                OperationMessage.Visible = true;
//                                OperationMessage.Text = "Section cannot be empty.";
//                            }
//                            else
//                            {
//                                if (tx_semester.Text.Length == 0)
//                                {
//                                    OperationMessage.Visible = true;
//                                    OperationMessage.Text = "Semester cannot be empty.";
//                                }
//                                else
//                                {
//                                    // dataread.Close();
//                                    // sqlCon.Open();//Connection established
//                                    SqlCommand cmd = new SqlCommand("UPDATE Course_info  set  CourseID=@cid, CourseName=@cname, Section=@sec, Semester =@sem where username=@user", sqlCon);
//                                    // cmd.Parameters.AddWithValue("@id", int.Parse(tx_userid.Text));
//                                    cmd.Parameters.AddWithValue("@user", tx_username.Text);
//                                    cmd.Parameters.AddWithValue("@cid", tx_courseid.Text);
//                                    cmd.Parameters.AddWithValue("@cname", tx_coursename.Text);
//                                    cmd.Parameters.AddWithValue("@sec", tx_section.Text);
//                                    cmd.Parameters.AddWithValue("@sem", tx_semester.Text);
//                                    cmd.ExecuteNonQuery();
//                                    ////////////////////////////Upto this part updates the data
//                                    SqlDataAdapter da = new SqlDataAdapter(cmd);
//                                    DataTable dt = new DataTable();
//                                    da.Fill(dt);
//                                    grid1.DataSource = dt;
//                                    grid1.Visible = true;
//                                    OperationMessage.Visible = true;
//                                    OperationMessage.Text = "Entry Updated Successfully!";
//                                    ////////////////////////////////This part shows the updated data in gridview               
//                                }
//                            }
//                        }
//                    }
//                    else
//                    {
//                        dataread1.Close();
//                        OperationMessage.Visible = true;
//                        OperationMessage.Text = "Entry match not found, Halting Update.";
//                    }
//                }
//            }
//            //    if (tx_courseid.Text.Length == 0)
//            //{
//            //    OperationMessage.Visible = true;
//            //    OperationMessage.Text = "Course ID cannot be empty";
//            //}
//            //else
//            //{
//            //    sqlCon.Open();
//            //    SqlCommand cmd1 = new SqlCommand("SELECT * FROM Course_info where username=@username", sqlCon);
//            //    cmd1.Parameters.AddWithValue("@username", tx_username.Text);
//            //    //Add a datareader here for match check and then insert rest inside another if-else loop
//            //    SqlDataReader dataread;
//            //    dataread = cmd1.ExecuteReader();
//            //    if (dataread.Read())
//            //    {

//            //    }
//             }
//         }
//    }
// }

