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
    public class ExpenseCategoryViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<ExpenseCategoryModel> expenseCategories { get; set; }
        private ExpenseList expenseList = new ExpenseList();
        public ExpenseCategoryViewModel()
        {
            expenseCategories = new ObservableCollection<ExpenseCategoryModel>(expenseList.expenseCategories);
        }
    }
}
