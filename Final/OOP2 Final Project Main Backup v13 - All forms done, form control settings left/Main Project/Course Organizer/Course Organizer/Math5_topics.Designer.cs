namespace Course_Organizer
{
    partial class Math5_topics
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
            this.label_progress_next = new System.Windows.Forms.Label();
            this.label_return_progress = new System.Windows.Forms.Label();
            this.checkedListBox_final = new System.Windows.Forms.CheckedListBox();
            this.label_finalterm = new System.Windows.Forms.Label();
            this.checkedListBox_mid = new System.Windows.Forms.CheckedListBox();
            this.label_midterm = new System.Windows.Forms.Label();
            this.labe_course_name = new System.Windows.Forms.Label();
            this.label_progression = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_progress_next
            // 
            this.label_progress_next.AutoSize = true;
            this.label_progress_next.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_progress_next.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_progress_next.Location = new System.Drawing.Point(1165, 604);
            this.label_progress_next.Name = "label_progress_next";
            this.label_progress_next.Size = new System.Drawing.Size(35, 48);
            this.label_progress_next.TabIndex = 60;
            this.label_progress_next.Text = ">";
            this.label_progress_next.Click += new System.EventHandler(this.label_progress_next_Click);
            // 
            // label_return_progress
            // 
            this.label_return_progress.AutoSize = true;
            this.label_return_progress.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_return_progress.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_return_progress.Location = new System.Drawing.Point(51, 604);
            this.label_return_progress.Name = "label_return_progress";
            this.label_return_progress.Size = new System.Drawing.Size(35, 48);
            this.label_return_progress.TabIndex = 61;
            this.label_return_progress.Text = "<";
            this.label_return_progress.Click += new System.EventHandler(this.label_return_progress_Click);
            // 
            // checkedListBox_final
            // 
            this.checkedListBox_final.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox_final.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox_final.ForeColor = System.Drawing.Color.SlateBlue;
            this.checkedListBox_final.FormattingEnabled = true;
            this.checkedListBox_final.Items.AddRange(new object[] {
            "Newton\'s Divided Difference",
            "Lagrange Interpolation",
            "Curve Fitting",
            "Curve Fitting with Least Square Method",
            "Numerical Differentiation",
            "Numerical Integration",
            "Richardson Extrapolation",
            "RK-2 Method",
            "RK-4 Method",
            "Recurrance Relation",
            "Ordinary Differential Equation",
            "System of Ordinary Differential Equation",
            "MATLAB"});
            this.checkedListBox_final.Location = new System.Drawing.Point(709, 268);
            this.checkedListBox_final.Name = "checkedListBox_final";
            this.checkedListBox_final.Size = new System.Drawing.Size(415, 304);
            this.checkedListBox_final.TabIndex = 58;
            // 
            // label_finalterm
            // 
            this.label_finalterm.AutoSize = true;
            this.label_finalterm.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_finalterm.ForeColor = System.Drawing.Color.SlateBlue;
            this.label_finalterm.Location = new System.Drawing.Point(703, 231);
            this.label_finalterm.Name = "label_finalterm";
            this.label_finalterm.Size = new System.Drawing.Size(114, 34);
            this.label_finalterm.TabIndex = 55;
            this.label_finalterm.Text = "Final Term";
            // 
            // checkedListBox_mid
            // 
            this.checkedListBox_mid.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox_mid.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox_mid.ForeColor = System.Drawing.Color.RoyalBlue;
            this.checkedListBox_mid.FormattingEnabled = true;
            this.checkedListBox_mid.Items.AddRange(new object[] {
            "S.L.E - Gaussian Elimination Method",
            "S.L.E - Iterative Method",
            "N.L.E - Graphical Method",
            "N.L.E - Iterative Method",
            "N.L.E - Secant Method",
            "N.L.E - Newton Raphson Method",
            "N.S.L.E - Newton Raphson Method",
            "N.S.L.E - Iterative Method",
            "Spline Interpolation",
            "MATLAB"});
            this.checkedListBox_mid.Location = new System.Drawing.Point(119, 268);
            this.checkedListBox_mid.Name = "checkedListBox_mid";
            this.checkedListBox_mid.Size = new System.Drawing.Size(408, 304);
            this.checkedListBox_mid.TabIndex = 59;
            // 
            // label_midterm
            // 
            this.label_midterm.AutoSize = true;
            this.label_midterm.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_midterm.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_midterm.Location = new System.Drawing.Point(115, 231);
            this.label_midterm.Name = "label_midterm";
            this.label_midterm.Size = new System.Drawing.Size(103, 34);
            this.label_midterm.TabIndex = 56;
            this.label_midterm.Text = "Mid Term";
            // 
            // labe_course_name
            // 
            this.labe_course_name.AutoSize = true;
            this.labe_course_name.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labe_course_name.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labe_course_name.Location = new System.Drawing.Point(114, 161);
            this.labe_course_name.Name = "labe_course_name";
            this.labe_course_name.Size = new System.Drawing.Size(591, 37);
            this.labe_course_name.TabIndex = 57;
            this.labe_course_name.Text = "Numerical Methods for Science and Engineering Topics";
            // 
            // label_progression
            // 
            this.label_progression.AutoSize = true;
            this.label_progression.BackColor = System.Drawing.Color.RoyalBlue;
            this.label_progression.Font = new System.Drawing.Font("Poppins Medium", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_progression.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_progression.Location = new System.Drawing.Point(108, 25);
            this.label_progression.Name = "label_progression";
            this.label_progression.Size = new System.Drawing.Size(386, 65);
            this.label_progression.TabIndex = 54;
            this.label_progression.Text = "Syllabus Checklist";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox1.Location = new System.Drawing.Point(-1571, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(3840, 113);
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // Math5_topics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label_progress_next);
            this.Controls.Add(this.label_return_progress);
            this.Controls.Add(this.checkedListBox_final);
            this.Controls.Add(this.label_finalterm);
            this.Controls.Add(this.checkedListBox_mid);
            this.Controls.Add(this.label_midterm);
            this.Controls.Add(this.labe_course_name);
            this.Controls.Add(this.label_progression);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Math5_topics";
            this.Text = "Math5_topics";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_progress_next;
        private System.Windows.Forms.Label label_return_progress;
        private System.Windows.Forms.CheckedListBox checkedListBox_final;
        private System.Windows.Forms.Label label_finalterm;
        private System.Windows.Forms.CheckedListBox checkedListBox_mid;
        private System.Windows.Forms.Label label_midterm;
        private System.Windows.Forms.Label labe_course_name;
        private System.Windows.Forms.Label label_progression;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}