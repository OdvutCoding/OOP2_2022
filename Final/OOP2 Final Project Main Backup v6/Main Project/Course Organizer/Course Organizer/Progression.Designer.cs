namespace Course_Organizer
{
    partial class Progression1
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
            this.labe_course_name = new System.Windows.Forms.Label();
            this.label_progression = new System.Windows.Forms.Label();
            this.checkedListBox_mid = new System.Windows.Forms.CheckedListBox();
            this.label_midterm = new System.Windows.Forms.Label();
            this.label_finalterm = new System.Windows.Forms.Label();
            this.checkedListBox_final = new System.Windows.Forms.CheckedListBox();
            this.label_return_progress = new System.Windows.Forms.Label();
            this.progressbar_mid = new System.Windows.Forms.ProgressBar();
            this.progressbar_final = new System.Windows.Forms.ProgressBar();
            this.label_progress_next = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labe_course_name
            // 
            this.labe_course_name.AutoSize = true;
            this.labe_course_name.Font = new System.Drawing.Font("Poppins", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labe_course_name.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labe_course_name.Location = new System.Drawing.Point(61, 104);
            this.labe_course_name.Name = "labe_course_name";
            this.labe_course_name.Size = new System.Drawing.Size(348, 30);
            this.labe_course_name.TabIndex = 40;
            this.labe_course_name.Text = "Object Oriented Prorgramming 2 Topics";
            // 
            // label_progression
            // 
            this.label_progression.AutoSize = true;
            this.label_progression.Font = new System.Drawing.Font("Poppins Medium", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_progression.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_progression.Location = new System.Drawing.Point(55, 29);
            this.label_progression.Name = "label_progression";
            this.label_progression.Size = new System.Drawing.Size(386, 65);
            this.label_progression.TabIndex = 39;
            this.label_progression.Text = "Syllabus Checklist";
            // 
            // checkedListBox_mid
            // 
            this.checkedListBox_mid.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.checkedListBox_mid.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox_mid.ForeColor = System.Drawing.Color.RoyalBlue;
            this.checkedListBox_mid.FormattingEnabled = true;
            this.checkedListBox_mid.Items.AddRange(new object[] {
            "Overview of .NET Framework ",
            "Introduction to VS coding  ",
            "C# Data Types  ",
            "Type Casting  ",
            "Named parameter, Default value parameter  ",
            "Types of variables ",
            "Types of method (static vs instance) ",
            "Structures vs class ",
            "Enumeration ",
            "String vs string",
            "Use of params, ref, out *** MCQ topic",
            "OOP principles ",
            "Understand the concept of Class and Object ",
            "Constructors vs Method ",
            "The keywords Readonly and Const  ",
            "Variable Types (local,class,instance,const,read-only) ",
            "Encapsulation & Properties ",
            "Polymorphism ",
            "Array, Jagged array ",
            "Inheritance, (Single, Multilevel, Hierarchical Inheritance)  ",
            "HAS-A relationship  ",
            "IS-A relationship",
            "Quiz 1",
            "Quiz 2",
            "Quiz 3  "});
            this.checkedListBox_mid.Location = new System.Drawing.Point(66, 173);
            this.checkedListBox_mid.Name = "checkedListBox_mid";
            this.checkedListBox_mid.Size = new System.Drawing.Size(356, 136);
            this.checkedListBox_mid.TabIndex = 41;
            // 
            // label_midterm
            // 
            this.label_midterm.AutoSize = true;
            this.label_midterm.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_midterm.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_midterm.Location = new System.Drawing.Point(61, 144);
            this.label_midterm.Name = "label_midterm";
            this.label_midterm.Size = new System.Drawing.Size(81, 26);
            this.label_midterm.TabIndex = 40;
            this.label_midterm.Text = "Mid Term";
            // 
            // label_finalterm
            // 
            this.label_finalterm.AutoSize = true;
            this.label_finalterm.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_finalterm.ForeColor = System.Drawing.Color.SlateBlue;
            this.label_finalterm.Location = new System.Drawing.Point(61, 362);
            this.label_finalterm.Name = "label_finalterm";
            this.label_finalterm.Size = new System.Drawing.Size(90, 26);
            this.label_finalterm.TabIndex = 40;
            this.label_finalterm.Text = "Final Term";
            // 
            // checkedListBox_final
            // 
            this.checkedListBox_final.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox_final.ForeColor = System.Drawing.Color.SlateBlue;
            this.checkedListBox_final.FormattingEnabled = true;
            this.checkedListBox_final.Items.AddRange(new object[] {
            "Abstraction in C#",
            "Interface",
            "Constructor chaining",
            "Generics in C#",
            "Delegates",
            "Project Proposal",
            "Progress report 1",
            "Progress report 2  ",
            "Progress report 3",
            "Quiz 1",
            "Quiz 2",
            "Quiz 3",
            "Project Defense  "});
            this.checkedListBox_final.Location = new System.Drawing.Point(66, 391);
            this.checkedListBox_final.Name = "checkedListBox_final";
            this.checkedListBox_final.Size = new System.Drawing.Size(356, 136);
            this.checkedListBox_final.TabIndex = 41;
            // 
            // label_return_progress
            // 
            this.label_return_progress.AutoSize = true;
            this.label_return_progress.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_return_progress.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_return_progress.Location = new System.Drawing.Point(58, 604);
            this.label_return_progress.Name = "label_return_progress";
            this.label_return_progress.Size = new System.Drawing.Size(35, 48);
            this.label_return_progress.TabIndex = 42;
            this.label_return_progress.Text = "<";
            this.label_return_progress.Click += new System.EventHandler(this.label_return_progress_Click);
            // 
            // progressbar_mid
            // 
            this.progressbar_mid.BackColor = System.Drawing.SystemColors.Control;
            this.progressbar_mid.ForeColor = System.Drawing.Color.RoyalBlue;
            this.progressbar_mid.Location = new System.Drawing.Point(66, 315);
            this.progressbar_mid.Name = "progressbar_mid";
            this.progressbar_mid.Size = new System.Drawing.Size(356, 23);
            this.progressbar_mid.TabIndex = 43;
            // 
            // progressbar_final
            // 
            this.progressbar_final.BackColor = System.Drawing.SystemColors.Control;
            this.progressbar_final.ForeColor = System.Drawing.Color.SlateBlue;
            this.progressbar_final.Location = new System.Drawing.Point(66, 533);
            this.progressbar_final.Name = "progressbar_final";
            this.progressbar_final.Size = new System.Drawing.Size(356, 23);
            this.progressbar_final.TabIndex = 43;
            // 
            // label_progress_next
            // 
            this.label_progress_next.AutoSize = true;
            this.label_progress_next.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_progress_next.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_progress_next.Location = new System.Drawing.Point(543, 604);
            this.label_progress_next.Name = "label_progress_next";
            this.label_progress_next.Size = new System.Drawing.Size(35, 48);
            this.label_progress_next.TabIndex = 42;
            this.label_progress_next.Text = ">";
            this.label_progress_next.Click += new System.EventHandler(this.label_progress_next_Click);
            // 
            // Progression1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 748);
            this.Controls.Add(this.progressbar_final);
            this.Controls.Add(this.progressbar_mid);
            this.Controls.Add(this.label_progress_next);
            this.Controls.Add(this.label_return_progress);
            this.Controls.Add(this.checkedListBox_final);
            this.Controls.Add(this.label_finalterm);
            this.Controls.Add(this.checkedListBox_mid);
            this.Controls.Add(this.label_midterm);
            this.Controls.Add(this.labe_course_name);
            this.Controls.Add(this.label_progression);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Progression1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Progression";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labe_course_name;
        private System.Windows.Forms.Label label_progression;
        private System.Windows.Forms.CheckedListBox checkedListBox_mid;
        private System.Windows.Forms.Label label_midterm;
        private System.Windows.Forms.Label label_finalterm;
        private System.Windows.Forms.CheckedListBox checkedListBox_final;
        private System.Windows.Forms.Label label_return_progress;
        private System.Windows.Forms.ProgressBar progressbar_mid;
        private System.Windows.Forms.ProgressBar progressbar_final;
        private System.Windows.Forms.Label label_progress_next;
    }
}