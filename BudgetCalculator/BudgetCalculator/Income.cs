using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BudgetCalculator
{
    internal class Income
    {
        private List<Job> jobs;

        public Income(List<Job> jobs)
        {
            this.jobs = jobs;
            GetWeeklyIncome();
        }
        public double GetWeeklyIncome()
        {
            double total = 0;
            foreach (Job job in jobs)
            {
                total += job.GetWages();
            }
            return total;
        }
        public void AddJob(Job job)
        {
            jobs.Add(job);
            Console.WriteLine($"{job} added to income flow.");
        }
        public void RemoveJob(Job job)
        {
            jobs.Remove(job);
            Console.WriteLine($"{job} removed from income flow.");
        }
    }
}
