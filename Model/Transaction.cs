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
    public class ExpenseCategoryModel
    {
        public string expense { get; set; }
        public override string ToString()
        {
            return expense;
        }
    }
    public class ExpenseList
    {
        public List<ExpenseCategoryModel> expenseCategories { get; set; } =
            new List<ExpenseCategoryModel>
            {
                new ExpenseCategoryModel{expense = "Entertainment"},
                new ExpenseCategoryModel{expense = "Food"},
                new ExpenseCategoryModel{expense = "Drinks"},
                new ExpenseCategoryModel{expense = "Housing"},
                new ExpenseCategoryModel{expense = "Lifestyle"},
                new ExpenseCategoryModel{expense = "Transportation"}
            };
    }
}
