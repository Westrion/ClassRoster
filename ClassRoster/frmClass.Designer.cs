namespace ClassRoster
{
    partial class frmClass
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
            if (disposing && (components != null)) {
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
            this.lblStudents = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMajor = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAssignements = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTests = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStudents
            // 
            this.lblStudents.FormattingEnabled = true;
            this.lblStudents.ItemHeight = 16;
            this.lblStudents.Location = new System.Drawing.Point(33, 70);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(203, 436);
            this.lblStudents.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(412, 115);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(46, 17);
            this.lblStudentName.TabIndex = 3;
            this.lblStudentName.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 4;
            this.label4.Tag = "";
            this.label4.Text = "Major";
            // 
            // lblMajor
            // 
            this.lblMajor.AutoSize = true;
            this.lblMajor.Location = new System.Drawing.Point(418, 196);
            this.lblMajor.Name = "lblMajor";
            this.lblMajor.Size = new System.Drawing.Size(46, 17);
            this.lblMajor.TabIndex = 5;
            this.lblMajor.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(368, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Assignements";
            // 
            // lblAssignements
            // 
            this.lblAssignements.AutoSize = true;
            this.lblAssignements.Location = new System.Drawing.Point(418, 301);
            this.lblAssignements.Name = "lblAssignements";
            this.lblAssignements.Size = new System.Drawing.Size(46, 17);
            this.lblAssignements.TabIndex = 7;
            this.lblAssignements.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(371, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Tests";
            // 
            // lblTests
            // 
            this.lblTests.AutoSize = true;
            this.lblTests.Location = new System.Drawing.Point(418, 392);
            this.lblTests.Name = "lblTests";
            this.lblTests.Size = new System.Drawing.Size(46, 17);
            this.lblTests.TabIndex = 9;
            this.lblTests.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(371, 432);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Grade";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(421, 465);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(54, 17);
            this.lblGrade.TabIndex = 11;
            this.lblGrade.Text = "label11";
            // 
            // frmClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 549);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblTests);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblAssignements);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblMajor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStudents);
            this.Name = "frmClass";
            this.Text = "Class Roster";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lblStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMajor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAssignements;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTests;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblGrade;
    }
}

