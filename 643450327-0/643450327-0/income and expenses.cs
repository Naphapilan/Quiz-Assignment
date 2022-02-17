using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _643450327_0
{
    internal class income_and_expenses
    {

        private double sumIncome = 0;
        private double sumExpenses = 0;
        private double expenses = 0;
        private double income = 0;
        private string list = string.Empty;
        private string alldata = string.Empty;

        public void addList(double amount, string list)
        {
            this.sumIncome += amount;
            this.sumExpenses += amount;
            this.alldata += list + " " + amount + type + Environment.NewLine;

            if (this.income < amount) { this.income = amount; }
            if (this.expenses < amount) { this.expenses = amount; }
        }
   
        
        public double getSumIncome()
        {
            double result = this.sumIncome + this.income;
            return result;
        }
        public double getSumExpenses()
        {
            double result = this.sumExpenses + this.expenses;
            return result;
        }
        public double getIncome()
        {
            return this.sumIncome;
        }

        public string GetSumExpenses()
        {
            return sumExpenses;
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
