using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetExpense.Model
{
    public class Transaction
    {
        public decimal Income { get; set; } = 0;
        public decimal Expenses { get; set; } = 0;
        public decimal Saving { get; set; } = 0;
    }
    public class TransactionList
    {
        public List<Transaction> Transactions { get; set; } = new List<Transaction>
        {
            new Transaction{Income=10, Expenses=0},
            new Transaction{Income=0, Expenses=30},
            new Transaction{Income=50, Expenses=0},
        };
        public void LoadData() { }
        public void SaveData() { }
    }
    public class AddTransactionData
    {
        public int ID { get; set; } = 1;
        public string CategoryType { get; set; } = "Expense";
        public string ItemName { get; set; } = "";
        public decimal Amount { get; set; } = 0;
        public DateTime Date { get; set; } = DateTime.Now;
        public string Note { get; set; } = "";
        public override string ToString()
        {
            return CategoryType;
        }
    }
    public class CategoryTypeList
    {
        public List<AddTransactionData> categoryTypes { get; set; } =
            new List<AddTransactionData>
            {
                new AddTransactionData{CategoryType = "Expense"},
                new AddTransactionData{CategoryType = "Income"},
                new AddTransactionData{CategoryType = "Saving"}
            };
    }
    
}
