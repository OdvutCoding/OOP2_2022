namespace Course_Organizer
{
    partial class Guest_User
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
            this.Guestpage1text1 = new System.Windows.Forms.Label();
            this.Guestpage1Prev = new System.Windows.Forms.Label();
            this.Guestpage1Next = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Guestpage1text1
            // 
            this.Guestpage1text1.AutoSize = true;
            this.Guestpage1text1.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guestpage1text1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Guestpage1text1.Location = new System.Drawing.Point(160, 510);
            this.Guestpage1text1.Name = "Guestpage1text1";
            this.Guestpage1text1.Size = new System.Drawing.Size(308, 34);
            this.Guestpage1text1.TabIndex = 52;
            this.Guestpage1text1.Text = "You can add your own courses";
            // 
            // Guestpage1Prev
            // 
            this.Guestpage1Prev.AutoSize = true;
            this.Guestpage1Prev.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guestpage1Prev.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Guestpage1Prev.Location = new System.Drawing.Point(44, 591);
            this.Guestpage1Prev.Name = "Guestpage1Prev";
            this.Guestpage1Prev.Size = new System.Drawing.Size(31, 42);
            this.Guestpage1Prev.TabIndex = 52;
            this.Guestpage1Prev.Text = "<";
            this.Guestpage1Prev.Click += new System.EventHandler(this.Guestpage1Prev_Click);
            // 
            // Guestpage1Next
            // 
            this.Guestpage1Next.AutoSize = true;
            this.Guestpage1Next.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guestpage1Next.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Guestpage1Next.Location = new System.Drawing.Point(564, 591);
            this.Guestpage1Next.Name = "Guestpage1Next";
            this.Guestpage1Next.Size = new System.Drawing.Size(31, 42);
            this.Guestpage1Next.TabIndex = 52;
            this.Guestpage1Next.Text = ">";
            this.Guestpage1Next.Click += new System.EventHandler(this.Guestpage1Next_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Course_Organizer.Properties.Resources.Add;
            this.pictureBox1.Location = new System.Drawing.Point(135, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(365, 455);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Guest_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 748);
            this.Controls.Add(this.Guestpage1Next);
            this.Controls.Add(this.Guestpage1Prev);
            this.Controls.Add(this.Guestpage1text1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Guest_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guest_User";
            this.Load += new System.EventHandler(this.Guest_User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Guestpage1text1;
        private System.Windows.Forms.Label Guestpage1Prev;
        private System.Windows.Forms.Label Guestpage1Next;
    }
}