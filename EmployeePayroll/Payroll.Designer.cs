namespace EmployeePayroll
{
    partial class Payroll
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.createFileBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fileNameLbl = new System.Windows.Forms.Label();
            this.listOfEmployees = new System.Windows.Forms.ListBox();
            this.enterBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createFileBtn
            // 
            this.createFileBtn.Location = new System.Drawing.Point(41, 77);
            this.createFileBtn.Name = "createFileBtn";
            this.createFileBtn.Size = new System.Drawing.Size(152, 36);
            this.createFileBtn.TabIndex = 0;
            this.createFileBtn.Text = "Create / Edit File";
            this.createFileBtn.UseVisualStyleBackColor = true;
            this.createFileBtn.Click += new System.EventHandler(this.createFileBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Create Payroll";
            // 
            // fileNameLbl
            // 
            this.fileNameLbl.AutoSize = true;
            this.fileNameLbl.Location = new System.Drawing.Point(281, 93);
            this.fileNameLbl.Name = "fileNameLbl";
            this.fileNameLbl.Size = new System.Drawing.Size(0, 20);
            this.fileNameLbl.TabIndex = 2;
            // 
            // listOfEmployees
            // 
            this.listOfEmployees.FormattingEnabled = true;
            this.listOfEmployees.ItemHeight = 20;
            this.listOfEmployees.Location = new System.Drawing.Point(293, 150);
            this.listOfEmployees.Name = "listOfEmployees";
            this.listOfEmployees.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listOfEmployees.Size = new System.Drawing.Size(302, 364);
            this.listOfEmployees.TabIndex = 3;
            this.listOfEmployees.SelectedIndexChanged += new System.EventHandler(this.listOfEmployees_SelectedIndexChanged);
            // 
            // enterBtn
            // 
            this.enterBtn.Location = new System.Drawing.Point(518, 520);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(77, 35);
            this.enterBtn.TabIndex = 4;
            this.enterBtn.Text = "Enter";
            this.enterBtn.UseVisualStyleBackColor = true;
            this.enterBtn.Visible = false;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(293, 520);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(77, 35);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Visible = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(412, 520);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(77, 35);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Visible = false;
            // 
            // Payroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(888, 671);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.enterBtn);
            this.Controls.Add(this.listOfEmployees);
            this.Controls.Add(this.fileNameLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createFileBtn);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Payroll";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button createFileBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fileNameLbl;
        private System.Windows.Forms.ListBox listOfEmployees;
        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
    }
}