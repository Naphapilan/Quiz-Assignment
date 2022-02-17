using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    internal class income_and_expenses
    {
        private double sumIncome = 0;
        private double sumExpenses = 0;
        private double expenses = 0;
        private double income = 0;
        private int n=0;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="income"></param>
        /// <param name="expenses"></param>
        public void addList(double income ,double expenses )
        {
            this.sumIncome += income;
            this.sumExpenses += expenses;
            this.n++;

            if (this.sumIncome < income) 
            { 
                this.sumIncome += income; 

            }
            if (this.sumExpenses < expenses) 
            { 
                this.sumExpenses += expenses; 
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>sumIncome</returns>
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


        public double getExpenses()
        {
            return this.sumExpenses;
        }

 

        internal void addList(string income, string expenses)
        {
            throw new NotImplementedException();
        }
    }
}
