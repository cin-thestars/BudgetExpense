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

        public ObservableCollection<Transaction> Transactions { get; set; }
        private TransactionList transactionList = new TransactionList();

        public Transaction_Add_View_Model()
        {
            Transactions = new ObservableCollection<Transaction>(transactionList.Transactions);
            transaction_Adds = new ObservableCollection<Transaction_Add>(Type_List.typeList);
        }

        public Transaction_Add Transaction_Add { get; set; } = new Transaction_Add();

        public void AddExpense(Transaction_Add addTransactionData)
        {
            Transactions.Add(new Transaction
            {
                Expenses = addTransactionData.Amount,
                Income = 0,
                Saving = 0
            });
        }
        public void AddIncome(Transaction_Add addTransactionData)
        {
            Transactions.Add(new Transaction
            {
                Expenses = 0,
                Income = addTransactionData.Amount,
                Saving = 0
            });
        }
        public void AddSaving(Transaction_Add addTransactionData)
        {
            Transactions.Add(new Transaction
            {
                Expenses = 0,
                Income = 0,
                Saving = Transaction_Add.Amount
            });
        }

    }
}
