using BudgetExpense.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetExpense.ViewModel
{
    public class TransactionViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<Transaction> Transactions { get; set; }
        private TransactionList transactionList = new TransactionList();
        public ObservableCollection<AddTransactionData> categoryTypes { get; set; }
        private CategoryTypeList categoryTypeLists = new CategoryTypeList();
        public TransactionViewModel()
        {
            Transactions = new ObservableCollection<Transaction>(transactionList.Transactions);
            categoryTypes = new ObservableCollection<AddTransactionData>(categoryTypeLists.categoryTypes);
            
        }
        
        public AddTransactionData AddTransactionData { get; set; } = new AddTransactionData();
        
        public void AddExpense(AddTransactionData addTransactionData)
        {
            Transactions.Add(new Transaction
            {
                Expenses = addTransactionData.Amount,
                Income = 0,
                Saving = 0
            });
        }
        public void AddIncome(AddTransactionData addTransactionData)
        {
            Transactions.Add(new Transaction
            {
                Expenses = 0,
                Income = addTransactionData.Amount,
                Saving = 0
            });
        }
        public void AddSaving(AddTransactionData addTransactionData)
        {
            Transactions.Add(new Transaction
            {
                Expenses = 0,
                Income = 0,
                Saving = addTransactionData.Amount
            });
        }
    }
    
}
