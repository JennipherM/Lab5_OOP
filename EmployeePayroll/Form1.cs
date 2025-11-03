using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeePayroll
{
    public partial class Form1 : Form
    {
        string employeeType;
        
        public Form1()
        {
            InitializeComponent();
        }

        // for add and view buttons
        public void taskOptions_Click(object sender, EventArgs e)
        {
            if (sender == addBtn)
            {               
                radioGroup.Visible = true;
                infoGroup.Visible = false;
                employeeListView.Visible = false;
            }
            else
            {
                employeeListView.Visible = true;
                radioGroup.Visible = false;
                infoGroup.Visible = false;
            }
        }
        public void radioOptions(object sender, EventArgs e)
        {
            infoGroup.Visible = true;
            clearBoxes();
            messageLbl.Text = "";

            //changes employee info fields depending on which type was choosen
            if (sender == salaryRadio)
            {
                employeeType = "Salary";

                lastLbl.Visible = false;
                lastBox.Visible = false;

                payLbl.Text = "Weekly Salary:";
            }
            else
            {
                lastLbl.Visible = true;
                lastBox.Visible = true;

                if (sender == hourlyRadio)
                {
                    employeeType = "Hourly";

                    payLbl.Text = "Hour Rate:";
                    lastLbl.Text = "Hours Worked:";
                }
                else
                {
                    employeeType = "Commission";

                    payLbl.Text = "Commission Rate:";
                    lastLbl.Text = "Sales Amount:";
                }
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if(firstName.Text == "" || lastName.Text == "" || ssn.Text == "" || pay.Text == "" || (lastBox.Visible == true && lastBox.Text == ""))
            {
                messageLbl.Text = "Fill in all fields";
                return;
            }

            if (employeeType == "Salary")
            {
                SalaryEmployee salaryEmployee = new SalaryEmployee(firstName.Text, lastName.Text, ssn.Text, Convert.ToSingle(pay.Text));

                addToListBox(salaryEmployee);
            }
            else if (employeeType == "Hourly")
            {
                HourlyEmployee hourlyEmployee = new HourlyEmployee(firstName.Text, lastName.Text, ssn.Text, Convert.ToSingle(pay.Text), Convert.ToSingle(lastBox.Text));

                addToListBox(hourlyEmployee);
            }
            else
            {
                if (Convert.ToSingle(pay.Text) < 0 || Convert.ToSingle(pay.Text) > 1)
                {
                    messageLbl.Text = "Commission rate must be a decimal\n(example: 0.25 for 25%)";
                    return;
                }

                CommissionEmployee commissionEmployee = new CommissionEmployee(firstName.Text, lastName.Text, ssn.Text, Convert.ToSingle(pay.Text), Convert.ToSingle(lastBox.Text));

                addToListBox(commissionEmployee);
            }
            messageLbl.Text = $"{employeeType} Employee Added!";
            clearBoxes();
        }

        //clear text boxes
        public void clearBoxes()
        {
            firstName.Text = "";
            lastName.Text = "";
            ssn.Text = "";
            pay.Text = "";
            lastBox.Text = "";
        }

        //add all employee info to list box for viewing
        public void addToListBox(Employee employee)
        {
            employeeListView.Items.Add(employee.ToString() + $"  |  Earnings: ${employee.Earnings()}");

            // add a blank line for readability
            employeeListView.Items.Add("   ");
        }
    }
}