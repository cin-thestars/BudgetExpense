using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetExpense.Model
{
    public class CategorySavingAdd
    {
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }

    public class CategorySavingList
    {
        public List<CategorySavingAdd> savingModel { get; set; } =
            new List<CategorySavingAdd>
            {
                new CategorySavingAdd { Name = "Saving"},
                new CategorySavingAdd { Name = "Vacation Saving"},
                new CategorySavingAdd { Name = "Emergency Saving"}
            };
    }

}
