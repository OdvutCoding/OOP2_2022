
namespace OOP2_LAB4_Final_Phonebook_app
{
    partial class Form1
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
            this.App_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // App_title
            // 
            this.App_title.AutoSize = true;
            this.App_title.Font = new System.Drawing.Font("Lufga", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.App_title.Location = new System.Drawing.Point(262, 35);
            this.App_title.Name = "App_title";
            this.App_title.Size = new System.Drawing.Size(219, 35);
            this.App_title.TabIndex = 0;
            this.App_title.Text = "Phonebook App";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 485);
            this.Controls.Add(this.App_title);
            this.Font = new System.Drawing.Font("Lufga", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label App_title;
    }
}

