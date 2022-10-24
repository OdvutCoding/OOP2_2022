namespace Course_Organizer
{
    partial class AdminPanelCourse
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
            this.AdminCoursepanel_BG = new System.Windows.Forms.PictureBox();
            this.grid1 = new System.Windows.Forms.DataGridView();
            this.label_AdminCourse = new System.Windows.Forms.Label();
            this.label_admincourseoptions = new System.Windows.Forms.Label();
            this.label_courseid = new System.Windows.Forms.Label();
            this.coursename = new System.Windows.Forms.Label();
            this.tx_userid = new System.Windows.Forms.TextBox();
            this.tx_usertype = new System.Windows.Forms.TextBox();
            this.section = new System.Windows.Forms.Label();
            this.tx_password = new System.Windows.Forms.TextBox();
            this.label_username = new System.Windows.Forms.Label();
            this.tx_username = new System.Windows.Forms.TextBox();
            this.ShowAll = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.label_return = new System.Windows.Forms.Label();
            this.Count = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AdminCoursepanel_BG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminCoursepanel_BG
            // 
            this.AdminCoursepanel_BG.BackColor = System.Drawing.Color.RoyalBlue;
            this.AdminCoursepanel_BG.Location = new System.Drawing.Point(624, 1);
            this.AdminCoursepanel_BG.Name = "AdminCoursepanel_BG";
            this.AdminCoursepanel_BG.Size = new System.Drawing.Size(640, 2880);
            this.AdminCoursepanel_BG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.AdminCoursepanel_BG.TabIndex = 7;
            this.AdminCoursepanel_BG.TabStop = false;
            // 
            // grid1
            // 
            this.grid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid1.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.grid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid1.GridColor = System.Drawing.Color.RoyalBlue;
            this.grid1.Location = new System.Drawing.Point(653, 127);
            this.grid1.Name = "grid1";
            this.grid1.Size = new System.Drawing.Size(586, 531);
            this.grid1.TabIndex = 31;
            // 
            // label_AdminCourse
            // 
            this.label_AdminCourse.AutoSize = true;
            this.label_AdminCourse.Font = new System.Drawing.Font("Poppins Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AdminCourse.ForeColor = System.Drawing.Color.White;
            this.label_AdminCourse.Image = global::Course_Organizer.Properties.Resources.Royal_Blue_Rectangle;
            this.label_AdminCourse.Location = new System.Drawing.Point(693, 36);
            this.label_AdminCourse.Name = "label_AdminCourse";
            this.label_AdminCourse.Size = new System.Drawing.Size(482, 56);
            this.label_AdminCourse.TabIndex = 30;
            this.label_AdminCourse.Text = "Admin Dashboard : Course";
            // 
            // label_admincourseoptions
            // 
            this.label_admincourseoptions.AutoSize = true;
            this.label_admincourseoptions.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_admincourseoptions.Location = new System.Drawing.Point(63, 36);
            this.label_admincourseoptions.Name = "label_admincourseoptions";
            this.label_admincourseoptions.Size = new System.Drawing.Size(361, 56);
            this.label_admincourseoptions.TabIndex = 51;
            this.label_admincourseoptions.Text = "Available Operations";
            // 
            // label_courseid
            // 
            this.label_courseid.AutoSize = true;
            this.label_courseid.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_courseid.Location = new System.Drawing.Point(306, 271);
            this.label_courseid.Name = "label_courseid";
            this.label_courseid.Size = new System.Drawing.Size(71, 23);
            this.label_courseid.TabIndex = 52;
            this.label_courseid.Text = "Course ID";
            // 
            // coursename
            // 
            this.coursename.AutoSize = true;
            this.coursename.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursename.Location = new System.Drawing.Point(69, 360);
            this.coursename.Name = "coursename";
            this.coursename.Size = new System.Drawing.Size(98, 23);
            this.coursename.TabIndex = 53;
            this.coursename.Text = "Course Name";
            // 
            // tx_userid
            // 
            this.tx_userid.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tx_userid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_userid.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_userid.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tx_userid.Location = new System.Drawing.Point(310, 293);
            this.tx_userid.Multiline = true;
            this.tx_userid.Name = "tx_userid";
            this.tx_userid.Size = new System.Drawing.Size(169, 33);
            this.tx_userid.TabIndex = 47;
            // 
            // tx_usertype
            // 
            this.tx_usertype.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tx_usertype.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_usertype.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_usertype.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tx_usertype.Location = new System.Drawing.Point(73, 382);
            this.tx_usertype.Multiline = true;
            this.tx_usertype.Name = "tx_usertype";
            this.tx_usertype.Size = new System.Drawing.Size(169, 33);
            this.tx_usertype.TabIndex = 48;
            // 
            // section
            // 
            this.section.AutoSize = true;
            this.section.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.section.Location = new System.Drawing.Point(306, 360);
            this.section.Name = "section";
            this.section.Size = new System.Drawing.Size(58, 23);
            this.section.TabIndex = 54;
            this.section.Text = "Section";
            // 
            // tx_password
            // 
            this.tx_password.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tx_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_password.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_password.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tx_password.Location = new System.Drawing.Point(310, 382);
            this.tx_password.Multiline = true;
            this.tx_password.Name = "tx_password";
            this.tx_password.Size = new System.Drawing.Size(169, 33);
            this.tx_password.TabIndex = 49;
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.Location = new System.Drawing.Point(69, 271);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(77, 23);
            this.label_username.TabIndex = 55;
            this.label_username.Text = "Username";
            // 
            // tx_username
            // 
            this.tx_username.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tx_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_username.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_username.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tx_username.Location = new System.Drawing.Point(73, 293);
            this.tx_username.Multiline = true;
            this.tx_username.Name = "tx_username";
            this.tx_username.Size = new System.Drawing.Size(169, 33);
            this.tx_username.TabIndex = 50;
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
            this.ShowAll.Location = new System.Drawing.Point(73, 470);
            this.ShowAll.Name = "ShowAll";
            this.ShowAll.Size = new System.Drawing.Size(125, 33);
            this.ShowAll.TabIndex = 41;
            this.ShowAll.Text = "Show All";
            this.ShowAll.UseVisualStyleBackColor = true;
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
            this.Search.Location = new System.Drawing.Point(355, 198);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(125, 33);
            this.Search.TabIndex = 42;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
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
            this.Delete.Location = new System.Drawing.Point(355, 470);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(125, 33);
            this.Delete.TabIndex = 43;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
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
            this.Update.Location = new System.Drawing.Point(215, 198);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(125, 33);
            this.Update.TabIndex = 45;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
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
            this.Insert.Location = new System.Drawing.Point(73, 198);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(125, 33);
            this.Insert.TabIndex = 46;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = false;
            // 
            // label_return
            // 
            this.label_return.AutoSize = true;
            this.label_return.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_return.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_return.Location = new System.Drawing.Point(65, 570);
            this.label_return.Name = "label_return";
            this.label_return.Size = new System.Drawing.Size(35, 48);
            this.label_return.TabIndex = 56;
            this.label_return.Text = "<";
            this.label_return.Click += new System.EventHandler(this.label_return_Click);
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
            this.Count.Location = new System.Drawing.Point(215, 470);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(125, 33);
            this.Count.TabIndex = 57;
            this.Count.Text = "Count";
            this.Count.UseVisualStyleBackColor = false;
            // 
            // AdminPanelCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.label_return);
            this.Controls.Add(this.label_admincourseoptions);
            this.Controls.Add(this.label_courseid);
            this.Controls.Add(this.coursename);
            this.Controls.Add(this.tx_userid);
            this.Controls.Add(this.tx_usertype);
            this.Controls.Add(this.section);
            this.Controls.Add(this.tx_password);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.tx_username);
            this.Controls.Add(this.ShowAll);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.grid1);
            this.Controls.Add(this.label_AdminCourse);
            this.Controls.Add(this.AdminCoursepanel_BG);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminPanelCourse";
            this.Text = "AdminPanelCourse";
            ((System.ComponentModel.ISupportInitialize)(this.AdminCoursepanel_BG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox AdminCoursepanel_BG;
        private System.Windows.Forms.DataGridView grid1;
        private System.Windows.Forms.Label label_AdminCourse;
        private System.Windows.Forms.Label label_admincourseoptions;
        private System.Windows.Forms.Label label_courseid;
        private System.Windows.Forms.Label coursename;
        private System.Windows.Forms.TextBox tx_userid;
        private System.Windows.Forms.TextBox tx_usertype;
        private System.Windows.Forms.Label section;
        private System.Windows.Forms.TextBox tx_password;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.TextBox tx_username;
        private System.Windows.Forms.Button ShowAll;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Delete;
        private new System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Label label_return;
        private System.Windows.Forms.Button Count;
    }
}