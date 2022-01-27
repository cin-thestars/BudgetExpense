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
        public ObservableCollection<TransactionData> transactions { get; set; }
        public TransactionDataList transactionDataList = new TransactionDataList();
        public TransactionDataViewModel()
        {
            categoryTypeLists = new ObservableCollection<TransactionData>(categoryList.categoryTypeLists);
            newTransactions = new ObservableCollection<NewTransaction>(newTransaction.newTransactions);
            transactions = new ObservableCollection<TransactionData>(transactionDataList.transactions);
        }
        public TransactionData TransactionData { get; set; } = new TransactionData();
        public NewTransaction NewTransaction { get; set; } = new NewTransaction();

        public void AddExpense(TransactionData transactionData)
        {
            newTransactions.Add(new NewTransaction
            {
                Expense = transactionData.Amount,
                Income = 0,
                Saving = 0,
                ItemName = transactionData.ItemName,
                Note = transactionData.Note,
                ID = GenerateID(transactionData.ID),
                Currency = "$",
                CategoryType = transactionData.CategoryType,
                Date = transactionData.Date
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
                Note = transactionData.Note,
                ID = GenerateID(transactionData.ID),
                Currency = "$",
                CategoryType = transactionData.CategoryType,
                Date = transactionData.Date
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
                Note = transactionData.Note,
                ID = GenerateID(transactionData.ID),
                Currency = "$",
                CategoryType = transactionData.CategoryType,
                Date = transactionData.Date
            });
        }
        public int GenerateID(int a)
        {

            for(int i = 0; i < newTransactions.Count; i++)
            {
                a++;
            }
            return a;
        }
        public decimal TotalExpense()
        {
            decimal total = 0;
            for(int i = 0; i <newTransactions.Count; i++)
            {
                total += newTransactions[i].Expense;
            }
            return total;
        }
        public decimal TotalIncome()
        {
            decimal total = 0;
            for (int i = 0; i < newTransactions.Count; i++)
            {
                total += newTransactions[i].Income;
            }
            return total;
        }
        public decimal TotalSaving()
        {
            decimal total = 0;
            for (int i = 0; i < newTransactions.Count; i++)
            {
                total += newTransactions[i].Saving;
            }
            return total;
        }
        public decimal CalculateBalance()
        {
            decimal total = 0;
            if(TotalIncome() == 0)
            {
                total = -TotalExpense();
            }
            else if(TotalIncome()> 0)
            {
                total = TotalIncome() - TotalExpense();
            }
            return total;
        }
        
    }
}
