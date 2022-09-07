namespace studentProgram
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgwOgrenciler = new System.Windows.Forms.DataGridView();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.tbxStudentFirstName = new System.Windows.Forms.TextBox();
            this.tbxStudentLastName = new System.Windows.Forms.TextBox();
            this.tbxStudentNumber = new System.Windows.Forms.TextBox();
            this.lblStudentFirstName = new System.Windows.Forms.Label();
            this.lblStudentLastName = new System.Windows.Forms.Label();
            this.lblStudentNumber = new System.Windows.Forms.Label();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.tbxSearchStudent = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOgrenciler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwOgrenciler
            // 
            this.dgwOgrenciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOgrenciler.Location = new System.Drawing.Point(497, 91);
            this.dgwOgrenciler.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgwOgrenciler.Name = "dgwOgrenciler";
            this.dgwOgrenciler.RowHeadersWidth = 51;
            this.dgwOgrenciler.RowTemplate.Height = 25;
            this.dgwOgrenciler.Size = new System.Drawing.Size(405, 440);
            this.dgwOgrenciler.TabIndex = 0;
            this.dgwOgrenciler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwOgrenciler_CellContentClick);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(233, 249);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(98, 32);
            this.btnAddStudent.TabIndex = 1;
            this.btnAddStudent.Text = "Add";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // tbxStudentFirstName
            // 
            this.tbxStudentFirstName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxStudentFirstName.Location = new System.Drawing.Point(233, 95);
            this.tbxStudentFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxStudentFirstName.Name = "tbxStudentFirstName";
            this.tbxStudentFirstName.Size = new System.Drawing.Size(220, 39);
            this.tbxStudentFirstName.TabIndex = 2;
            // 
            // tbxStudentLastName
            // 
            this.tbxStudentLastName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxStudentLastName.Location = new System.Drawing.Point(233, 147);
            this.tbxStudentLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxStudentLastName.Name = "tbxStudentLastName";
            this.tbxStudentLastName.Size = new System.Drawing.Size(220, 39);
            this.tbxStudentLastName.TabIndex = 3;
            // 
            // tbxStudentNumber
            // 
            this.tbxStudentNumber.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxStudentNumber.Location = new System.Drawing.Point(233, 199);
            this.tbxStudentNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxStudentNumber.Name = "tbxStudentNumber";
            this.tbxStudentNumber.Size = new System.Drawing.Size(220, 39);
            this.tbxStudentNumber.TabIndex = 4;
            // 
            // lblStudentFirstName
            // 
            this.lblStudentFirstName.AutoSize = true;
            this.lblStudentFirstName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStudentFirstName.Location = new System.Drawing.Point(145, 102);
            this.lblStudentFirstName.Name = "lblStudentFirstName";
            this.lblStudentFirstName.Size = new System.Drawing.Size(73, 32);
            this.lblStudentFirstName.TabIndex = 5;
            this.lblStudentFirstName.Text = "NAME :";
            // 
            // lblStudentLastName
            // 
            this.lblStudentLastName.AutoSize = true;
            this.lblStudentLastName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStudentLastName.Location = new System.Drawing.Point(120, 151);
            this.lblStudentLastName.Name = "lblStudentLastName";
            this.lblStudentLastName.Size = new System.Drawing.Size(116, 32);
            this.lblStudentLastName.TabIndex = 6;
            this.lblStudentLastName.Text = "SURNAME :";
            this.lblStudentLastName.Click += new System.EventHandler(this.lblStudentLastName_Click);
            // 
            // lblStudentNumber
            // 
            this.lblStudentNumber.AutoSize = true;
            this.lblStudentNumber.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStudentNumber.Location = new System.Drawing.Point(112, 203);
            this.lblStudentNumber.Name = "lblStudentNumber";
            this.lblStudentNumber.Size = new System.Drawing.Size(126, 32);
            this.lblStudentNumber.TabIndex = 7;
            this.lblStudentNumber.Text = "NUMBER :";
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(355, 251);
            this.btnDeleteStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(98, 31);
            this.btnDeleteStudent.TabIndex = 8;
            this.btnDeleteStudent.Text = "DELETE";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // tbxSearchStudent
            // 
            this.tbxSearchStudent.Location = new System.Drawing.Point(496, 56);
            this.tbxSearchStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxSearchStudent.Name = "tbxSearchStudent";
            this.tbxSearchStudent.Size = new System.Drawing.Size(404, 27);
            this.tbxSearchStudent.TabIndex = 9;
            this.tbxSearchStudent.TextChanged += new System.EventHandler(this.tbxSearchStudent_TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(120, 249);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(98, 32);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(496, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Type the name you want to search: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tbxSearchStudent);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.lblStudentNumber);
            this.Controls.Add(this.lblStudentLastName);
            this.Controls.Add(this.lblStudentFirstName);
            this.Controls.Add(this.tbxStudentNumber);
            this.Controls.Add(this.tbxStudentLastName);
            this.Controls.Add(this.tbxStudentFirstName);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.dgwOgrenciler);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwOgrenciler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.TextBox tbxStudentFirstName;
        private System.Windows.Forms.TextBox tbxStudentLastName;
        private System.Windows.Forms.TextBox tbxStudentNumber;
        private System.Windows.Forms.Label lblStudentFirstName;
        private System.Windows.Forms.Label lblStudentLastName;
        private System.Windows.Forms.Label lblStudentNumber;
        public System.Windows.Forms.DataGridView dgwOgrenciler;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.TextBox tbxSearchStudent;
        private System.Windows.Forms.Button btnUptadeStudent;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
    }
}
