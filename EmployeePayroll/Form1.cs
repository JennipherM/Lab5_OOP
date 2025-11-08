using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
Modify your basic employee payroll system application to allow data to be stored in flat files.

Your application changes should include the following:

- Create weekly employee payroll files that contain the employees as they are entered.
     > Selecting a new file location or an existing file. This should make it the "active" file that new entries will be appended.
    > Write employee entries to the active file. Be sure to include all of the applicable information for their job position.
    > Write the entries with a consistent delimiting character. You are free to choose your delimiting character, but be sure that it won't interfere with the data.
     > Give the user feedback when a record is successfully written.

- Required controls to facilitate the reading in of a stored weekly payroll list.
    > Include controls to select a file to read into the application. You can have this be on the main form, or a secondary form.
    > Print the employee's name, pay type, and pay amount for that week, per each employee in that weekly payroll list.
    > Also print the total outgoing pay. This should be a total of all employee's pay for that week.
- Input validation and error handling for both the entry and retrieval process. Make sure that this is complete, no improper input should make your application crash.
    > Communicate to the user what the error was and how to remediate it. This may be a mixture of labels, message boxes, or other controls as you see fit.
    > Make sure to safely open and close files for reading.
    > Include a way to exit your application, without clicking on the "x" button for the window.


*/

namespace EmployeePayroll
{
    public partial class Form1 : Form
    {
        string employeeType;
        List<Employee> employeeList = new List<Employee>();
        
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

                displayEmployees(employeeList);
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

                addToList(salaryEmployee);
            }
            else if (employeeType == "Hourly")
            {
                HourlyEmployee hourlyEmployee = new HourlyEmployee(firstName.Text, lastName.Text, ssn.Text, Convert.ToSingle(pay.Text), Convert.ToSingle(lastBox.Text));

                addToList(hourlyEmployee);
            }
            else
            {
                if (Convert.ToSingle(pay.Text) < 0 || Convert.ToSingle(pay.Text) > 1)
                {
                    messageLbl.Text = "Commission rate must be a decimal\n(example: 0.25 for 25%)";
                    return;
                }

                CommissionEmployee commissionEmployee = new CommissionEmployee(firstName.Text, lastName.Text, ssn.Text, Convert.ToSingle(pay.Text), Convert.ToSingle(lastBox.Text));

                addToList(commissionEmployee);
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
        public void addToList(Employee employee)
        {
            employeeList.Add(employee);
        }

        public void displayEmployees(List<Employee> list)
        {
            foreach (Employee emp in list)
            {
                employeeListView.Items.Add(emp.ToString() + $"  |  Earnings: ${emp.Earnings()}");

                // add a blank line for readability
                employeeListView.Items.Add("   ");
            }
        }
    }
}