using System;

namespace BudgetCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Job unco = new Job("UNCO", IncomeState.Colorado, 20, 15.25);
            Job taylorcorp = new Job("Packaging", IncomeState.Minnesota, 0, 16.00);
            Job healthcare = new Job("Healthcare", IncomeState.Colorado, 40, 20.00);
            Job romas = new Job("Roma's", IncomeState.Colorado, 0, 14.25);

            List<Job> jobs = new List<Job>();
            jobs.Add(unco);
            jobs.Add(taylorcorp);
            jobs.Add(healthcare);
            jobs.Add(romas);

            Calculator cost = new Calculator(jobs);

            cost.SetEssentials();

            cost.CheckIfEnough();

            Console.ReadKey();
        }
    }
}