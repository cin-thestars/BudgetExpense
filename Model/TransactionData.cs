using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetExpense.Model
{
    public class TransactionData
    {
        public int ID { get; set; } = 1;
        public string ItemName { get; set; } = "";
        public string CategoryType { get; set; } = "";
        public string Note { get; set; } = "";
        public decimal Amount { get; set; } = 0;
        public string Date { get; set; } = "";
        public override string ToString()
        {
            return CategoryType;
        }

    }
    public class NewTransaction
    {
        public decimal Expense { get; set; } = 0;
        public decimal Income { get; set; } = 0;
        public decimal Saving { get; set; } = 0;
        public string ItemName { get; set; } = "";
        public string Note { get; set; } = "";
        public int ID { get; set; } = 1;
        public string Date { get; set; } = "";


    }
    public class CategoryTypeList
    {
        public List<TransactionData> categoryTypeLists =
            new List<TransactionData>
            {
                new TransactionData{CategoryType = "Expense"},
                new TransactionData{CategoryType = "Income"},
                new TransactionData{CategoryType = "Saving"}
            };
    }
    public class NewTransactionList
    {
        public List<NewTransaction> newTransactions =
            new List<NewTransaction> {};
    }
}
