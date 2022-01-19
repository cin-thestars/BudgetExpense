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
    public class CategoryAddViewModel:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<CategoryExpenseAdd> categoryAdds { get; set; }
        private CategoryExpenseList categoryExpenseList = new CategoryExpenseList();
        public CategoryAddViewModel()
        {
            categoryAdds = new ObservableCollection<CategoryExpenseAdd>(categoryExpenseList.CategoryModels);
        }
        public ExpData ExpData { get; set; } = new ExpData();

    }
}
