using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetCalculator
{
    internal class Calculator
    {
        private Income incomeFlow;
        private double essentials;


        private double monthlyRent;
        private double monthlyUtilities;
        private double weeklyGroceries;
        private double monthlyPhoneBill;
        private double subscriptions;


        public Calculator(List<Job> jobs)
        {
            this.incomeFlow = new Income(jobs);
        }

        public void SetEssentials()
        {
            Console.Write("Enter rent: ");
            this.monthlyRent = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Utilities: ");
            this.monthlyUtilities = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter weekly groceries: ");
            this.weeklyGroceries = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter phone bill: ");
            this.monthlyPhoneBill = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter subscriptions: ");
            this.subscriptions = Convert.ToDouble(Console.ReadLine());

            this.essentials = this.monthlyRent + this.monthlyUtilities + (this.weeklyGroceries * 4) + this.monthlyPhoneBill + this.subscriptions;
        }

        //Follow the 50/30/20 rule.
        //50% essentials, 20% saving, 30% discretionary
        //Calculate to make sure that costs are only 50% of income.
        //Calculate needed income to match.
        //Calculate percent of income taken for the essentials
        //Tell user if they are making enough or not to match that 50 rule.

        public void CheckIfEnough()
        {
            double weeklyIncome = this.incomeFlow.GetWeeklyIncome();
            double monthlyIncome = weeklyIncome * 4;
            double pctEssentialsOfIncome = (this.essentials / monthlyIncome) * 100;
            pctEssentialsOfIncome = Math.Round(pctEssentialsOfIncome, 2);
            Console.WriteLine($"Covering the essentials equals {pctEssentialsOfIncome}% of your income.");
        }

    }
}
