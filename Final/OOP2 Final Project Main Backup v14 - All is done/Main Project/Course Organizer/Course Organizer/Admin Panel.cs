using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //System reference to SQL Database
using System.Configuration; //System reference to Appconfig

namespace Course_Organizer
{
    public partial class Admin_Panel : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        public Admin_Panel()
        {
            InitializeComponent();
        }

        private void label_return_admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Signin_Form().Show();
        }
        private void ShowAll_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();//Connection established
                //C# Codes goes here
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Reg_table", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                //method 1 - for showing all data in a table
                grid1.DataSource = dtbl;

                //method 2 - specifying columns in gridview manually through properties
                SqlDataAdapter sqlDb = new SqlDataAdapter("SELECT * FROM Reg_table", sqlCon);
                DataTable dtb = new DataTable();
                sqlDb.Fill(dtb);
                //grid2.AutoGenerateColumns = false;
                //grid2.DataSource = dtb;
                //grid2.Visible = false;
                grid3.DataSource = dtb; //grid datasource declaration
                OperationMessage.Visible = true;
                OperationMessage.Text = "All data Shown!";
                sqlCon.Close();
            }
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                if (string.IsNullOrEmpty(tx_username.Text) && string.IsNullOrEmpty(tx_password.Text))
                {
                    OperationMessage.Visible = true;
                    OperationMessage.Text = "All required fields are empty";
                }
                else
                {
                    if (tx_username.Text.Length==0)
                    {
                        OperationMessage.Visible = true;
                        OperationMessage.Text = "Username cannot be empty";
                    }
                    else
                    {
                        if(tx_password.Text.Length==0)
                        {
                            OperationMessage.Visible = true;
                            OperationMessage.Text = "Password cannot be empty";
                        }
                        else
                        {
                            sqlCon.Open();//Connection established
                            SqlCommand cmd = new SqlCommand("INSERT INTO Reg_table  (username,  password) VALUES (@user, @pass)", sqlCon);
                            //   cmd.Parameters.AddWithValue("@id", int.Parse(tx_userid.Text));
                            cmd.Parameters.AddWithValue("@user", tx_username.Text);
                            cmd.Parameters.AddWithValue("@pass", tx_password.Text);
                            //    cmd.Parameters.AddWithValue("@type", int.Parse(tx_usertype.Text));
                            cmd.ExecuteNonQuery(); //Data entry complete
                            sqlCon.Close();
                            OperationMessage.Visible = true;
                            OperationMessage.Text = "Entry Inserted Successfully!";
                        }
                    }
                }
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                if (string.IsNullOrEmpty(tx_username.Text) && string.IsNullOrEmpty(tx_password.Text))
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
                        if (tx_password.Text.Length == 0)
                        {
                            OperationMessage.Visible = true;
                            OperationMessage.Text = "Password cannot be empty";
                        }
                        else
                        {
                            sqlCon.Open();//Connection established
                            SqlCommand cmd = new SqlCommand("UPDATE Reg_table  set  password=@pass where username=@user", sqlCon);
                            // cmd.Parameters.AddWithValue("@id", int.Parse(tx_userid.Text));
                            cmd.Parameters.AddWithValue("@user", tx_username.Text);
                            cmd.Parameters.AddWithValue("@pass", tx_password.Text);
                            cmd.ExecuteNonQuery();
                            ////////////////////////////Upto this part updates the data
                            SqlCommand cmd1 = new SqlCommand("SELECT * FROM Reg_table where username=@user", sqlCon);
                            cmd1.Parameters.AddWithValue("@user", tx_username.Text);
                            //cmd1.Parameters.AddWithValue("id", int.Parse(tx_userid.Text));
                            SqlDataAdapter da = new SqlDataAdapter(cmd1);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            grid1.DataSource = dt;
                            sqlCon.Close();
                            OperationMessage.Visible = true;
                            OperationMessage.Text = "Entry Updated Successfully!";
                            ////////////////////////////////This part shows the updated data in gridview
                        }
                    }
                }
            }
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                if (string.IsNullOrEmpty(tx_username.Text) && string.IsNullOrEmpty(tx_password.Text))
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
                        if (tx_password.Text.Length == 0)
                        {
                            OperationMessage.Visible = true;
                            OperationMessage.Text = "Password cannot be empty";
                        }
                        else
                        {
                            sqlCon.Open();//Connection established
                            SqlCommand cmd = new SqlCommand("DELETE Reg_table where username=@user", sqlCon);
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
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Reg_table where username=@user", sqlCon);
                    cmd.Parameters.AddWithValue("@user", tx_username.Text);
                    // cmd.Parameters.AddWithValue("@id", int.Parse(tx_userid.Text.ToString()));
                    SqlDataReader dataread;
                    dataread = cmd.ExecuteReader();
                    if (dataread.Read())
                    {
                        dataread.Close();
                        OperationMessage.Visible = true;
                        OperationMessage.Text = "Entry Match Found!";
                        SqlCommand cmd2 = new SqlCommand("SELECT * FROM Reg_table where username=@user", sqlCon);
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

        private void Admin_Panel_Load(object sender, EventArgs e)
        {
            grid2.Visible = false;
            grid3.Visible = false;
        }

        private void Count_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand counter = new SqlCommand("select count (*) from Reg_table ", sqlCon);
                var counting = counter.ExecuteScalar();
                OperationMessage.Text = counting.ToString();
                sqlCon.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Admin_Dashboard().Show();
        }
    }
}
