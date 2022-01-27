using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetExpense.Model
{
    public class TransactionData:INotifyPropertyChanged
    {
        public int ID { get; set; } = 1;
        public string ItemName { get; set; } = "";
        public string CategoryType { get; set; } = "";
        public string Note { get; set; } = "";
        private decimal amount = 0;
        public decimal Amount
        { 
            get=> amount; 
            set { amount = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Amount")); } 
        }

        private decimal income = 0;
        public decimal Income 
        { 
            get => income; 
            set { income = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Income")); } 
        }
        private decimal saving = 0;

        public decimal Saving
        {
            get => saving;
            set { saving = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Saving")); }
        }
        private decimal balance = 0;

        public decimal Balance
        {
            get => balance;
            set { balance = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Balance")); }
        }

        private DateTime date = DateTime.Now;

        public DateTime Date
        {
            get => date;
            set { date = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Date")); }
        }

        

        public event PropertyChangedEventHandler PropertyChanged;

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
        public string Currency { get; set; } = "$";
        public string CategoryType { get; set; } = "";
        public DateTime Date { get; set; }
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
    public class TransactionDataList
    {
        public List<TransactionData> transactions = new List<TransactionData> { };
    }
    
}
