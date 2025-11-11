using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace EmployeePayroll
{
    // validate form input
    internal class Validation
    {
        private string FirstName;
        private string LastName;
        private string SSN;
        private string Pay;
        private string LastBox;
        private string EmployeeType;

        List<string> ErrorMsgs = new List<string>();

        public Validation(string fName, string lName, string ssn, string pay, string lastBox, string empType)
        {
            FirstName = fName;
            LastName = lName;
            SSN = ssn;
            Pay = pay;
            LastBox = lastBox;
            EmployeeType = empType;
        }

        public List<string> IsValid()
        {
            StringsValid(FirstName, LastName);
            NumsValid(SSN, Pay, LastBox);

            return ErrorMsgs;
        }
        public void StringsValid(string name1, string name2)
        {
            string fullName = name1 + name2;

            //checks names
            foreach(char letter in fullName)
            {
                //checks if there is a number or special char in the name
                if (!char.IsLetter(letter))
                {
                    ErrorMsgs.Add("- Name cannot contain numbers or special characters");
                    break;
                }
            }
        }

        public void NumsValid(string social, string pay, string lastBox)
        {
            float tmp;

            try
            { // test ssn
                tmp = Convert.ToInt32(social);

                if (social.Length != 9 || tmp <0) //won't accept negative nums
                {
                    ErrorMsgs.Add("- SSN must only contain 9 numbers; no dashes");
                }
            }
            catch
            {
                ErrorMsgs.Add("- SSN cannot contain letters or special characters.");
            }

            try
            { //test pay
                tmp = Convert.ToSingle(pay);
                if (EmployeeType == "Salary" && tmp < 0)
                {
                    ErrorMsgs.Add("- Weekly salary must be a positive number");
                }
                else if (EmployeeType == "Hourly" && tmp < 0)
                {
                    ErrorMsgs.Add("- Rate must be a positive number");
                }
                else if (EmployeeType == "Commission" && (tmp > 1 || tmp < 0))
                {
                    ErrorMsgs.Add("- Commission rate must be a decimal (example: 0.25 for 25%)");
                }
            }
            catch
            {
                ErrorMsgs.Add("- Rate can only be a positive number");
            }

            if (EmployeeType != "Salary")
            {
                try
                { //tests hours worked / sales amount
                    tmp = Convert.ToSingle(lastBox);

                    if (EmployeeType == "Hourly" && tmp > 168)
                    {
                        ErrorMsgs.Add("- Hours worked cannot be greater than the number of hours in a week (168 hours)");
                    }
                    else if (EmployeeType == "Hourly" && tmp <0)
                    {
                        ErrorMsgs.Add("- Hours worked cannot be a negative umber");
                    }
                    else if (EmployeeType == "Commission" && tmp < 0)
                    {
                        ErrorMsgs.Add("- Sales amount cannot be negative");
                    }
                }
                catch
                {
                    if (EmployeeType == "Hourly")
                    {
                        ErrorMsgs.Add("- Hours worked must be a positive number");
                    }
                    else
                    {
                        ErrorMsgs.Add("- Sales amount must be a positive number");
                    }
                }
            }
        }
    }
}
