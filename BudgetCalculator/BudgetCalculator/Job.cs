using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetCalculator
{
    public enum IncomeState
    {
        Colorado,
        Minnesota,
    }

    internal class Job
    {
        public string jobName;
        private IncomeState incomeState;
        private double hoursPerWeek;
        private double hourlyWage;


        public Job(string jobName, IncomeState incomeState, double hoursPerWeek, double hourlyWage)
        {
            this.jobName = jobName;
            this.incomeState = incomeState;
            this.hoursPerWeek = hoursPerWeek;
            this.hourlyWage = hourlyWage;
        }


        public double GetWages()
        {
            double netWeek = this.hourlyWage * this.hoursPerWeek;
            double taxRate = 0.25;
            if (incomeState == IncomeState.Colorado) { taxRate = 0.22; }
            if (incomeState == IncomeState.Minnesota) { taxRate = 0.25; }
            double taxDeduct = netWeek * taxRate;
            return netWeek - taxDeduct;
        }
        public void ChangeWage(double newWage)
        {
            this.hourlyWage = newWage;
            Console.WriteLine($"Wage successfuly changed to ${this.hourlyWage} per hour.");
        }
        public void ChangeHours(double newHours)
        {
            this.hoursPerWeek = newHours;
            Console.WriteLine($"Hours successfuly changed to {this.hoursPerWeek} per week.");
        }
        public void ChangeState(IncomeState newState)
        {
            this.incomeState = newState;
            Console.WriteLine($"State successfully changed to {this.incomeState}.");
        }
    }
}
