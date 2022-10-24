﻿using System;
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
    public partial class Admin_Panel : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        public Admin_Panel()
        {
            InitializeComponent();
        }

        private void Admin_Panel_Load(object sender, EventArgs e)
        {

        }

        private void label_return_admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Welcome().Show();
        }

        private void admin_search_Click(object sender, EventArgs e)
        {
            
        }

        private void ShowAll_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();//Connection established
                //C# Codes goes here
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM user_table", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                //method 1 - for showing all data in a table
                grid1.DataSource = dtbl;

                //method 2 - specifying columns in gridview manually through properties
                grid2.AutoGenerateColumns = false;
                grid2.DataSource = dtbl;

            }
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();//Connection established
                SqlCommand cmd = new SqlCommand("INSERT INTO user_table  (ID, username,  password, usertype) VALUES (@id,@user, @pass, @type)", sqlCon);
                cmd.Parameters.AddWithValue("@id", int.Parse(tx_userid.Text));
                cmd.Parameters.AddWithValue("@user", tx_username.Text);
                cmd.Parameters.AddWithValue("@pass", tx_password.Text);
                cmd.Parameters.AddWithValue("@type", int.Parse(tx_usertype.Text));
                cmd.ExecuteNonQuery();
                sqlCon.Close();
                MessageBox.Show("Entry Inserted Successfully");
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();//Connection established
                SqlCommand cmd = new SqlCommand("UPDATE user_table  set  username=@user,  password=@pass where ID=@id", sqlCon);
                cmd.Parameters.AddWithValue("@id", int.Parse(tx_userid.Text));
                cmd.Parameters.AddWithValue("@user", tx_username.Text);
                cmd.Parameters.AddWithValue("@pass", tx_password.Text);
                cmd.ExecuteNonQuery();
                sqlCon.Close();
                MessageBox.Show("Entry Updated Successfully");
            }
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();//Connection established
                SqlCommand cmd = new SqlCommand("DELETE user_table where ID=@id", sqlCon);
                cmd.Parameters.AddWithValue("@id", int.Parse(tx_userid.Text));
                cmd.ExecuteNonQuery();
                sqlCon.Close();
                MessageBox.Show("Entry Removed Successfully");
            }

        }

        private void Search_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();//Connection established
                SqlCommand cmd = new SqlCommand("SELECT * FROM user_table where ID=@id", sqlCon);
                cmd.Parameters.AddWithValue("id", int.Parse(tx_userid.Text));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                grid1.DataSource = dt;
            }
        }
    }
}
