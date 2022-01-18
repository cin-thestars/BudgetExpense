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
    public class CategoryAddIncomeViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<CategoryIncomeAdd> categoryIncomeAdds { get; set; }
        private CategoryIncome categoryIncome = new CategoryIncome();
        public CategoryAddIncomeViewModel()
        {
            categoryIncomeAdds = new ObservableCollection<CategoryIncomeAdd>(categoryIncome.IncomeModel);
        }
    }
}
