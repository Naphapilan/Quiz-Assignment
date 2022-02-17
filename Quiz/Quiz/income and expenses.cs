using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    internal class income_and_expenses
    {
        private double sumIn = 0;
        private double sumEx = 0;
        private double expenses = 0;
        private double income = 0;
        private string list = string.Empty;
        private string type = string.Empty;
        private string alldata = string.Empty;

        public void addList(double amount, string list)
        {
            this.sumIn += amount;
            this.sumEx -= amount;
            this.alldata += list + " " + amount + type + Environment.NewLine;

            if (this.income < amount) { this.income = amount; }
            if (this.expenses < amount) { this.expenses = amount; }
        }


        public double getSumIncome()
        {
            double result = this.sumIn + this.income;
            return result;
        }
        public double getSumExpenses()
        {
            double result = this.sumEx + this.expenses;
            return result;
        }
        public double getIncome()
        {
            return sumIn;
        }


        public string getExpenses(string sumExpenses)
        {
            return sumExpenses;
        }
        public string getAlldata()
        {
            return alldata;
        }
    }
}
