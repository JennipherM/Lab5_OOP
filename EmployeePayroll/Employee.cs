using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll
{
    public abstract class Employee
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string SSN { get; }

        public Employee(string fName, string lName, string ssn)
        {
            FirstName = fName;
            LastName = lName;
            SSN = ssn;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName + "\n SSN: " + SSN;
        }

        public abstract float Earnings();
    }
    class SalaryEmployee : Employee
    {
        public float WeeklySalary { get; }

        public SalaryEmployee(string fName, string lName, string ssn, float salary) : base(fName, lName, ssn)
        {
            WeeklySalary = salary;
            Console.WriteLine("Salary Employee Created");
        }

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}  |  SSN: {SSN}  |  Type: Salary  |  Weekly Salary: {WeeklySalary}\n";
        }

        // NEEDS CHANGED 
        public override float Earnings()
        {
            float tmp = 0.0f;
            Console.WriteLine("test");
            return tmp;
        }
    }

    class HourlyEmployee : Employee
    {
        public float HourWage { get; }
        public float HoursWorked { get; }

        public HourlyEmployee(string fName, string lName, string ssn, float wage, float hoursWorked) : base(fName, lName, ssn)
        {
            HourWage = wage;
            HoursWorked = hoursWorked;

            Console.WriteLine("Hourly Employee Created");
        }

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}  |  SSN: {SSN}  |  Type: Hourly  |  Hours Worked: {HoursWorked}  |  Wage: {HourWage}\n";
        }

        // NEEDS CHANGED 
        public override float Earnings()
        {
            float tmp = 0.0f;
            Console.WriteLine("test");
            return tmp;
        }
    }
    class CommissionEmployee : Employee
    {
        public float SalesAmount { get; }
        public float CommissionRate { get; }
        public CommissionEmployee(string fName, string lName, string ssn, float salesAmount, float commissionRate) : base(fName, lName, ssn)
        {
            SalesAmount = salesAmount;
            CommissionRate = commissionRate;

            Console.WriteLine("Commission Employee Created");
        }

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}  |  SSN: {SSN}  |  Type: Commission  |  Weekly Sales: {SalesAmount}  |  Commission Rate: {CommissionRate}\n";
        }

        // NEEDS CHANGED 
        public override float Earnings()
        {
            float tmp = 0.0f;
            Console.WriteLine("test");
            return tmp;
        }
    }
}
