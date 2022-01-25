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
    public class Transaction_Add_View_Model : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<Transaction_Add> transaction_Adds { get; set; }
        private TypeList Type_List = new TypeList();

        public ObservableCollection<NewTransaction> newTransactions { get; set; }
        public NewTransactionList newTransaction = new NewTransactionList();

        public Transaction_Add_View_Model()
        {
            newTransactions = new ObservableCollection<NewTransaction>(newTransaction.newTransactions);
            transaction_Adds = new ObservableCollection<Transaction_Add>(Type_List.typeList);
        }

        public Transaction_Add Transaction_Add { get; set; } = new Transaction_Add();

        public void AddExpense(Transaction_Add transactionData)
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
        public void AddIncome(Transaction_Add transactionData)
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
        public void AddSaving(Transaction_Add transactionData)
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
