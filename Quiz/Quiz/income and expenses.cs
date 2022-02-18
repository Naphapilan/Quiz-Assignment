using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    internal class income_and_expenses
    {
        private int sumIncome = 0;
        private int sumExpenses = 0;
        private int expenses = 0;
        private int income = 0;
        private int n = 0;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="income"></param>
        /// <param name="expenses"></param>
        public void addList(int income ,int expenses )
        {
            this.sumIncome += income;
            this.sumExpenses += expenses;
         /*   this.n++;

            if (this.sumIncome < income) 
            { 
                this.sumIncome += income; 

            }
            if (this.sumExpenses < expenses) 
            { 
                this.sumExpenses += expenses; 
            }*/
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

    }
}
