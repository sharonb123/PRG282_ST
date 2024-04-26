namespace Buhlungu_Sharon_PRG281_ST
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpBoxDisplaybtns = new System.Windows.Forms.GroupBox();
            this.btnViewAllStudents = new System.Windows.Forms.Button();
            this.btnViewPartTime = new System.Windows.Forms.Button();
            this.btnViewFullTime = new System.Windows.Forms.Button();
            this.grpboxNavigation = new System.Windows.Forms.GroupBox();
            this.btnToFirst = new System.Windows.Forms.Button();
            this.btnToNext = new System.Windows.Forms.Button();
            this.btnToPrevious = new System.Windows.Forms.Button();
            this.btnToLast = new System.Windows.Forms.Button();
            this.grpBoxStudentDetails = new System.Windows.Forms.GroupBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblMark = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.lblFees = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.btnStudName = new System.Windows.Forms.Button();
            this.btnMarks = new System.Windows.Forms.Button();
            this.btnResults = new System.Windows.Forms.Button();
            this.btnFees = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.grpBoxSearchStudent = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStudent = new System.Windows.Forms.TextBox();
            this.btnSearchStudent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpBoxDisplaybtns.SuspendLayout();
            this.grpboxNavigation.SuspendLayout();
            this.grpBoxStudentDetails.SuspendLayout();
            this.grpBoxSearchStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("PMingLiU-ExtB", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(91, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(275, 32);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Student Mark System";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(424, 141);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(476, 22);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(145, 37);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpBoxDisplaybtns
            // 
            this.grpBoxDisplaybtns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.grpBoxDisplaybtns.Controls.Add(this.btnViewFullTime);
            this.grpBoxDisplaybtns.Controls.Add(this.btnViewPartTime);
            this.grpBoxDisplaybtns.Controls.Add(this.btnViewAllStudents);
            this.grpBoxDisplaybtns.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxDisplaybtns.ForeColor = System.Drawing.Color.Red;
            this.grpBoxDisplaybtns.Location = new System.Drawing.Point(470, 80);
            this.grpBoxDisplaybtns.Name = "grpBoxDisplaybtns";
            this.grpBoxDisplaybtns.Size = new System.Drawing.Size(151, 141);
            this.grpBoxDisplaybtns.TabIndex = 3;
            this.grpBoxDisplaybtns.TabStop = false;
            this.grpBoxDisplaybtns.Text = " Display Buttons";
            // 
            // btnViewAllStudents
            // 
            this.btnViewAllStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAllStudents.ForeColor = System.Drawing.Color.Black;
            this.btnViewAllStudents.Location = new System.Drawing.Point(6, 19);
            this.btnViewAllStudents.Name = "btnViewAllStudents";
            this.btnViewAllStudents.Size = new System.Drawing.Size(139, 27);
            this.btnViewAllStudents.TabIndex = 0;
            this.btnViewAllStudents.Text = "View All Students";
            this.btnViewAllStudents.UseVisualStyleBackColor = true;
            this.btnViewAllStudents.Click += new System.EventHandler(this.btnViewAllStudents_Click);
            // 
            // btnViewPartTime
            // 
            this.btnViewPartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewPartTime.ForeColor = System.Drawing.Color.Black;
            this.btnViewPartTime.Location = new System.Drawing.Point(6, 52);
            this.btnViewPartTime.Name = "btnViewPartTime";
            this.btnViewPartTime.Size = new System.Drawing.Size(139, 37);
            this.btnViewPartTime.TabIndex = 1;
            this.btnViewPartTime.Text = "View Part Time";
            this.btnViewPartTime.UseVisualStyleBackColor = true;
            this.btnViewPartTime.Click += new System.EventHandler(this.btnViewPartTime_Click);
            // 
            // btnViewFullTime
            // 
            this.btnViewFullTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewFullTime.ForeColor = System.Drawing.Color.Black;
            this.btnViewFullTime.Location = new System.Drawing.Point(6, 95);
            this.btnViewFullTime.Name = "btnViewFullTime";
            this.btnViewFullTime.Size = new System.Drawing.Size(139, 37);
            this.btnViewFullTime.TabIndex = 2;
            this.btnViewFullTime.Text = "View Full Time ";
            this.btnViewFullTime.UseVisualStyleBackColor = true;
            this.btnViewFullTime.Click += new System.EventHandler(this.btnViewFullTime_Click);
            // 
            // grpboxNavigation
            // 
            this.grpboxNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.grpboxNavigation.Controls.Add(this.btnToLast);
            this.grpboxNavigation.Controls.Add(this.btnToPrevious);
            this.grpboxNavigation.Controls.Add(this.btnToNext);
            this.grpboxNavigation.Controls.Add(this.btnToFirst);
            this.grpboxNavigation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxNavigation.ForeColor = System.Drawing.Color.Red;
            this.grpboxNavigation.Location = new System.Drawing.Point(26, 236);
            this.grpboxNavigation.Name = "grpboxNavigation";
            this.grpboxNavigation.Size = new System.Drawing.Size(424, 80);
            this.grpboxNavigation.TabIndex = 4;
            this.grpboxNavigation.TabStop = false;
            this.grpboxNavigation.Text = "Navigations";
            // 
            // btnToFirst
            // 
            this.btnToFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToFirst.ForeColor = System.Drawing.Color.Blue;
            this.btnToFirst.Location = new System.Drawing.Point(19, 38);
            this.btnToFirst.Name = "btnToFirst";
            this.btnToFirst.Size = new System.Drawing.Size(75, 23);
            this.btnToFirst.TabIndex = 0;
            this.btnToFirst.Text = "|<";
            this.btnToFirst.UseVisualStyleBackColor = true;
            this.btnToFirst.Click += new System.EventHandler(this.btnToFirst_Click);
            // 
            // btnToNext
            // 
            this.btnToNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToNext.ForeColor = System.Drawing.Color.Blue;
            this.btnToNext.Location = new System.Drawing.Point(117, 38);
            this.btnToNext.Name = "btnToNext";
            this.btnToNext.Size = new System.Drawing.Size(75, 23);
            this.btnToNext.TabIndex = 1;
            this.btnToNext.Text = ">>";
            this.btnToNext.UseVisualStyleBackColor = true;
            this.btnToNext.Click += new System.EventHandler(this.btnToNext_Click);
            // 
            // btnToPrevious
            // 
            this.btnToPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToPrevious.ForeColor = System.Drawing.Color.Blue;
            this.btnToPrevious.Location = new System.Drawing.Point(210, 38);
            this.btnToPrevious.Name = "btnToPrevious";
            this.btnToPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnToPrevious.TabIndex = 2;
            this.btnToPrevious.Text = "<<";
            this.btnToPrevious.UseVisualStyleBackColor = true;
            this.btnToPrevious.Click += new System.EventHandler(this.btnToPrevious_Click);
            // 
            // btnToLast
            // 
            this.btnToLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToLast.ForeColor = System.Drawing.Color.Blue;
            this.btnToLast.Location = new System.Drawing.Point(313, 38);
            this.btnToLast.Name = "btnToLast";
            this.btnToLast.Size = new System.Drawing.Size(75, 23);
            this.btnToLast.TabIndex = 3;
            this.btnToLast.Text = ">|";
            this.btnToLast.UseVisualStyleBackColor = true;
            this.btnToLast.Click += new System.EventHandler(this.btnToLast_Click);
            // 
            // grpBoxStudentDetails
            // 
            this.grpBoxStudentDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.grpBoxStudentDetails.Controls.Add(this.btnPayment);
            this.grpBoxStudentDetails.Controls.Add(this.btnFees);
            this.grpBoxStudentDetails.Controls.Add(this.btnResults);
            this.grpBoxStudentDetails.Controls.Add(this.btnMarks);
            this.grpBoxStudentDetails.Controls.Add(this.btnStudName);
            this.grpBoxStudentDetails.Controls.Add(this.lblPayment);
            this.grpBoxStudentDetails.Controls.Add(this.lblFees);
            this.grpBoxStudentDetails.Controls.Add(this.lblResults);
            this.grpBoxStudentDetails.Controls.Add(this.lblMark);
            this.grpBoxStudentDetails.Controls.Add(this.lblStudentName);
            this.grpBoxStudentDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxStudentDetails.ForeColor = System.Drawing.Color.Red;
            this.grpBoxStudentDetails.Location = new System.Drawing.Point(26, 333);
            this.grpBoxStudentDetails.Name = "grpBoxStudentDetails";
            this.grpBoxStudentDetails.Size = new System.Drawing.Size(595, 100);
            this.grpBoxStudentDetails.TabIndex = 5;
            this.grpBoxStudentDetails.TabStop = false;
            this.grpBoxStudentDetails.Text = "StudentDetails";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.ForeColor = System.Drawing.Color.Maroon;
            this.lblStudentName.Location = new System.Drawing.Point(16, 65);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(98, 15);
            this.lblStudentName.TabIndex = 0;
            this.lblStudentName.Text = "Student Name";
            // 
            // lblMark
            // 
            this.lblMark.AutoSize = true;
            this.lblMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMark.ForeColor = System.Drawing.Color.Maroon;
            this.lblMark.Location = new System.Drawing.Point(165, 65);
            this.lblMark.Name = "lblMark";
            this.lblMark.Size = new System.Drawing.Size(39, 15);
            this.lblMark.TabIndex = 1;
            this.lblMark.Text = "Mark";
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.ForeColor = System.Drawing.Color.Maroon;
            this.lblResults.Location = new System.Drawing.Point(254, 65);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(55, 15);
            this.lblResults.TabIndex = 2;
            this.lblResults.Text = "Results";
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFees.ForeColor = System.Drawing.Color.Maroon;
            this.lblFees.Location = new System.Drawing.Point(371, 65);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(38, 15);
            this.lblFees.TabIndex = 3;
            this.lblFees.Text = "Fees";
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.ForeColor = System.Drawing.Color.Maroon;
            this.lblPayment.Location = new System.Drawing.Point(465, 65);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(62, 15);
            this.lblPayment.TabIndex = 4;
            this.lblPayment.Text = "Payment";
            // 
            // btnStudName
            // 
            this.btnStudName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnStudName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStudName.ForeColor = System.Drawing.Color.Blue;
            this.btnStudName.Location = new System.Drawing.Point(19, 39);
            this.btnStudName.Name = "btnStudName";
            this.btnStudName.Size = new System.Drawing.Size(110, 23);
            this.btnStudName.TabIndex = 5;
            this.btnStudName.Text = "Student Name";
            this.btnStudName.UseVisualStyleBackColor = false;
            // 
            // btnMarks
            // 
            this.btnMarks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnMarks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMarks.ForeColor = System.Drawing.Color.Blue;
            this.btnMarks.Location = new System.Drawing.Point(156, 39);
            this.btnMarks.Name = "btnMarks";
            this.btnMarks.Size = new System.Drawing.Size(70, 23);
            this.btnMarks.TabIndex = 6;
            this.btnMarks.Text = "Mark";
            this.btnMarks.UseVisualStyleBackColor = false;
            // 
            // btnResults
            // 
            this.btnResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnResults.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnResults.ForeColor = System.Drawing.Color.Blue;
            this.btnResults.Location = new System.Drawing.Point(257, 39);
            this.btnResults.Name = "btnResults";
            this.btnResults.Size = new System.Drawing.Size(70, 23);
            this.btnResults.TabIndex = 7;
            this.btnResults.Text = "Results";
            this.btnResults.UseVisualStyleBackColor = false;
            // 
            // btnFees
            // 
            this.btnFees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnFees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFees.ForeColor = System.Drawing.Color.Blue;
            this.btnFees.Location = new System.Drawing.Point(362, 39);
            this.btnFees.Name = "btnFees";
            this.btnFees.Size = new System.Drawing.Size(70, 23);
            this.btnFees.TabIndex = 8;
            this.btnFees.Text = "Fees";
            this.btnFees.UseVisualStyleBackColor = false;
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnPayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPayment.ForeColor = System.Drawing.Color.Blue;
            this.btnPayment.Location = new System.Drawing.Point(468, 39);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(70, 23);
            this.btnPayment.TabIndex = 9;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = false;
            // 
            // grpBoxSearchStudent
            // 
            this.grpBoxSearchStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.grpBoxSearchStudent.Controls.Add(this.btnSearchStudent);
            this.grpBoxSearchStudent.Controls.Add(this.txtStudent);
            this.grpBoxSearchStudent.Controls.Add(this.label1);
            this.grpBoxSearchStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxSearchStudent.ForeColor = System.Drawing.Color.Red;
            this.grpBoxSearchStudent.Location = new System.Drawing.Point(470, 227);
            this.grpBoxSearchStudent.Name = "grpBoxSearchStudent";
            this.grpBoxSearchStudent.Size = new System.Drawing.Size(151, 100);
            this.grpBoxSearchStudent.TabIndex = 6;
            this.grpBoxSearchStudent.TabStop = false;
            this.grpBoxSearchStudent.Text = "Search Student";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Student Number";
            // 
            // txtStudent
            // 
            this.txtStudent.Location = new System.Drawing.Point(7, 47);
            this.txtStudent.Name = "txtStudent";
            this.txtStudent.Size = new System.Drawing.Size(138, 20);
            this.txtStudent.TabIndex = 1;
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchStudent.ForeColor = System.Drawing.Color.Blue;
            this.btnSearchStudent.Location = new System.Drawing.Point(7, 71);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(138, 23);
            this.btnSearchStudent.TabIndex = 2;
            this.btnSearchStudent.Text = "Search Student";
            this.btnSearchStudent.UseVisualStyleBackColor = true;
            this.btnSearchStudent.Click += new System.EventHandler(this.btnSearchStudent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 436);
            this.Controls.Add(this.grpBoxSearchStudent);
            this.Controls.Add(this.grpBoxStudentDetails);
            this.Controls.Add(this.grpboxNavigation);
            this.Controls.Add(this.grpBoxDisplaybtns);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblHeading);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpBoxDisplaybtns.ResumeLayout(false);
            this.grpboxNavigation.ResumeLayout(false);
            this.grpBoxStudentDetails.ResumeLayout(false);
            this.grpBoxStudentDetails.PerformLayout();
            this.grpBoxSearchStudent.ResumeLayout(false);
            this.grpBoxSearchStudent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpBoxDisplaybtns;
        private System.Windows.Forms.Button btnViewFullTime;
        private System.Windows.Forms.Button btnViewPartTime;
        private System.Windows.Forms.Button btnViewAllStudents;
        private System.Windows.Forms.GroupBox grpboxNavigation;
        private System.Windows.Forms.Button btnToPrevious;
        private System.Windows.Forms.Button btnToNext;
        private System.Windows.Forms.Button btnToFirst;
        private System.Windows.Forms.Button btnToLast;
        private System.Windows.Forms.GroupBox grpBoxStudentDetails;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Label lblMark;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnFees;
        private System.Windows.Forms.Button btnResults;
        private System.Windows.Forms.Button btnMarks;
        private System.Windows.Forms.Button btnStudName;
        private System.Windows.Forms.GroupBox grpBoxSearchStudent;
        private System.Windows.Forms.Button btnSearchStudent;
        private System.Windows.Forms.TextBox txtStudent;
        private System.Windows.Forms.Label label1;
    }
}

