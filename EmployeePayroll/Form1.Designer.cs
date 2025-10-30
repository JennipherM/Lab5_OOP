namespace EmployeePayroll
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
            this.label1 = new System.Windows.Forms.Label();
            this.tab = new System.Windows.Forms.TabControl();
            this.addTab = new System.Windows.Forms.TabPage();
            this.viewTab = new System.Windows.Forms.TabPage();
            this.radioGroup = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.salaryRadio = new System.Windows.Forms.RadioButton();
            this.hourlyRadio = new System.Windows.Forms.RadioButton();
            this.commRadio = new System.Windows.Forms.RadioButton();
            this.infoGroup = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.payLbl = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.ssn = new System.Windows.Forms.TextBox();
            this.pay = new System.Windows.Forms.TextBox();
            this.lastBox = new System.Windows.Forms.TextBox();
            this.lastLbl = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.messageLbl = new System.Windows.Forms.Label();
            this.tab.SuspendLayout();
            this.addTab.SuspendLayout();
            this.radioGroup.SuspendLayout();
            this.infoGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Payroll";
            // 
            // tab
            // 
            this.tab.Controls.Add(this.addTab);
            this.tab.Controls.Add(this.viewTab);
            this.tab.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab.Location = new System.Drawing.Point(38, 120);
            this.tab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(813, 556);
            this.tab.TabIndex = 1;
            // 
            // addTab
            // 
            this.addTab.Controls.Add(this.infoGroup);
            this.addTab.Controls.Add(this.radioGroup);
            this.addTab.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTab.Location = new System.Drawing.Point(4, 28);
            this.addTab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addTab.Name = "addTab";
            this.addTab.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addTab.Size = new System.Drawing.Size(805, 524);
            this.addTab.TabIndex = 0;
            this.addTab.Text = "Add Employee";
            this.addTab.UseVisualStyleBackColor = true;
            // 
            // viewTab
            // 
            this.viewTab.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewTab.Location = new System.Drawing.Point(4, 28);
            this.viewTab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.viewTab.Name = "viewTab";
            this.viewTab.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.viewTab.Size = new System.Drawing.Size(1106, 599);
            this.viewTab.TabIndex = 1;
            this.viewTab.Text = "View Employees";
            this.viewTab.UseVisualStyleBackColor = true;
            // 
            // radioGroup
            // 
            this.radioGroup.BackColor = System.Drawing.Color.LightBlue;
            this.radioGroup.Controls.Add(this.commRadio);
            this.radioGroup.Controls.Add(this.hourlyRadio);
            this.radioGroup.Controls.Add(this.salaryRadio);
            this.radioGroup.Controls.Add(this.label2);
            this.radioGroup.Location = new System.Drawing.Point(164, 34);
            this.radioGroup.Name = "radioGroup";
            this.radioGroup.Size = new System.Drawing.Size(476, 153);
            this.radioGroup.TabIndex = 0;
            this.radioGroup.TabStop = false;
            this.radioGroup.Text = "Employee Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Choose an employee type:";
            // 
            // salaryRadio
            // 
            this.salaryRadio.AutoSize = true;
            this.salaryRadio.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.salaryRadio.Location = new System.Drawing.Point(54, 85);
            this.salaryRadio.Name = "salaryRadio";
            this.salaryRadio.Size = new System.Drawing.Size(70, 24);
            this.salaryRadio.TabIndex = 1;
            this.salaryRadio.TabStop = true;
            this.salaryRadio.Text = "Salary";
            this.salaryRadio.UseVisualStyleBackColor = true;
            this.salaryRadio.CheckedChanged += new System.EventHandler(this.radioOptions);
            // 
            // hourlyRadio
            // 
            this.hourlyRadio.AutoSize = true;
            this.hourlyRadio.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.hourlyRadio.Location = new System.Drawing.Point(186, 85);
            this.hourlyRadio.Name = "hourlyRadio";
            this.hourlyRadio.Size = new System.Drawing.Size(76, 24);
            this.hourlyRadio.TabIndex = 2;
            this.hourlyRadio.TabStop = true;
            this.hourlyRadio.Text = "Hourly";
            this.hourlyRadio.UseVisualStyleBackColor = true;
            this.hourlyRadio.CheckedChanged += new System.EventHandler(this.radioOptions);
            // 
            // commRadio
            // 
            this.commRadio.AutoSize = true;
            this.commRadio.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.commRadio.Location = new System.Drawing.Point(306, 85);
            this.commRadio.Name = "commRadio";
            this.commRadio.Size = new System.Drawing.Size(116, 24);
            this.commRadio.TabIndex = 3;
            this.commRadio.TabStop = true;
            this.commRadio.Text = "Commission";
            this.commRadio.UseVisualStyleBackColor = true;
            this.commRadio.CheckedChanged += new System.EventHandler(this.radioOptions);
            // 
            // infoGroup
            // 
            this.infoGroup.BackColor = System.Drawing.Color.LightBlue;
            this.infoGroup.Controls.Add(this.messageLbl);
            this.infoGroup.Controls.Add(this.submitBtn);
            this.infoGroup.Controls.Add(this.lastBox);
            this.infoGroup.Controls.Add(this.lastLbl);
            this.infoGroup.Controls.Add(this.pay);
            this.infoGroup.Controls.Add(this.ssn);
            this.infoGroup.Controls.Add(this.lastName);
            this.infoGroup.Controls.Add(this.firstName);
            this.infoGroup.Controls.Add(this.payLbl);
            this.infoGroup.Controls.Add(this.label5);
            this.infoGroup.Controls.Add(this.label4);
            this.infoGroup.Controls.Add(this.label3);
            this.infoGroup.Location = new System.Drawing.Point(35, 208);
            this.infoGroup.Name = "infoGroup";
            this.infoGroup.Size = new System.Drawing.Size(735, 287);
            this.infoGroup.TabIndex = 1;
            this.infoGroup.TabStop = false;
            this.infoGroup.Text = "Employee Info";
            this.infoGroup.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.label3.Location = new System.Drawing.Point(30, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.label4.Location = new System.Drawing.Point(30, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Last Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.label5.Location = new System.Drawing.Point(30, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "SSN:";
            // 
            // payLbl
            // 
            this.payLbl.AutoSize = true;
            this.payLbl.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.payLbl.Location = new System.Drawing.Point(30, 187);
            this.payLbl.Name = "payLbl";
            this.payLbl.Size = new System.Drawing.Size(113, 20);
            this.payLbl.TabIndex = 3;
            this.payLbl.Text = "Weekly Salary:";
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(192, 48);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(150, 23);
            this.firstName.TabIndex = 4;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(192, 90);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(150, 23);
            this.lastName.TabIndex = 5;
            // 
            // ssn
            // 
            this.ssn.Location = new System.Drawing.Point(192, 137);
            this.ssn.Name = "ssn";
            this.ssn.Size = new System.Drawing.Size(150, 23);
            this.ssn.TabIndex = 6;
            // 
            // pay
            // 
            this.pay.Location = new System.Drawing.Point(192, 187);
            this.pay.Name = "pay";
            this.pay.Size = new System.Drawing.Size(150, 23);
            this.pay.TabIndex = 7;
            // 
            // lastBox
            // 
            this.lastBox.Location = new System.Drawing.Point(192, 237);
            this.lastBox.Name = "lastBox";
            this.lastBox.Size = new System.Drawing.Size(150, 23);
            this.lastBox.TabIndex = 9;
            this.lastBox.Visible = false;
            // 
            // lastLbl
            // 
            this.lastLbl.AutoSize = true;
            this.lastLbl.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.lastLbl.Location = new System.Drawing.Point(30, 237);
            this.lastLbl.Name = "lastLbl";
            this.lastLbl.Size = new System.Drawing.Size(0, 20);
            this.lastLbl.TabIndex = 8;
            this.lastLbl.Visible = false;
            // 
            // submitBtn
            // 
            this.submitBtn.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.submitBtn.Location = new System.Drawing.Point(618, 237);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(95, 37);
            this.submitBtn.TabIndex = 10;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // messageLbl
            // 
            this.messageLbl.AutoSize = true;
            this.messageLbl.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold);
            this.messageLbl.Location = new System.Drawing.Point(474, 203);
            this.messageLbl.Name = "messageLbl";
            this.messageLbl.Size = new System.Drawing.Size(0, 19);
            this.messageLbl.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(888, 710);
            this.Controls.Add(this.tab);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tab.ResumeLayout(false);
            this.addTab.ResumeLayout(false);
            this.radioGroup.ResumeLayout(false);
            this.radioGroup.PerformLayout();
            this.infoGroup.ResumeLayout(false);
            this.infoGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage addTab;
        private System.Windows.Forms.TabPage viewTab;
        private System.Windows.Forms.GroupBox radioGroup;
        private System.Windows.Forms.RadioButton commRadio;
        private System.Windows.Forms.RadioButton hourlyRadio;
        private System.Windows.Forms.RadioButton salaryRadio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox infoGroup;
        private System.Windows.Forms.Label payLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pay;
        private System.Windows.Forms.TextBox ssn;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox lastBox;
        private System.Windows.Forms.Label lastLbl;
        private System.Windows.Forms.Label messageLbl;
        private System.Windows.Forms.Button submitBtn;
    }
}

