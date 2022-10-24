namespace Course_Organizer
{
    partial class Signin_Form
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
            this.label_Signin = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.textbox_username = new System.Windows.Forms.TextBox();
            this.label_return_signin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Button_login = new System.Windows.Forms.Button();
            this.checkBoxShowpass2 = new System.Windows.Forms.CheckBox();
            this.Prompt = new System.Windows.Forms.Label();
            this.AdminCoursepanel_BG = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdminCoursepanel_BG)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Signin
            // 
            this.label_Signin.AutoSize = true;
            this.label_Signin.BackColor = System.Drawing.Color.RoyalBlue;
            this.label_Signin.Font = new System.Drawing.Font("Poppins Medium", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Signin.ForeColor = System.Drawing.Color.White;
            this.label_Signin.Location = new System.Drawing.Point(439, 261);
            this.label_Signin.Name = "label_Signin";
            this.label_Signin.Size = new System.Drawing.Size(160, 65);
            this.label_Signin.TabIndex = 0;
            this.label_Signin.Text = "Sign In";
            // 
            // textBox_password
            // 
            this.textBox_password.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_password.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_password.Location = new System.Drawing.Point(748, 308);
            this.textBox_password.Multiline = true;
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(387, 35);
            this.textBox_password.TabIndex = 4;
            this.textBox_password.TextChanged += new System.EventHandler(this.textBox_password_TextChanged);
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_Password.Location = new System.Drawing.Point(743, 276);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(88, 28);
            this.label_Password.TabIndex = 3;
            this.label_Password.Text = "Password";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_username.Location = new System.Drawing.Point(743, 189);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(94, 28);
            this.label_username.TabIndex = 1;
            this.label_username.Text = "Username";
            // 
            // textbox_username
            // 
            this.textbox_username.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textbox_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_username.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_username.Location = new System.Drawing.Point(748, 221);
            this.textbox_username.Multiline = true;
            this.textbox_username.Name = "textbox_username";
            this.textbox_username.Size = new System.Drawing.Size(387, 35);
            this.textbox_username.TabIndex = 2;
            // 
            // label_return_signin
            // 
            this.label_return_signin.AutoSize = true;
            this.label_return_signin.BackColor = System.Drawing.Color.RoyalBlue;
            this.label_return_signin.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_return_signin.ForeColor = System.Drawing.Color.White;
            this.label_return_signin.Location = new System.Drawing.Point(43, 612);
            this.label_return_signin.Name = "label_return_signin";
            this.label_return_signin.Size = new System.Drawing.Size(35, 48);
            this.label_return_signin.TabIndex = 21;
            this.label_return_signin.Text = "<";
            this.label_return_signin.Click += new System.EventHandler(this.label_return_signin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Course_Organizer.Properties.Resources.administrator;
            this.pictureBox1.Location = new System.Drawing.Point(1157, 573);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Button_login
            // 
            this.Button_login.BackColor = System.Drawing.Color.Transparent;
            this.Button_login.BackgroundImage = global::Course_Organizer.Properties.Resources.Rectangle_2;
            this.Button_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_login.FlatAppearance.BorderSize = 0;
            this.Button_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_login.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_login.ForeColor = System.Drawing.Color.White;
            this.Button_login.Location = new System.Drawing.Point(863, 497);
            this.Button_login.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_login.Name = "Button_login";
            this.Button_login.Size = new System.Drawing.Size(166, 41);
            this.Button_login.TabIndex = 5;
            this.Button_login.Text = "Log In";
            this.Button_login.UseVisualStyleBackColor = false;
            this.Button_login.Click += new System.EventHandler(this.Button_login_Click);
            this.Button_login.MouseLeave += new System.EventHandler(this.Button_login_MouseLeave);
            this.Button_login.MouseHover += new System.EventHandler(this.Button_login_MouseHover);
            // 
            // checkBoxShowpass2
            // 
            this.checkBoxShowpass2.AutoSize = true;
            this.checkBoxShowpass2.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxShowpass2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.checkBoxShowpass2.Location = new System.Drawing.Point(1013, 361);
            this.checkBoxShowpass2.Name = "checkBoxShowpass2";
            this.checkBoxShowpass2.Size = new System.Drawing.Size(122, 26);
            this.checkBoxShowpass2.TabIndex = 23;
            this.checkBoxShowpass2.Text = "Show Password";
            this.checkBoxShowpass2.UseVisualStyleBackColor = true;
            this.checkBoxShowpass2.CheckedChanged += new System.EventHandler(this.checkBoxShowpass2_CheckedChanged);
            // 
            // Prompt
            // 
            this.Prompt.AutoSize = true;
            this.Prompt.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prompt.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Prompt.Location = new System.Drawing.Point(748, 411);
            this.Prompt.Name = "Prompt";
            this.Prompt.Size = new System.Drawing.Size(46, 23);
            this.Prompt.TabIndex = 25;
            this.Prompt.Text = "label1";
            this.Prompt.Visible = false;
            // 
            // AdminCoursepanel_BG
            // 
            this.AdminCoursepanel_BG.BackColor = System.Drawing.Color.RoyalBlue;
            this.AdminCoursepanel_BG.Location = new System.Drawing.Point(0, -976);
            this.AdminCoursepanel_BG.Name = "AdminCoursepanel_BG";
            this.AdminCoursepanel_BG.Size = new System.Drawing.Size(640, 2880);
            this.AdminCoursepanel_BG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.AdminCoursepanel_BG.TabIndex = 26;
            this.AdminCoursepanel_BG.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(846, 612);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 19);
            this.label1.TabIndex = 27;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Signin_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Prompt);
            this.Controls.Add(this.checkBoxShowpass2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_return_signin);
            this.Controls.Add(this.Button_login);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.textbox_username);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.label_Signin);
            this.Controls.Add(this.AdminCoursepanel_BG);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Signin_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign In";
            this.Load += new System.EventHandler(this.Signin_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdminCoursepanel_BG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Signin;
        private System.Windows.Forms.Button Button_login;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.TextBox textbox_username;
        private System.Windows.Forms.Label label_return_signin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBoxShowpass2;
        private System.Windows.Forms.Label Prompt;
        private System.Windows.Forms.PictureBox AdminCoursepanel_BG;
        private System.Windows.Forms.Label label1;
    }
}