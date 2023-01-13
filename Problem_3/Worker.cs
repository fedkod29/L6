using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_3
{
    class Worker : Human
    {
        private double weekSalary;
        private int workinHours;

        public Worker(string firstName, string lastNme, double weekSalary, int workinHours)
            : base(firstName, lastNme)
        {
            this.WeekSalary = weekSalary;
            this.WorkinHours = workinHours;
        }

        public double WeekSalary
        {
            get
            {
                return weekSalary;
            }
            set
            {
                if (value < 10)
                {
                    throw new Exception("Expected value mismatch! Argument: weekSalary");
                }                   

                this.weekSalary = value;
            }
        }
        public int WorkinHours
        {
            get
            {
                return workinHours;
            }
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new Exception("Expected value mismatch! Argument: workHoursPerDay");
                }    

                workinHours = value;
            }
        }
        private double CalculateSalaryPerHour()
        {
            return Math.Round((weekSalary / 5 / workinHours), 2);
        }
        public override string AllInf()
        {
            return $"{base.AllInf()} \n Week salary: {this.weekSalary}" +
                $" \n Workig hours: {this.workinHours} \n Salary per hour: {CalculateSalaryPerHour()}";
        }
    }
}
