
namespace Course_Organizer
{
    partial class Guest_page_4
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
            this.Guestpage4Next = new System.Windows.Forms.Label();
            this.Guestpage4Prev = new System.Windows.Forms.Label();
            this.Guestpage4text1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Guestpage4Next
            // 
            this.Guestpage4Next.AutoSize = true;
            this.Guestpage4Next.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guestpage4Next.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Guestpage4Next.Location = new System.Drawing.Point(568, 664);
            this.Guestpage4Next.Name = "Guestpage4Next";
            this.Guestpage4Next.Size = new System.Drawing.Size(31, 42);
            this.Guestpage4Next.TabIndex = 62;
            this.Guestpage4Next.Text = ">";
            this.Guestpage4Next.Click += new System.EventHandler(this.Guestpage4Next_Click);
            // 
            // Guestpage4Prev
            // 
            this.Guestpage4Prev.AutoSize = true;
            this.Guestpage4Prev.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guestpage4Prev.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Guestpage4Prev.Location = new System.Drawing.Point(48, 664);
            this.Guestpage4Prev.Name = "Guestpage4Prev";
            this.Guestpage4Prev.Size = new System.Drawing.Size(31, 42);
            this.Guestpage4Prev.TabIndex = 63;
            this.Guestpage4Prev.Text = "<";
            this.Guestpage4Prev.Click += new System.EventHandler(this.Guestpage4Prev_Click);
            // 
            // Guestpage4text1
            // 
            this.Guestpage4text1.AutoSize = true;
            this.Guestpage4text1.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guestpage4text1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Guestpage4text1.Location = new System.Drawing.Point(138, 594);
            this.Guestpage4text1.Name = "Guestpage4text1";
            this.Guestpage4text1.Size = new System.Drawing.Size(363, 34);
            this.Guestpage4text1.TabIndex = 61;
            this.Guestpage4text1.Text = "Save dates for all the important stuff";
            this.Guestpage4text1.Click += new System.EventHandler(this.Guestpage4text1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Course_Organizer.Properties.Resources.Exam_info;
            this.pictureBox1.Location = new System.Drawing.Point(66, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(518, 549);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // Guest_page_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 748);
            this.Controls.Add(this.Guestpage4Next);
            this.Controls.Add(this.Guestpage4Prev);
            this.Controls.Add(this.Guestpage4text1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Guest_page_4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guest_page_4";
            this.Load += new System.EventHandler(this.Guest_page_4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Guestpage4Next;
        private System.Windows.Forms.Label Guestpage4Prev;
        private System.Windows.Forms.Label Guestpage4text1;
    }
}