using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
Modify your basic employee payroll system application to allow data to be stored in flat files.

Your application changes should include the following:

- Create weekly employee payroll files that contain the employees as they are entered.
     > Selecting a new file location or an existing file. This should make it the "active" file that new entries will be appdelimIndexed.
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
    public partial class createEmployee : Form
    {
        string employeeType;
        //list of all new employees (new ssn) created / entered
        List<Employee> employeeList = new List<Employee>();

        //keeps track of the employees(by their ssn)that are entered into a file
        List<string> ssnList;
        TextBox[] infoBoxes;

        bool isExisting;
        FileStream stream;
        string fileName;

        public createEmployee()
        {
            InitializeComponent();
            infoBoxes = new TextBox[] { firstName, lastName, ssn, pay, lastBox };
        }

        // for action buttons
        public void taskOptions_Click(object sender, EventArgs e)
        {
            if (sender == addBtn)
            {
                radioGroup.Visible = true;
                infoGroup.Visible = false;
                employeeListView.Visible = false;
            }
            else if (sender == viewBtn)
            {
                salaryRadio.Checked = false;
                hourlyRadio.Checked = false;
                commRadio.Checked = false;

                infoGroup.Visible = false;
                radioGroup.Visible = false;
                employeeListView.Visible = true;

                employeeListView.Items.Clear();
                displayEmployees(employeeList);
            }
            else if (sender == createBtn)
            {
                var filePicked = new SaveFileDialog();
                filePicked.CheckFileExists = false;

                // pulls up files 
                DialogResult result = filePicked.ShowDialog();
                fileName = filePicked.FileName;

                if (result == DialogResult.OK)
                {
                    fileNameLbl.Text = $"Editing {Path.GetFileName(fileName)}";
                    ssnList = new List<string>();
                    radioGroup.Enabled = true;
                }
            }
            else if (sender == readBtn)
            {
                salaryRadio.Checked = false;
                hourlyRadio.Checked = false;
                commRadio.Checked = false;

                infoGroup.Visible = false;
                radioGroup.Visible = false;
                employeeListView.Visible = true;

                employeeListView.Items.Clear();

                var filePicked = new OpenFileDialog();
                filePicked.CheckFileExists = true;

                DialogResult result = filePicked.ShowDialog();
                fileName = filePicked.FileName;

                if (result == DialogResult.OK)
                {
                    StreamReader fileReader = new StreamReader(fileName);

                    displayFile(fileReader);
                }
            }
            else
            {
                this.Close();
            }
        }
        public void radioOptions(object sender, EventArgs e)
        {
            infoGroup.Visible = true;
            clearBoxes();
            messageLbl.Text = "";

            //changes employee info fields depdelimIndexing on which type was choosen
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
            messageLbl.Text = "";
            ErrorMessages.Visible = false;
            ErrorMessages.Items.Clear();

            if (firstName.Text == "" || lastName.Text == "" || ssn.Text == "" || pay.Text == "" || (lastBox.Visible == true && lastBox.Text == ""))
            {
                messageLbl.Text = "Fill in all fields";

                return;
            }
            else
            {
                //take off leading / trailing spaces
                trimText();

                Validation testValues = new Validation(firstName.Text, lastName.Text, ssn.Text, pay.Text, lastBox.Text, employeeType);

                //holds all errors
                List<string> errorList = testValues.IsValid();

                if (errorList.Count != 0)
                {
                    ErrorMessages.Visible = true;

                    foreach (string error in errorList)
                    {
                        ErrorMessages.Items.Add(error);
                        ErrorMessages.Items.Add(" "); //blank line for readability
                    }
                    return;
                }

                //check if ssn is unique for each person in a file
                foreach (string social in ssnList)
                {
                    if (ssn.Text == social)
                    {
                        ErrorMessages.Visible = true;
                        ErrorMessages.Items.Add("- SSN's must be unique to each new employee");
                        return;
                    }
                }
                ssnList.Add(ssn.Text);
            }

            if (employeeType == "Salary")
            {
                SalaryEmployee salaryEmployee = new SalaryEmployee(firstName.Text, lastName.Text, ssn.Text, Convert.ToSingle(pay.Text));

                isExisting = checkIfExisting(salaryEmployee);

                // if not existing
                // (if employees already exist, they don't go into the full employeeList, but can still be added to files
                if (!isExisting)
                {
                    employeeList.Add(salaryEmployee);
                }

                addToFile(salaryEmployee);
            }
            else if (employeeType == "Hourly")
            {
                HourlyEmployee hourlyEmployee = new HourlyEmployee(firstName.Text, lastName.Text, ssn.Text, Convert.ToSingle(pay.Text), Convert.ToSingle(lastBox.Text));

                isExisting = checkIfExisting(hourlyEmployee);
                if (!isExisting)
                {
                    employeeList.Add(hourlyEmployee);
                }
                addToFile(hourlyEmployee);
            }
            else
            {
                CommissionEmployee commissionEmployee = new CommissionEmployee(firstName.Text, lastName.Text, ssn.Text, Convert.ToSingle(pay.Text), Convert.ToSingle(lastBox.Text));

                isExisting = checkIfExisting(commissionEmployee);
                if (!isExisting)
                {
                    employeeList.Add(commissionEmployee);
                }
                addToFile(commissionEmployee);
            }

            messageLbl.Text = $"{employeeType} Employee Added!";
            clearBoxes();
        }

        public void clearBoxes()
        {
            foreach (TextBox field in infoBoxes)
            {
                field.Text = "";
            }
        }

        public void trimText()
        {
            foreach (TextBox field in infoBoxes)
            {
                //removes any spaces before / after input
                field.Text = field.Text.Trim();
            }
        }

        public void displayEmployees(List<Employee> list)
        {
            foreach (Employee emp in list)
            {
                employeeListView.Items.Add(emp.ToString() + $"  |  Earnings: ${emp.Earnings()}");

                // add a blank line for readability
                employeeListView.Items.Add(" ");
            }
        }

        public void addToFile(Employee emp)
        {
            stream = new FileStream(fileName, FileMode.Append, FileAccess.Write);
            StreamWriter fileWriter = new StreamWriter(stream);

            fileWriter.WriteLine(emp.InfoToFile());

            fileWriter.Close();
        }

        public bool checkIfExisting(Employee person)
        {
            foreach (Employee emp in employeeList)
            {
                if (person.SSN == emp.SSN)
                {
                    return true; //do exist
                }
            }
            return false; //don't exist
        }

        public string findStartEnd(int start, int end, string currentLine, int repeatNum)
        {
            int count = 0;
            for (int i = 0; i < repeatNum; i++)
            {
                count++;
                start = end + 1;
                end = currentLine.IndexOf('|', start);
            }
            return currentLine.Substring(start, end - start);
        }
        public void displayFile(StreamReader fileReader)
        {
            string currentLine = "";
            float totalPayAmount = 0;

            while ((currentLine = fileReader.ReadLine()) != null)
            {
                int start = 0;
                int end = currentLine.IndexOf('|');
                string fName = currentLine.Substring(start, end - start);

                start = end + 1;
                end = currentLine.IndexOf('|', start);
                string lName = currentLine.Substring(start, end - start);

                for (int i = 0; i < 2; i++)
                {
                    start = end + 1;
                    end = currentLine.IndexOf('|', start);
                }
                string payType = currentLine.Substring(start, end - start);

                string weekPay;
                
                if (payType == "Salary")
                {
                    start = end + 1;
                    end = currentLine.IndexOf('|', start);
                    start = end + 1;
                    weekPay = currentLine.Substring(start);
                }
                else
                {
                    for (int i = 0; i < 3; i++)
                    {
                        start = end + 1;
                        end = currentLine.IndexOf('|', start);
                    }
                    weekPay = currentLine.Substring(start);                   
                }
                totalPayAmount += Convert.ToSingle(weekPay);
                employeeListView.Items.Add($"Name: {fName} {lName} - Pay Type: {payType} - Paycheck Amount: ${weekPay}");
                employeeListView.Items.Add("  ");
            }
            employeeListView.Items.Add($"Total Employee Pay: ${totalPayAmount}");
        }
    }
}
