namespace Course_Organizer
{
    partial class Form_User
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
            this.label_User = new System.Windows.Forms.Label();
            this.label_logoutuserform = new System.Windows.Forms.Label();
            this.Button_Editcourse = new System.Windows.Forms.Button();
            this.Button_Browsecourse = new System.Windows.Forms.Button();
            this.Button_Addcourse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_User
            // 
            this.label_User.AutoSize = true;
            this.label_User.Font = new System.Drawing.Font("Poppins Medium", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_User.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_User.Location = new System.Drawing.Point(96, 96);
            this.label_User.Name = "label_User";
            this.label_User.Size = new System.Drawing.Size(115, 65);
            this.label_User.TabIndex = 1;
            this.label_User.Text = "User";
            this.label_User.Click += new System.EventHandler(this.label_User_Click);
            // 
            // label_logoutuserform
            // 
            this.label_logoutuserform.AutoSize = true;
            this.label_logoutuserform.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_logoutuserform.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_logoutuserform.Location = new System.Drawing.Point(103, 498);
            this.label_logoutuserform.Name = "label_logoutuserform";
            this.label_logoutuserform.Size = new System.Drawing.Size(79, 26);
            this.label_logoutuserform.TabIndex = 22;
            this.label_logoutuserform.Text = "< Log out";
            this.label_logoutuserform.Click += new System.EventHandler(this.label_logoutuserform_Click);
            // 
            // Button_Editcourse
            // 
            this.Button_Editcourse.BackColor = System.Drawing.Color.Transparent;
            this.Button_Editcourse.BackgroundImage = global::Course_Organizer.Properties.Resources.Rectangle_2;
            this.Button_Editcourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Editcourse.FlatAppearance.BorderSize = 0;
            this.Button_Editcourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Editcourse.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Editcourse.ForeColor = System.Drawing.Color.White;
            this.Button_Editcourse.Location = new System.Drawing.Point(107, 389);
            this.Button_Editcourse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_Editcourse.Name = "Button_Editcourse";
            this.Button_Editcourse.Size = new System.Drawing.Size(251, 41);
            this.Button_Editcourse.TabIndex = 23;
            this.Button_Editcourse.Text = "Edit Course";
            this.Button_Editcourse.UseVisualStyleBackColor = false;
            this.Button_Editcourse.Click += new System.EventHandler(this.Button_Editcourse_Click);
            // 
            // Button_Browsecourse
            // 
            this.Button_Browsecourse.BackColor = System.Drawing.Color.Transparent;
            this.Button_Browsecourse.BackgroundImage = global::Course_Organizer.Properties.Resources.Rectangle_2;
            this.Button_Browsecourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Browsecourse.FlatAppearance.BorderSize = 0;
            this.Button_Browsecourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Browsecourse.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Browsecourse.ForeColor = System.Drawing.Color.White;
            this.Button_Browsecourse.Location = new System.Drawing.Point(108, 307);
            this.Button_Browsecourse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_Browsecourse.Name = "Button_Browsecourse";
            this.Button_Browsecourse.Size = new System.Drawing.Size(251, 41);
            this.Button_Browsecourse.TabIndex = 4;
            this.Button_Browsecourse.Text = "Browse Courses";
            this.Button_Browsecourse.UseVisualStyleBackColor = false;
            this.Button_Browsecourse.Click += new System.EventHandler(this.Button_Browsecourse_Click);
            // 
            // Button_Addcourse
            // 
            this.Button_Addcourse.BackColor = System.Drawing.Color.Transparent;
            this.Button_Addcourse.BackgroundImage = global::Course_Organizer.Properties.Resources.Rectangle_2;
            this.Button_Addcourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Addcourse.FlatAppearance.BorderSize = 0;
            this.Button_Addcourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Addcourse.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Addcourse.ForeColor = System.Drawing.Color.White;
            this.Button_Addcourse.Location = new System.Drawing.Point(107, 223);
            this.Button_Addcourse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_Addcourse.Name = "Button_Addcourse";
            this.Button_Addcourse.Size = new System.Drawing.Size(251, 41);
            this.Button_Addcourse.TabIndex = 3;
            this.Button_Addcourse.Text = "Add New Course";
            this.Button_Addcourse.UseVisualStyleBackColor = false;
            this.Button_Addcourse.Click += new System.EventHandler(this.Button_Addcourse_Click);
            // 
            // Form_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 748);
            this.Controls.Add(this.Button_Editcourse);
            this.Controls.Add(this.label_logoutuserform);
            this.Controls.Add(this.Button_Browsecourse);
            this.Controls.Add(this.Button_Addcourse);
            this.Controls.Add(this.label_User);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.Load += new System.EventHandler(this.Form_User_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_User;
        private System.Windows.Forms.Button Button_Browsecourse;
        private System.Windows.Forms.Button Button_Addcourse;
        private System.Windows.Forms.Button Button_Editcourse;
        private System.Windows.Forms.Label label_logoutuserform;
    }
}