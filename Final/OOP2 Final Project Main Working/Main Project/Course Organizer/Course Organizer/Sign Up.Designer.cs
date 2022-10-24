
namespace Course_Organizer
{
    partial class Signup_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup_Form));
            this.txt_pw = new System.Windows.Forms.TextBox();
            this.label_signup_pass1 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.labe_student_name = new System.Windows.Forms.Label();
            this.label_Signup = new System.Windows.Forms.Label();
            this.txt_pw_retype = new System.Windows.Forms.TextBox();
            this.label_signup_pass2 = new System.Windows.Forms.Label();
            this.Button_Register = new System.Windows.Forms.Button();
            this.label_return_signup = new System.Windows.Forms.Label();
            this.checkBoxShowPass = new System.Windows.Forms.CheckBox();
            this.Clear_signup = new System.Windows.Forms.Button();
            this.Prompt = new System.Windows.Forms.Label();
            this.AdminCoursepanel_BG = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AdminCoursepanel_BG)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_pw
            // 
            this.txt_pw.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_pw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pw.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pw.Location = new System.Drawing.Point(789, 226);
            this.txt_pw.Multiline = true;
            this.txt_pw.Name = "txt_pw";
            this.txt_pw.PasswordChar = '*';
            this.txt_pw.Size = new System.Drawing.Size(364, 35);
            this.txt_pw.TabIndex = 10;
            // 
            // label_signup_pass1
            // 
            this.label_signup_pass1.AutoSize = true;
            this.label_signup_pass1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_signup_pass1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_signup_pass1.Location = new System.Drawing.Point(784, 194);
            this.label_signup_pass1.Name = "label_signup_pass1";
            this.label_signup_pass1.Size = new System.Drawing.Size(88, 28);
            this.label_signup_pass1.TabIndex = 9;
            this.label_signup_pass1.Text = "Password";
            this.label_signup_pass1.Click += new System.EventHandler(this.label_Password_Click);
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_username.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(789, 139);
            this.txt_username.Multiline = true;
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(364, 35);
            this.txt_username.TabIndex = 8;
            // 
            // labe_student_name
            // 
            this.labe_student_name.AutoSize = true;
            this.labe_student_name.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labe_student_name.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labe_student_name.Location = new System.Drawing.Point(784, 107);
            this.labe_student_name.Name = "labe_student_name";
            this.labe_student_name.Size = new System.Drawing.Size(94, 28);
            this.labe_student_name.TabIndex = 7;
            this.labe_student_name.Text = "Username";
            // 
            // label_Signup
            // 
            this.label_Signup.AutoSize = true;
            this.label_Signup.BackColor = System.Drawing.Color.RoyalBlue;
            this.label_Signup.Font = new System.Drawing.Font("Poppins Medium", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Signup.ForeColor = System.Drawing.Color.White;
            this.label_Signup.Location = new System.Drawing.Point(433, 293);
            this.label_Signup.Name = "label_Signup";
            this.label_Signup.Size = new System.Drawing.Size(177, 65);
            this.label_Signup.TabIndex = 6;
            this.label_Signup.Text = "Sign Up";
            // 
            // txt_pw_retype
            // 
            this.txt_pw_retype.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_pw_retype.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pw_retype.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pw_retype.Location = new System.Drawing.Point(789, 317);
            this.txt_pw_retype.Multiline = true;
            this.txt_pw_retype.Name = "txt_pw_retype";
            this.txt_pw_retype.PasswordChar = '*';
            this.txt_pw_retype.Size = new System.Drawing.Size(364, 35);
            this.txt_pw_retype.TabIndex = 13;
            // 
            // label_signup_pass2
            // 
            this.label_signup_pass2.AutoSize = true;
            this.label_signup_pass2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_signup_pass2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_signup_pass2.Location = new System.Drawing.Point(784, 285);
            this.label_signup_pass2.Name = "label_signup_pass2";
            this.label_signup_pass2.Size = new System.Drawing.Size(148, 28);
            this.label_signup_pass2.TabIndex = 12;
            this.label_signup_pass2.Text = "Retype Password";
            // 
            // Button_Register
            // 
            this.Button_Register.BackColor = System.Drawing.Color.Transparent;
            this.Button_Register.BackgroundImage = global::Course_Organizer.Properties.Resources.Rectangle_2;
            this.Button_Register.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Register.FlatAppearance.BorderSize = 0;
            this.Button_Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Register.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Register.ForeColor = System.Drawing.Color.White;
            this.Button_Register.Location = new System.Drawing.Point(789, 507);
            this.Button_Register.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_Register.Name = "Button_Register";
            this.Button_Register.Size = new System.Drawing.Size(166, 41);
            this.Button_Register.TabIndex = 11;
            this.Button_Register.Text = "Register";
            this.Button_Register.UseVisualStyleBackColor = false;
            this.Button_Register.Click += new System.EventHandler(this.Button_agree_continue_Click_1);
            this.Button_Register.MouseLeave += new System.EventHandler(this.Button_Register_MouseLeave);
            this.Button_Register.MouseHover += new System.EventHandler(this.Button_Register_MouseHover);
            // 
            // label_return_signup
            // 
            this.label_return_signup.AutoSize = true;
            this.label_return_signup.BackColor = System.Drawing.Color.RoyalBlue;
            this.label_return_signup.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_return_signup.ForeColor = System.Drawing.Color.White;
            this.label_return_signup.Location = new System.Drawing.Point(59, 593);
            this.label_return_signup.Name = "label_return_signup";
            this.label_return_signup.Size = new System.Drawing.Size(35, 48);
            this.label_return_signup.TabIndex = 20;
            this.label_return_signup.Text = "<";
            this.label_return_signup.Click += new System.EventHandler(this.label_return_signup_Click);
            // 
            // checkBoxShowPass
            // 
            this.checkBoxShowPass.AutoSize = true;
            this.checkBoxShowPass.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxShowPass.ForeColor = System.Drawing.Color.RoyalBlue;
            this.checkBoxShowPass.Location = new System.Drawing.Point(1022, 369);
            this.checkBoxShowPass.Name = "checkBoxShowPass";
            this.checkBoxShowPass.Size = new System.Drawing.Size(131, 27);
            this.checkBoxShowPass.TabIndex = 21;
            this.checkBoxShowPass.Text = "Show Password";
            this.checkBoxShowPass.UseVisualStyleBackColor = true;
            this.checkBoxShowPass.CheckedChanged += new System.EventHandler(this.checkBoxShowPass_CheckedChanged);
            // 
            // Clear_signup
            // 
            this.Clear_signup.BackColor = System.Drawing.Color.Transparent;
            this.Clear_signup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Clear_signup.BackgroundImage")));
            this.Clear_signup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Clear_signup.FlatAppearance.BorderSize = 0;
            this.Clear_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear_signup.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_signup.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Clear_signup.Location = new System.Drawing.Point(987, 507);
            this.Clear_signup.Name = "Clear_signup";
            this.Clear_signup.Size = new System.Drawing.Size(166, 41);
            this.Clear_signup.TabIndex = 22;
            this.Clear_signup.Text = "Clear";
            this.Clear_signup.UseVisualStyleBackColor = false;
            this.Clear_signup.Click += new System.EventHandler(this.Clear_signup_Click);
            this.Clear_signup.MouseLeave += new System.EventHandler(this.Clear_signup_MouseLeave);
            this.Clear_signup.MouseHover += new System.EventHandler(this.Clear_signup_MouseHover);
            // 
            // Prompt
            // 
            this.Prompt.AutoSize = true;
            this.Prompt.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prompt.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Prompt.Location = new System.Drawing.Point(784, 428);
            this.Prompt.Name = "Prompt";
            this.Prompt.Size = new System.Drawing.Size(46, 23);
            this.Prompt.TabIndex = 23;
            this.Prompt.Text = "label1";
            this.Prompt.Visible = false;
            // 
            // AdminCoursepanel_BG
            // 
            this.AdminCoursepanel_BG.BackColor = System.Drawing.Color.RoyalBlue;
            this.AdminCoursepanel_BG.Location = new System.Drawing.Point(-1, -1121);
            this.AdminCoursepanel_BG.Name = "AdminCoursepanel_BG";
            this.AdminCoursepanel_BG.Size = new System.Drawing.Size(640, 2880);
            this.AdminCoursepanel_BG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.AdminCoursepanel_BG.TabIndex = 27;
            this.AdminCoursepanel_BG.TabStop = false;
            // 
            // Signup_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Prompt);
            this.Controls.Add(this.Clear_signup);
            this.Controls.Add(this.checkBoxShowPass);
            this.Controls.Add(this.label_return_signup);
            this.Controls.Add(this.txt_pw_retype);
            this.Controls.Add(this.label_signup_pass2);
            this.Controls.Add(this.Button_Register);
            this.Controls.Add(this.txt_pw);
            this.Controls.Add(this.label_signup_pass1);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.labe_student_name);
            this.Controls.Add(this.label_Signup);
            this.Controls.Add(this.AdminCoursepanel_BG);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Signup_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.Load += new System.EventHandler(this.Signup_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AdminCoursepanel_BG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Register;
        private System.Windows.Forms.TextBox txt_pw;
        private System.Windows.Forms.Label label_signup_pass1;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label labe_student_name;
        private System.Windows.Forms.Label label_Signup;
        private System.Windows.Forms.TextBox txt_pw_retype;
        private System.Windows.Forms.Label label_signup_pass2;
        private System.Windows.Forms.Label label_return_signup;
        private System.Windows.Forms.CheckBox checkBoxShowPass;
        private System.Windows.Forms.Button Clear_signup;
        private System.Windows.Forms.Label Prompt;
        private System.Windows.Forms.PictureBox AdminCoursepanel_BG;
    }
}