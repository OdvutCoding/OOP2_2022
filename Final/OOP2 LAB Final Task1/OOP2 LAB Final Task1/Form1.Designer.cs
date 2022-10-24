
namespace OOP2_LAB_Final_Task1
{
    partial class ComboBox
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
            this.comboBoxitems = new System.Windows.Forms.ComboBox();
            this.Combolist = new System.Windows.Forms.Label();
            this.textBoxitems = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Count = new System.Windows.Forms.Button();
            this.Sort = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxitems
            // 
            this.comboBoxitems.FormattingEnabled = true;
            this.comboBoxitems.Items.AddRange(new object[] {
            "Item a",
            "Item b",
            "Item c",
            "Item d",
            "Item e"});
            this.comboBoxitems.Location = new System.Drawing.Point(182, 119);
            this.comboBoxitems.Name = "comboBoxitems";
            this.comboBoxitems.Size = new System.Drawing.Size(203, 36);
            this.comboBoxitems.TabIndex = 0;
            // 
            // Combolist
            // 
            this.Combolist.AutoSize = true;
            this.Combolist.Location = new System.Drawing.Point(391, 127);
            this.Combolist.Name = "Combolist";
            this.Combolist.Size = new System.Drawing.Size(100, 28);
            this.Combolist.TabIndex = 1;
            this.Combolist.Text = "Combo List";
            // 
            // textBoxitems
            // 
            this.textBoxitems.Location = new System.Drawing.Point(182, 176);
            this.textBoxitems.Name = "textBoxitems";
            this.textBoxitems.Size = new System.Drawing.Size(203, 31);
            this.textBoxitems.TabIndex = 2;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(396, 176);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(95, 31);
            this.Add.TabIndex = 3;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Count
            // 
            this.Count.Location = new System.Drawing.Point(182, 276);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(89, 34);
            this.Count.TabIndex = 4;
            this.Count.Text = "Count";
            this.Count.UseVisualStyleBackColor = true;
            this.Count.Click += new System.EventHandler(this.Count_Click);
            // 
            // Sort
            // 
            this.Sort.Location = new System.Drawing.Point(277, 276);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(89, 34);
            this.Sort.TabIndex = 4;
            this.Sort.Text = "Sort";
            this.Sort.UseVisualStyleBackColor = true;
            this.Sort.Click += new System.EventHandler(this.Sort_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(372, 276);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(89, 34);
            this.Remove.TabIndex = 4;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(467, 276);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(89, 34);
            this.Clear.TabIndex = 4;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // ComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Sort);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.textBoxitems);
            this.Controls.Add(this.Combolist);
            this.Controls.Add(this.comboBoxitems);
            this.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ComboBox";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxitems;
        private System.Windows.Forms.Label Combolist;
        private System.Windows.Forms.TextBox textBoxitems;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Count;
        private System.Windows.Forms.Button Sort;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Clear;
    }
}

