using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetExpense.Model
{
    public class Transaction
    {
        public double Incomes { get; set; } = 0;
        public double Expenses { get; set; } = 0;
    }
    public class TransactionList
    {
        public List<Transaction> Transactions { get; set; } = new List<Transaction>
        {
            new Transaction{Incomes=10, Expenses=0},
            new Transaction{Incomes=0, Expenses=30},
            new Transaction{Incomes=50, Expenses=0},
        };
        public void LoadData() { }
        public void SaveData() { }
    }
}
