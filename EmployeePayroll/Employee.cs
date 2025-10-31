﻿using System;
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
        }

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}  |  SSN: {SSN}  |  Type: Salary  |  Weekly Salary: ${WeeklySalary}";
        }

        public override float Earnings()
        {            
            return WeeklySalary;
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
        }

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}  |  SSN: {SSN}  |  Type: Hourly  |  Hours Worked: {HoursWorked}  |  Wage: ${HourWage}";
        }

        public override float Earnings()
        {
            float totalEarned;
         
            if(HoursWorked > 40)
            {
                totalEarned = HourWage * 40;

                float overtime = HoursWorked - 40;

                totalEarned += overtime * (HourWage + HourWage / 2);

                return totalEarned;
            }

            return HourWage * HoursWorked;
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
        }

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}  |  SSN: {SSN}  |  Type: Commission  |  Weekly Sales: ${SalesAmount}  |  Commission Rate: {CommissionRate}";
        }

        public override float Earnings()
        {
            return SalesAmount * CommissionRate;
        }
    }
}
