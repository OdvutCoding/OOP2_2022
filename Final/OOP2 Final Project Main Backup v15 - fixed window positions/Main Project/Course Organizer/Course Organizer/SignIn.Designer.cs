
namespace Course_Organizer
{
    partial class SignIn
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
            this.textbox_user = new System.Windows.Forms.TextBox();
            this.label_user = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textbox_pass = new System.Windows.Forms.TextBox();
            this.showpasscheck = new System.Windows.Forms.CheckBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.returnbutton = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Signin
            // 
            this.label_Signin.AutoSize = true;
            this.label_Signin.Font = new System.Drawing.Font("Poppins Medium", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Signin.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_Signin.Location = new System.Drawing.Point(83, 86);
            this.label_Signin.Name = "label_Signin";
            this.label_Signin.Size = new System.Drawing.Size(160, 65);
            this.label_Signin.TabIndex = 1;
            this.label_Signin.Text = "Sign In";
            // 
            // textbox_user
            // 
            this.textbox_user.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textbox_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_user.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_user.Location = new System.Drawing.Point(94, 239);
            this.textbox_user.Multiline = true;
            this.textbox_user.Name = "textbox_user";
            this.textbox_user.Size = new System.Drawing.Size(387, 35);
            this.textbox_user.TabIndex = 4;
            this.textbox_user.UseSystemPasswordChar = true;
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_user.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_user.Location = new System.Drawing.Point(89, 207);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(94, 28);
            this.label_user.TabIndex = 3;
            this.label_user.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(89, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password";
            // 
            // textbox_pass
            // 
            this.textbox_pass.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textbox_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_pass.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_pass.Location = new System.Drawing.Point(94, 328);
            this.textbox_pass.Multiline = true;
            this.textbox_pass.Name = "textbox_pass";
            this.textbox_pass.Size = new System.Drawing.Size(387, 35);
            this.textbox_pass.TabIndex = 4;
            this.textbox_pass.UseSystemPasswordChar = true;
            // 
            // showpasscheck
            // 
            this.showpasscheck.AutoSize = true;
            this.showpasscheck.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showpasscheck.ForeColor = System.Drawing.Color.RoyalBlue;
            this.showpasscheck.Location = new System.Drawing.Point(359, 369);
            this.showpasscheck.Name = "showpasscheck";
            this.showpasscheck.Size = new System.Drawing.Size(122, 26);
            this.showpasscheck.TabIndex = 25;
            this.showpasscheck.Text = "Show Password";
            this.showpasscheck.UseVisualStyleBackColor = true;
            this.showpasscheck.CheckedChanged += new System.EventHandler(this.showpasscheck_CheckedChanged);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.Transparent;
            this.LoginButton.BackgroundImage = global::Course_Organizer.Properties.Resources.Rectangle_2;
            this.LoginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(206, 458);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(166, 41);
            this.LoginButton.TabIndex = 24;
            this.LoginButton.Text = "Log In";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // returnbutton
            // 
            this.returnbutton.AutoSize = true;
            this.returnbutton.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnbutton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.returnbutton.Location = new System.Drawing.Point(86, 545);
            this.returnbutton.Name = "returnbutton";
            this.returnbutton.Size = new System.Drawing.Size(35, 48);
            this.returnbutton.TabIndex = 26;
            this.returnbutton.Text = "<";
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 748);
            this.Controls.Add(this.returnbutton);
            this.Controls.Add(this.showpasscheck);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.textbox_pass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textbox_user);
            this.Controls.Add(this.label_user);
            this.Controls.Add(this.label_Signin);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignIn";
            this.Load += new System.EventHandler(this.SignIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Signin;
        private System.Windows.Forms.TextBox textbox_user;
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textbox_pass;
        private System.Windows.Forms.CheckBox showpasscheck;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label returnbutton;
    }
}