using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeePayroll
{
    public partial class Payroll : Form
    {
        //create a copy of the list of employees so it can be accessed in this form
        private List<Employee> employeeList;

        StreamWriter fileWriter;
        public Payroll(List<Employee> list)
        {
            InitializeComponent();

            employeeList = list;
        }

        private void createFileBtn_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string fileName;
            
            var filePicked = new SaveFileDialog();

            filePicked.CheckFileExists = false;

            // pulls up files 
            result = filePicked.ShowDialog();
            fileName = filePicked.FileName;

            if (result == DialogResult.OK)
            {
                FileStream stream = new FileStream(fileName, FileMode.Append, FileAccess.Write);

                //obj to be able to write in the file
                fileWriter = new StreamWriter(stream);

                fileNameLbl.Text = $"Editing {Path.GetFileName(fileName)}\n   Choose employees to add to {Path.GetFileName(fileName)} file";

                foreach (Employee emp in employeeList)
                {
                    listOfEmployees.Items.Add($"{emp.LastName}, {emp.FirstName} - SSN: {emp.SSN}");
                }
                cancelBtn.Visible = true;
            }

        }

        private void listOfEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            // if user selects an item (employee)
            if (listOfEmployees.SelectedItems.Count > 0)
            {
                enterBtn.Visible = true;
                saveBtn.Visible = true;
            }
            else
            {
                enterBtn.Visible = false;
                saveBtn.Visible = false;
            }               
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            //sends message to user
            DialogResult result = MessageBox.Show("Canceling will not save any changes. Are you sure you want to cancel?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //checks user answer
            if (result == DialogResult.Yes)
            {
                listOfEmployees.Items.Clear();

                enterBtn.Visible = false;
                cancelBtn.Visible = false;
                fileNameLbl.Text = "";

                fileWriter.Close();
            }
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {

            foreach (string item in listOfEmployees.SelectedItems)
            {
                foreach (Employee emp in employeeList)
                {
                    if (item.Contains(emp.SSN))
                    {
                        fileWriter.WriteLine($"{emp.FirstName}-{emp.LastName}-{emp.SSN}-")
                    }
                }
            }
        }
    }
}
