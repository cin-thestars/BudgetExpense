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
    public class CategorySavingAddViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<CategorySavingAdd> categorySavingAdds { get; set; }
        private CategorySavingList categorySavingList = new CategorySavingList();
        public CategorySavingAddViewModel()
        {
            categorySavingAdds = new ObservableCollection<CategorySavingAdd>(categorySavingList.savingModel);
        }
    }
}
