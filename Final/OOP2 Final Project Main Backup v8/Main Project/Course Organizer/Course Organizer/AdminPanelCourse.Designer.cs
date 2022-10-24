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
            this.tx_courseid = new System.Windows.Forms.TextBox();
            this.tx_coursename = new System.Windows.Forms.TextBox();
            this.section = new System.Windows.Forms.Label();
            this.tx_section = new System.Windows.Forms.TextBox();
            this.label_username = new System.Windows.Forms.Label();
            this.tx_username = new System.Windows.Forms.TextBox();
            this.ShowAll = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.label_return = new System.Windows.Forms.Label();
            this.Count = new System.Windows.Forms.Button();
            this.OperationMessage = new System.Windows.Forms.Label();
            this.tx_semester = new System.Windows.Forms.TextBox();
            this.Semester = new System.Windows.Forms.Label();
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
            this.grid1.Location = new System.Drawing.Point(653, 174);
            this.grid1.Name = "grid1";
            this.grid1.Size = new System.Drawing.Size(586, 484);
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
            // tx_courseid
            // 
            this.tx_courseid.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tx_courseid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_courseid.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_courseid.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tx_courseid.Location = new System.Drawing.Point(310, 293);
            this.tx_courseid.Multiline = true;
            this.tx_courseid.Name = "tx_courseid";
            this.tx_courseid.Size = new System.Drawing.Size(169, 33);
            this.tx_courseid.TabIndex = 47;
            // 
            // tx_coursename
            // 
            this.tx_coursename.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tx_coursename.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_coursename.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_coursename.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tx_coursename.Location = new System.Drawing.Point(73, 382);
            this.tx_coursename.Multiline = true;
            this.tx_coursename.Name = "tx_coursename";
            this.tx_coursename.Size = new System.Drawing.Size(169, 33);
            this.tx_coursename.TabIndex = 48;
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
            // tx_section
            // 
            this.tx_section.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tx_section.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_section.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_section.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tx_section.Location = new System.Drawing.Point(310, 382);
            this.tx_section.Multiline = true;
            this.tx_section.Name = "tx_section";
            this.tx_section.Size = new System.Drawing.Size(169, 33);
            this.tx_section.TabIndex = 49;
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
            this.ShowAll.Location = new System.Drawing.Point(354, 521);
            this.ShowAll.Name = "ShowAll";
            this.ShowAll.Size = new System.Drawing.Size(125, 33);
            this.ShowAll.TabIndex = 41;
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
            this.Search.Location = new System.Drawing.Point(73, 198);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(125, 33);
            this.Search.TabIndex = 42;
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
            this.Delete.Location = new System.Drawing.Point(73, 521);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(125, 33);
            this.Delete.TabIndex = 43;
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
            this.Update.Location = new System.Drawing.Point(354, 198);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(125, 33);
            this.Update.TabIndex = 45;
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
            this.Insert.Location = new System.Drawing.Point(215, 198);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(125, 33);
            this.Insert.TabIndex = 46;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = false;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // label_return
            // 
            this.label_return.AutoSize = true;
            this.label_return.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_return.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_return.Location = new System.Drawing.Point(65, 610);
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
            this.Count.Location = new System.Drawing.Point(215, 521);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(125, 33);
            this.Count.TabIndex = 57;
            this.Count.Text = "Count";
            this.Count.UseVisualStyleBackColor = false;
            // 
            // OperationMessage
            // 
            this.OperationMessage.AutoSize = true;
            this.OperationMessage.BackColor = System.Drawing.Color.RoyalBlue;
            this.OperationMessage.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperationMessage.ForeColor = System.Drawing.Color.White;
            this.OperationMessage.Location = new System.Drawing.Point(648, 143);
            this.OperationMessage.Name = "OperationMessage";
            this.OperationMessage.Size = new System.Drawing.Size(165, 28);
            this.OperationMessage.TabIndex = 58;
            this.OperationMessage.Text = "OperationMessage";
            this.OperationMessage.Visible = false;
            // 
            // tx_semester
            // 
            this.tx_semester.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tx_semester.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_semester.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_semester.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tx_semester.Location = new System.Drawing.Point(73, 464);
            this.tx_semester.Multiline = true;
            this.tx_semester.Name = "tx_semester";
            this.tx_semester.Size = new System.Drawing.Size(406, 33);
            this.tx_semester.TabIndex = 49;
            // 
            // Semester
            // 
            this.Semester.AutoSize = true;
            this.Semester.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Semester.Location = new System.Drawing.Point(69, 442);
            this.Semester.Name = "Semester";
            this.Semester.Size = new System.Drawing.Size(72, 23);
            this.Semester.TabIndex = 54;
            this.Semester.Text = "Semester";
            // 
            // AdminPanelCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.OperationMessage);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.label_return);
            this.Controls.Add(this.label_admincourseoptions);
            this.Controls.Add(this.tx_courseid);
            this.Controls.Add(this.tx_coursename);
            this.Controls.Add(this.tx_semester);
            this.Controls.Add(this.tx_section);
            this.Controls.Add(this.tx_username);
            this.Controls.Add(this.ShowAll);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.grid1);
            this.Controls.Add(this.label_AdminCourse);
            this.Controls.Add(this.AdminCoursepanel_BG);
            this.Controls.Add(this.label_courseid);
            this.Controls.Add(this.coursename);
            this.Controls.Add(this.Semester);
            this.Controls.Add(this.section);
            this.Controls.Add(this.label_username);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminPanelCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.TextBox tx_courseid;
        private System.Windows.Forms.TextBox tx_coursename;
        private System.Windows.Forms.Label section;
        private System.Windows.Forms.TextBox tx_section;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.TextBox tx_username;
        private System.Windows.Forms.Button ShowAll;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Delete;
        private new System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Label label_return;
        private System.Windows.Forms.Button Count;
        private System.Windows.Forms.Label OperationMessage;
        private System.Windows.Forms.TextBox tx_semester;
        private System.Windows.Forms.Label Semester;
    }
}