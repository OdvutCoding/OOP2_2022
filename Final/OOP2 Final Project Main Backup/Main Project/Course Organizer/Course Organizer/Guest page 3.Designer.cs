
namespace Course_Organizer
{
    partial class Guest_page_3
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
            this.Guestpage3Next = new System.Windows.Forms.Label();
            this.Guestpage3Prev = new System.Windows.Forms.Label();
            this.Guestpage3text1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Guestpage3Next
            // 
            this.Guestpage3Next.AutoSize = true;
            this.Guestpage3Next.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guestpage3Next.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Guestpage3Next.Location = new System.Drawing.Point(563, 664);
            this.Guestpage3Next.Name = "Guestpage3Next";
            this.Guestpage3Next.Size = new System.Drawing.Size(31, 42);
            this.Guestpage3Next.TabIndex = 59;
            this.Guestpage3Next.Text = ">";
            this.Guestpage3Next.Click += new System.EventHandler(this.Guestpage3Next_Click);
            // 
            // Guestpage3Prev
            // 
            this.Guestpage3Prev.AutoSize = true;
            this.Guestpage3Prev.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guestpage3Prev.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Guestpage3Prev.Location = new System.Drawing.Point(43, 664);
            this.Guestpage3Prev.Name = "Guestpage3Prev";
            this.Guestpage3Prev.Size = new System.Drawing.Size(31, 42);
            this.Guestpage3Prev.TabIndex = 60;
            this.Guestpage3Prev.Text = "<";
            this.Guestpage3Prev.Click += new System.EventHandler(this.Guestpage3Prev_Click);
            // 
            // Guestpage3text1
            // 
            this.Guestpage3text1.AutoSize = true;
            this.Guestpage3text1.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guestpage3text1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Guestpage3text1.Location = new System.Drawing.Point(154, 591);
            this.Guestpage3text1.Name = "Guestpage3text1";
            this.Guestpage3text1.Size = new System.Drawing.Size(334, 34);
            this.Guestpage3text1.TabIndex = 58;
            this.Guestpage3text1.Text = "More information on your courses";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Course_Organizer.Properties.Resources.course_info;
            this.pictureBox1.Location = new System.Drawing.Point(104, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(444, 549);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // Guest_page_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 748);
            this.Controls.Add(this.Guestpage3Next);
            this.Controls.Add(this.Guestpage3Prev);
            this.Controls.Add(this.Guestpage3text1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Guest_page_3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guest_page_3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Guestpage3Next;
        private System.Windows.Forms.Label Guestpage3Prev;
        private System.Windows.Forms.Label Guestpage3text1;
    }
}