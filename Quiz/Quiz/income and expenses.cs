using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    internal class income_and_expenses
    {
        private double sumincome = 0;
        private double sumexpenses = 0;
        private double expenses = 0;
        private double income = 0;
        private int n = 0;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="income"></param>
        /// <param name="expenses"></param>
        public void addList(double income, double expenses)
        {

            this.income = income;
            this.expenses = expenses;
        }
    }        
}
