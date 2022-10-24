
namespace Course_Organizer
{
    partial class Guest_page_5
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
            this.Guestpage5Next = new System.Windows.Forms.Label();
            this.Guestpage5Prev = new System.Windows.Forms.Label();
            this.Guestpage5text1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Guestpage5Next
            // 
            this.Guestpage5Next.AutoSize = true;
            this.Guestpage5Next.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guestpage5Next.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Guestpage5Next.Location = new System.Drawing.Point(1169, 616);
            this.Guestpage5Next.Name = "Guestpage5Next";
            this.Guestpage5Next.Size = new System.Drawing.Size(31, 42);
            this.Guestpage5Next.TabIndex = 65;
            this.Guestpage5Next.Text = ">";
            this.Guestpage5Next.Click += new System.EventHandler(this.Guestpage5Next_Click);
            // 
            // Guestpage5Prev
            // 
            this.Guestpage5Prev.AutoSize = true;
            this.Guestpage5Prev.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guestpage5Prev.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Guestpage5Prev.Location = new System.Drawing.Point(49, 616);
            this.Guestpage5Prev.Name = "Guestpage5Prev";
            this.Guestpage5Prev.Size = new System.Drawing.Size(31, 42);
            this.Guestpage5Prev.TabIndex = 66;
            this.Guestpage5Prev.Text = "<";
            this.Guestpage5Prev.Click += new System.EventHandler(this.Guestpage5Prev_Click);
            // 
            // Guestpage5text1
            // 
            this.Guestpage5text1.AutoSize = true;
            this.Guestpage5text1.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guestpage5text1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Guestpage5text1.Location = new System.Drawing.Point(454, 560);
            this.Guestpage5text1.Name = "Guestpage5text1";
            this.Guestpage5text1.Size = new System.Drawing.Size(323, 34);
            this.Guestpage5text1.TabIndex = 64;
            this.Guestpage5text1.Text = "Keep track of topics you learned";
            this.Guestpage5text1.Click += new System.EventHandler(this.Guestpage3text1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Course_Organizer.Properties.Resources.math_5_syllabus;
            this.pictureBox1.Location = new System.Drawing.Point(56, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1144, 549);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // Guest_page_5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Guestpage5Next);
            this.Controls.Add(this.Guestpage5Prev);
            this.Controls.Add(this.Guestpage5text1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Guest_page_5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guest_page_5";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Guestpage5Next;
        private System.Windows.Forms.Label Guestpage5Prev;
        private System.Windows.Forms.Label Guestpage5text1;
    }
}