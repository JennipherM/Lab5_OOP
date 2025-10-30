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

        // holds all the employees
        List<List<string>> fullEmployeeList = new List<List<string>>();

        // holds a single employees info
        List<string> singleEmployeeInfo = new List<string>();

        SalaryEmployee salaryEmployee;
        HourlyEmployee hourlyEmployee;
        CommissionEmployee commissionEmployee;

        public Form1()
        {
            InitializeComponent();
        }

        public void radioOptions(object sender, EventArgs e)
        {
            infoGroup.Visible = true;

            if (sender == salaryRadio)
            {
                employeeType = "Salary";

                lastLbl.Visible = false;
                lastBox.Visible = false; 

                payLbl.Text = "Weekly Salary:";
            }
            else if (sender == hourlyRadio)
            {
                employeeType = "Hourly";

                lastLbl.Visible = true;
                lastBox.Visible = true;

                payLbl.Text = "Hour Rate:";
                lastLbl.Text = "Hours Worked:";
            }
            else
            {
                employeeType = "Commission";

                lastLbl.Visible = true;
                lastBox.Visible = true; 

                payLbl.Text = "Commission Rate:";
                lastLbl.Text = "Sales Amount:";
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if(firstName.Text == "" || lastName.Text == "" || ssn.Text == "" || pay.Text == "" || (lastBox.Visible == true && lastBox.Text == ""))
            {
                messageLbl.Text = "Fill in all fields";
            }

            if(employeeType == "Salary")
            {
                salaryEmployee = new SalaryEmployee(firstName.Text, lastName.Text, ssn.Text, Convert.ToSingle(pay.Text));

                addToList(salaryEmployee);
                singleEmployeeInfo.Add(salaryEmployee.WeeklySalary.ToString());

            }
            else if (employeeType == "Hourly")
            {
                hourlyEmployee = new HourlyEmployee(firstName.Text, lastName.Text, ssn.Text, Convert.ToSingle(pay.Text), Convert.ToSingle(lastBox.Text));
            }
            else
            {
                commissionEmployee = new CommissionEmployee(firstName.Text, lastName.Text, ssn.Text, Convert.ToSingle(pay.Text), Convert.ToSingle(lastBox.Text));
            }

            messageLbl.Text = $"{employeeType} Employee Added!";
            clearBoxes();
        }

        public void addToList(Employee info)
        {
            // all employees share these variable names
            singleEmployeeInfo.Add(info.FirstName);
            singleEmployeeInfo.Add(info.LastName);
            singleEmployeeInfo.Add(info.SSN);
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
    }
}