namespace Course_Organizer
{
    partial class Admin_Panel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grid1 = new System.Windows.Forms.DataGridView();
            this.label_return_admin = new System.Windows.Forms.Label();
            this.grid2 = new System.Windows.Forms.DataGridView();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tx_username = new System.Windows.Forms.TextBox();
            this.label_username = new System.Windows.Forms.Label();
            this.tx_password = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.tx_usertype = new System.Windows.Forms.TextBox();
            this.usertype = new System.Windows.Forms.Label();
            this.tx_userid = new System.Windows.Forms.TextBox();
            this.label_userid = new System.Windows.Forms.Label();
            this.grid3 = new System.Windows.Forms.DataGridView();
            this.ShowAll = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.label_Admin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Count = new System.Windows.Forms.Button();
            this.AdminCoursepanel_BG = new System.Windows.Forms.PictureBox();
            this.OperationMessage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdminCoursepanel_BG)).BeginInit();
            this.SuspendLayout();
            // 
            // grid1
            // 
            this.grid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid1.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.grid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid1.GridColor = System.Drawing.Color.RoyalBlue;
            this.grid1.Location = new System.Drawing.Point(650, 149);
            this.grid1.Name = "grid1";
            this.grid1.Size = new System.Drawing.Size(586, 502);
            this.grid1.TabIndex = 29;
            // 
            // label_return_admin
            // 
            this.label_return_admin.AutoSize = true;
            this.label_return_admin.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_return_admin.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_return_admin.Location = new System.Drawing.Point(49, 680);
            this.label_return_admin.Name = "label_return_admin";
            this.label_return_admin.Size = new System.Drawing.Size(35, 48);
            this.label_return_admin.TabIndex = 37;
            this.label_return_admin.Text = "<";
            this.label_return_admin.Click += new System.EventHandler(this.label_return_admin_Click);
            // 
            // grid2
            // 
            this.grid2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid2.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.username,
            this.Password});
            this.grid2.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grid2.Location = new System.Drawing.Point(597, 282);
            this.grid2.Name = "grid2";
            this.grid2.Size = new System.Drawing.Size(227, 203);
            this.grid2.TabIndex = 29;
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "Username";
            this.username.Name = "username";
            // 
            // Password
            // 
            this.Password.DataPropertyName = "password";
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            // 
            // tx_username
            // 
            this.tx_username.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tx_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_username.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_username.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tx_username.Location = new System.Drawing.Point(67, 262);
            this.tx_username.Multiline = true;
            this.tx_username.Name = "tx_username";
            this.tx_username.Size = new System.Drawing.Size(169, 33);
            this.tx_username.TabIndex = 39;
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.Location = new System.Drawing.Point(63, 240);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(77, 23);
            this.label_username.TabIndex = 40;
            this.label_username.Text = "Username";
            // 
            // tx_password
            // 
            this.tx_password.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tx_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_password.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_password.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tx_password.Location = new System.Drawing.Point(304, 262);
            this.tx_password.Multiline = true;
            this.tx_password.Name = "tx_password";
            this.tx_password.Size = new System.Drawing.Size(169, 33);
            this.tx_password.TabIndex = 39;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.Location = new System.Drawing.Point(300, 240);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(74, 23);
            this.label_password.TabIndex = 40;
            this.label_password.Text = "Password";
            // 
            // tx_usertype
            // 
            this.tx_usertype.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tx_usertype.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_usertype.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_usertype.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tx_usertype.Location = new System.Drawing.Point(304, 418);
            this.tx_usertype.Multiline = true;
            this.tx_usertype.Name = "tx_usertype";
            this.tx_usertype.Size = new System.Drawing.Size(169, 33);
            this.tx_usertype.TabIndex = 39;
            this.tx_usertype.Visible = false;
            // 
            // usertype
            // 
            this.usertype.AutoSize = true;
            this.usertype.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertype.Location = new System.Drawing.Point(300, 396);
            this.usertype.Name = "usertype";
            this.usertype.Size = new System.Drawing.Size(68, 23);
            this.usertype.TabIndex = 40;
            this.usertype.Text = "Usertype";
            this.usertype.Visible = false;
            // 
            // tx_userid
            // 
            this.tx_userid.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tx_userid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_userid.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_userid.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tx_userid.Location = new System.Drawing.Point(67, 418);
            this.tx_userid.Multiline = true;
            this.tx_userid.Name = "tx_userid";
            this.tx_userid.Size = new System.Drawing.Size(169, 33);
            this.tx_userid.TabIndex = 39;
            this.tx_userid.Visible = false;
            // 
            // label_userid
            // 
            this.label_userid.AutoSize = true;
            this.label_userid.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_userid.Location = new System.Drawing.Point(63, 396);
            this.label_userid.Name = "label_userid";
            this.label_userid.Size = new System.Drawing.Size(51, 23);
            this.label_userid.TabIndex = 40;
            this.label_userid.Text = "UserID";
            this.label_userid.Visible = false;
            // 
            // grid3
            // 
            this.grid3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid3.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grid3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid3.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grid3.Location = new System.Drawing.Point(597, 479);
            this.grid3.Name = "grid3";
            this.grid3.Size = new System.Drawing.Size(667, 203);
            this.grid3.TabIndex = 29;
            // 
            // ShowAll
            // 
            this.ShowAll.BackgroundImage = global::Course_Organizer.Properties.Resources.Rectangle_2;
            this.ShowAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ShowAll.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ShowAll.FlatAppearance.BorderSize = 0;
            this.ShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowAll.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAll.ForeColor = System.Drawing.Color.White;
            this.ShowAll.Location = new System.Drawing.Point(349, 330);
            this.ShowAll.Name = "ShowAll";
            this.ShowAll.Size = new System.Drawing.Size(125, 33);
            this.ShowAll.TabIndex = 38;
            this.ShowAll.Text = "Show All";
            this.ShowAll.UseVisualStyleBackColor = true;
            this.ShowAll.Click += new System.EventHandler(this.ShowAll_Click);
            // 
            // Search
            // 
            this.Search.BackgroundImage = global::Course_Organizer.Properties.Resources.Rectangle_2;
            this.Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Search.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Search.FlatAppearance.BorderSize = 0;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ForeColor = System.Drawing.Color.White;
            this.Search.Location = new System.Drawing.Point(67, 190);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(125, 33);
            this.Search.TabIndex = 38;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Delete
            // 
            this.Delete.BackgroundImage = global::Course_Organizer.Properties.Resources.Rectangle_2;
            this.Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Delete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Delete.FlatAppearance.BorderSize = 0;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.Color.White;
            this.Delete.Location = new System.Drawing.Point(67, 330);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(125, 33);
            this.Delete.TabIndex = 38;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.BackgroundImage = global::Course_Organizer.Properties.Resources.Rectangle_2;
            this.Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Update.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Update.FlatAppearance.BorderSize = 0;
            this.Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.ForeColor = System.Drawing.Color.White;
            this.Update.Location = new System.Drawing.Point(349, 190);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(125, 33);
            this.Update.TabIndex = 38;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Insert
            // 
            this.Insert.BackColor = System.Drawing.Color.Transparent;
            this.Insert.BackgroundImage = global::Course_Organizer.Properties.Resources.Rectangle_2;
            this.Insert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Insert.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Insert.FlatAppearance.BorderSize = 0;
            this.Insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Insert.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert.ForeColor = System.Drawing.Color.White;
            this.Insert.Location = new System.Drawing.Point(209, 190);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(125, 33);
            this.Insert.TabIndex = 38;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = false;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // label_Admin
            // 
            this.label_Admin.AutoSize = true;
            this.label_Admin.Font = new System.Drawing.Font("Poppins Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Admin.ForeColor = System.Drawing.Color.White;
            this.label_Admin.Image = global::Course_Organizer.Properties.Resources.Royal_Blue_Rectangle;
            this.label_Admin.Location = new System.Drawing.Point(707, 28);
            this.label_Admin.Name = "label_Admin";
            this.label_Admin.Size = new System.Drawing.Size(495, 56);
            this.label_Admin.TabIndex = 28;
            this.label_Admin.Text = "Admin Dashboard : Student";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 56);
            this.label1.TabIndex = 40;
            this.label1.Text = "Available Operations";
            // 
            // Count
            // 
            this.Count.BackColor = System.Drawing.SystemColors.Control;
            this.Count.BackgroundImage = global::Course_Organizer.Properties.Resources.Rectangle_2;
            this.Count.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Count.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.Count.FlatAppearance.BorderSize = 0;
            this.Count.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Count.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Count.ForeColor = System.Drawing.Color.White;
            this.Count.Location = new System.Drawing.Point(209, 330);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(125, 33);
            this.Count.TabIndex = 42;
            this.Count.Text = "Count";
            this.Count.UseVisualStyleBackColor = false;
            this.Count.Click += new System.EventHandler(this.Count_Click);
            // 
            // AdminCoursepanel_BG
            // 
            this.AdminCoursepanel_BG.BackColor = System.Drawing.Color.RoyalBlue;
            this.AdminCoursepanel_BG.Location = new System.Drawing.Point(624, -3);
            this.AdminCoursepanel_BG.Name = "AdminCoursepanel_BG";
            this.AdminCoursepanel_BG.Size = new System.Drawing.Size(640, 2880);
            this.AdminCoursepanel_BG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.AdminCoursepanel_BG.TabIndex = 41;
            this.AdminCoursepanel_BG.TabStop = false;
            // 
            // OperationMessage
            // 
            this.OperationMessage.AutoSize = true;
            this.OperationMessage.BackColor = System.Drawing.Color.RoyalBlue;
            this.OperationMessage.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperationMessage.ForeColor = System.Drawing.Color.White;
            this.OperationMessage.Location = new System.Drawing.Point(645, 107);
            this.OperationMessage.Name = "OperationMessage";
            this.OperationMessage.Size = new System.Drawing.Size(165, 28);
            this.OperationMessage.TabIndex = 43;
            this.OperationMessage.Text = "OperationMessage";
            this.OperationMessage.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(63, 607);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 42);
            this.label2.TabIndex = 44;
            this.label2.Text = "<";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Admin_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OperationMessage);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.grid2);
            this.Controls.Add(this.grid3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_userid);
            this.Controls.Add(this.usertype);
            this.Controls.Add(this.tx_userid);
            this.Controls.Add(this.tx_usertype);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.tx_password);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.tx_username);
            this.Controls.Add(this.ShowAll);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.label_return_admin);
            this.Controls.Add(this.grid1);
            this.Controls.Add(this.label_Admin);
            this.Controls.Add(this.AdminCoursepanel_BG);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Admin_Panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Panel";
            this.Load += new System.EventHandler(this.Admin_Panel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdminCoursepanel_BG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_Admin;
        private System.Windows.Forms.DataGridView grid1;
        private System.Windows.Forms.Label label_return_admin;
        private System.Windows.Forms.DataGridView grid2;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.Button Insert;
        private new System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button ShowAll;
        private System.Windows.Forms.TextBox tx_username;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.TextBox tx_password;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox tx_usertype;
        private System.Windows.Forms.Label usertype;
        private System.Windows.Forms.TextBox tx_userid;
        private System.Windows.Forms.Label label_userid;
        private System.Windows.Forms.DataGridView grid3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Count;
        private System.Windows.Forms.PictureBox AdminCoursepanel_BG;
        private System.Windows.Forms.Label OperationMessage;
        private System.Windows.Forms.Label label2;
    }
}