namespace Course_Organizer
{
    partial class Guest_page_7
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
            this.Label_CTA = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label_CTA
            // 
            this.Label_CTA.AutoSize = true;
            this.Label_CTA.Font = new System.Drawing.Font("Poppins SemiBold", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_CTA.ForeColor = System.Drawing.Color.SlateBlue;
            this.Label_CTA.Location = new System.Drawing.Point(366, 304);
            this.Label_CTA.Name = "Label_CTA";
            this.Label_CTA.Size = new System.Drawing.Size(459, 62);
            this.Label_CTA.TabIndex = 1;
            this.Label_CTA.Text = "Create an account now!";
            this.Label_CTA.Click += new System.EventHandler(this.Label_CTA_Click);
            this.Label_CTA.MouseLeave += new System.EventHandler(this.Label_CTA_MouseLeave);
            this.Label_CTA.MouseHover += new System.EventHandler(this.Label_CTA_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(376, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "To enjoy the full benefits of course organizer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SlateBlue;
            this.label2.Location = new System.Drawing.Point(420, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Or sign in if you already have an account";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Guest_page_7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label_CTA);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Guest_page_7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guest_page_7";
            this.Load += new System.EventHandler(this.Guest_page_7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_CTA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}