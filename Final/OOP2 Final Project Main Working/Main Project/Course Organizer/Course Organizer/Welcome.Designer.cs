namespace Course_Organizer
{
    partial class Welcome
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
            this.Label_Welcome = new System.Windows.Forms.Label();
            this.Guest_option_tagline = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_SignUP = new System.Windows.Forms.Button();
            this.Button_Signin = new System.Windows.Forms.Button();
            this.Welcome_picturebox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Welcome_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Welcome
            // 
            this.Label_Welcome.AutoSize = true;
            this.Label_Welcome.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label_Welcome.Font = new System.Drawing.Font("Poppins SemiBold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Welcome.ForeColor = System.Drawing.Color.White;
            this.Label_Welcome.Location = new System.Drawing.Point(345, 281);
            this.Label_Welcome.Name = "Label_Welcome";
            this.Label_Welcome.Size = new System.Drawing.Size(284, 84);
            this.Label_Welcome.TabIndex = 0;
            this.Label_Welcome.Text = "Welcome!";
            // 
            // Guest_option_tagline
            // 
            this.Guest_option_tagline.AutoSize = true;
            this.Guest_option_tagline.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guest_option_tagline.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Guest_option_tagline.Location = new System.Drawing.Point(782, 408);
            this.Guest_option_tagline.Name = "Guest_option_tagline";
            this.Guest_option_tagline.Size = new System.Drawing.Size(338, 28);
            this.Guest_option_tagline.TabIndex = 3;
            this.Guest_option_tagline.Text = "Don\'t want to create an account just yet?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.BlueViolet;
            this.label1.Location = new System.Drawing.Point(847, 436);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "You can try as Guest user!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            this.label1.MouseHover += new System.EventHandler(this.label1_MouseHover);
            // 
            // Button_SignUP
            // 
            this.Button_SignUP.BackColor = System.Drawing.Color.Transparent;
            this.Button_SignUP.BackgroundImage = global::Course_Organizer.Properties.Resources.Rectangle_2;
            this.Button_SignUP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_SignUP.FlatAppearance.BorderSize = 0;
            this.Button_SignUP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_SignUP.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_SignUP.ForeColor = System.Drawing.Color.White;
            this.Button_SignUP.Location = new System.Drawing.Point(861, 338);
            this.Button_SignUP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_SignUP.Name = "Button_SignUP";
            this.Button_SignUP.Size = new System.Drawing.Size(171, 41);
            this.Button_SignUP.TabIndex = 2;
            this.Button_SignUP.Text = "Sign up";
            this.Button_SignUP.UseVisualStyleBackColor = false;
            this.Button_SignUP.Click += new System.EventHandler(this.Button_SignUP_Click);
            this.Button_SignUP.MouseLeave += new System.EventHandler(this.Button_SignUP_MouseLeave);
            this.Button_SignUP.MouseHover += new System.EventHandler(this.Button_SignUP_MouseHover);
            // 
            // Button_Signin
            // 
            this.Button_Signin.BackColor = System.Drawing.Color.Transparent;
            this.Button_Signin.BackgroundImage = global::Course_Organizer.Properties.Resources.Rectangle_2;
            this.Button_Signin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Signin.FlatAppearance.BorderSize = 0;
            this.Button_Signin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Signin.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Signin.ForeColor = System.Drawing.Color.White;
            this.Button_Signin.Location = new System.Drawing.Point(861, 268);
            this.Button_Signin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_Signin.Name = "Button_Signin";
            this.Button_Signin.Size = new System.Drawing.Size(171, 41);
            this.Button_Signin.TabIndex = 1;
            this.Button_Signin.Text = "Sign in";
            this.Button_Signin.UseVisualStyleBackColor = false;
            this.Button_Signin.Click += new System.EventHandler(this.Button_Signin_Click);
            this.Button_Signin.MouseLeave += new System.EventHandler(this.Button_Signin_MouseLeave);
            this.Button_Signin.MouseHover += new System.EventHandler(this.Button_Signin_MouseHover);
            // 
            // Welcome_picturebox
            // 
            this.Welcome_picturebox.BackColor = System.Drawing.Color.RoyalBlue;
            this.Welcome_picturebox.Location = new System.Drawing.Point(-1, -1);
            this.Welcome_picturebox.Name = "Welcome_picturebox";
            this.Welcome_picturebox.Size = new System.Drawing.Size(640, 720);
            this.Welcome_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Welcome_picturebox.TabIndex = 5;
            this.Welcome_picturebox.TabStop = false;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Guest_option_tagline);
            this.Controls.Add(this.Button_SignUP);
            this.Controls.Add(this.Button_Signin);
            this.Controls.Add(this.Label_Welcome);
            this.Controls.Add(this.Welcome_picturebox);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome Screen";
            this.Load += new System.EventHandler(this.Welcome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Welcome_picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Welcome;
        private System.Windows.Forms.Button Button_Signin;
        private System.Windows.Forms.Button Button_SignUP;
        private System.Windows.Forms.Label Guest_option_tagline;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Welcome_picturebox;
    }
}

