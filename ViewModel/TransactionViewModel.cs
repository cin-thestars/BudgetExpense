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
        public TransactionViewModel()
        {
            Transactions = new ObservableCollection<Transaction>(transactionList.Transactions);
        }
    }
    
}
