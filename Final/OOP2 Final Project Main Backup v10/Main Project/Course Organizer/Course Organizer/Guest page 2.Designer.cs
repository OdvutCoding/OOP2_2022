
namespace Course_Organizer
{
    partial class Guest_page_2
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
            this.Guestpage2text1 = new System.Windows.Forms.Label();
            this.Guestpage2Next = new System.Windows.Forms.Label();
            this.Guestpage2Prev = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Guestpage2text1
            // 
            this.Guestpage2text1.AutoSize = true;
            this.Guestpage2text1.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guestpage2text1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Guestpage2text1.Location = new System.Drawing.Point(125, 519);
            this.Guestpage2text1.Name = "Guestpage2text1";
            this.Guestpage2text1.Size = new System.Drawing.Size(413, 34);
            this.Guestpage2text1.TabIndex = 55;
            this.Guestpage2text1.Text = "You can browse all your other courses too";
            this.Guestpage2text1.Click += new System.EventHandler(this.Guestpage2text1_Click);
            // 
            // Guestpage2Next
            // 
            this.Guestpage2Next.AutoSize = true;
            this.Guestpage2Next.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guestpage2Next.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Guestpage2Next.Location = new System.Drawing.Point(572, 586);
            this.Guestpage2Next.Name = "Guestpage2Next";
            this.Guestpage2Next.Size = new System.Drawing.Size(31, 42);
            this.Guestpage2Next.TabIndex = 56;
            this.Guestpage2Next.Text = ">";
            this.Guestpage2Next.Click += new System.EventHandler(this.Guestpage2Next_Click);
            // 
            // Guestpage2Prev
            // 
            this.Guestpage2Prev.AutoSize = true;
            this.Guestpage2Prev.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guestpage2Prev.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Guestpage2Prev.Location = new System.Drawing.Point(52, 586);
            this.Guestpage2Prev.Name = "Guestpage2Prev";
            this.Guestpage2Prev.Size = new System.Drawing.Size(31, 42);
            this.Guestpage2Prev.TabIndex = 57;
            this.Guestpage2Prev.Text = "<";
            this.Guestpage2Prev.Click += new System.EventHandler(this.Guestpage2Prev_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Course_Organizer.Properties.Resources.Browse;
            this.pictureBox1.Location = new System.Drawing.Point(152, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(363, 479);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Guest_page_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 748);
            this.Controls.Add(this.Guestpage2Next);
            this.Controls.Add(this.Guestpage2Prev);
            this.Controls.Add(this.Guestpage2text1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Guest_page_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guest_page_2";
            this.Load += new System.EventHandler(this.Guest_page_2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Guestpage2text1;
        private System.Windows.Forms.Label Guestpage2Next;
        private System.Windows.Forms.Label Guestpage2Prev;
    }
}