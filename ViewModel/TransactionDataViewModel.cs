using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BudgetExpense.Model;
namespace BudgetExpense.ViewModel
{
    class TransactionDataViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<TransactionData> categoryTypeLists { get; set; }
        public CategoryTypeList categoryList = new CategoryTypeList();
        public ObservableCollection<NewTransaction> newTransactions { get; set; }
        public NewTransactionList newTransaction = new NewTransactionList();
        public TransactionDataViewModel()
        {
            categoryTypeLists = new ObservableCollection<TransactionData>(categoryList.categoryTypeLists);
            newTransactions = new ObservableCollection<NewTransaction>(newTransaction.newTransactions);

        }
        public TransactionData TransactionData { get; set; } = new TransactionData();
        public void AddExpense(TransactionData transactionData)
        {
            newTransactions.Add(new NewTransaction
            {
                Expense = transactionData.Amount,
                Income = 0,
                Saving = 0,
                ItemName = transactionData.ItemName,
                Note = transactionData.Note,
                //Date = transactionData.Date
            });
        }
        public void AddIncome(TransactionData transactionData)
        {
            newTransactions.Add(new NewTransaction
            {
                Expense = 0,
                Income = transactionData.Amount,
                Saving = 0,
                ItemName = transactionData.ItemName,
                Note = transactionData.Note
            });
        }
        public void AddSaving(TransactionData transactionData)
        {
            newTransactions.Add(new NewTransaction
            {
                Expense = 0,
                Income = 0,
                Saving = transactionData.Amount,
                ItemName = transactionData.ItemName,
                Note = transactionData.Note
            });
        }
    }
}
