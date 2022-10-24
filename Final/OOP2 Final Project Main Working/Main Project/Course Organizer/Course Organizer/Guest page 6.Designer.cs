
namespace Course_Organizer
{
    partial class Guest_page_6
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
            this.Guestpage6Next = new System.Windows.Forms.Label();
            this.Guestpage6Prev = new System.Windows.Forms.Label();
            this.Guestpage6text1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Guestpage6Next
            // 
            this.Guestpage6Next.AutoSize = true;
            this.Guestpage6Next.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guestpage6Next.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Guestpage6Next.Location = new System.Drawing.Point(1171, 599);
            this.Guestpage6Next.Name = "Guestpage6Next";
            this.Guestpage6Next.Size = new System.Drawing.Size(31, 42);
            this.Guestpage6Next.TabIndex = 68;
            this.Guestpage6Next.Text = ">";
            this.Guestpage6Next.Click += new System.EventHandler(this.Guestpage6Next_Click);
            // 
            // Guestpage6Prev
            // 
            this.Guestpage6Prev.AutoSize = true;
            this.Guestpage6Prev.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guestpage6Prev.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Guestpage6Prev.Location = new System.Drawing.Point(53, 599);
            this.Guestpage6Prev.Name = "Guestpage6Prev";
            this.Guestpage6Prev.Size = new System.Drawing.Size(31, 42);
            this.Guestpage6Prev.TabIndex = 69;
            this.Guestpage6Prev.Text = "<";
            this.Guestpage6Prev.Click += new System.EventHandler(this.Guestpage6Prev_Click);
            // 
            // Guestpage6text1
            // 
            this.Guestpage6text1.AutoSize = true;
            this.Guestpage6text1.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guestpage6text1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Guestpage6text1.Location = new System.Drawing.Point(482, 563);
            this.Guestpage6text1.Name = "Guestpage6text1";
            this.Guestpage6text1.Size = new System.Drawing.Size(238, 34);
            this.Guestpage6text1.TabIndex = 67;
            this.Guestpage6text1.Text = "Track your peformance";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Course_Organizer.Properties.Resources.math_5_progress;
            this.pictureBox1.Location = new System.Drawing.Point(60, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1142, 538);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // Guest_page_6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Guestpage6Next);
            this.Controls.Add(this.Guestpage6Prev);
            this.Controls.Add(this.Guestpage6text1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Guest_page_6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guest_page_6";
            this.Load += new System.EventHandler(this.Guest_page_6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Guestpage6Next;
        private System.Windows.Forms.Label Guestpage6Prev;
        private System.Windows.Forms.Label Guestpage6text1;
    }
}