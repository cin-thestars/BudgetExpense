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

    public class Transaction_Add
    {
        public int Id { get; set; } = 1;
        public string Type { get; set; } = "Expense"; // ComboBox
        public string ItemName { get; set; } = ""; //TextBox
        public string Note { get; set; } = ""; //TextBox
        public decimal Amount { get; set; } = 0;
        public DateTime Date { get; set; } = DateTime.Now;

        public override string ToString()
        {
            return Type;
        }

    }

    public class TypeList
    {
        public List<Transaction_Add> typeList { get; set; } =
            new List<Transaction_Add>
            {
                new Transaction_Add { Type = "Expense"},
                new Transaction_Add { Type = "Income"},
                new Transaction_Add { Type = "Saving"},
            };
    }

}
