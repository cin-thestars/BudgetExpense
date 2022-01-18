using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetExpense.Model
{
    public class CategoryIncomeAdd
    {
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }

    }

    public class CategoryIncome
    {
        public List<CategoryIncomeAdd> IncomeModel { get; set; } =
            new List<CategoryIncomeAdd> 
            {
                new CategoryIncomeAdd{Name = "Investment"},
                new CategoryIncomeAdd{Name = "Salary"},
                new CategoryIncomeAdd {Name = "Income"},
                new CategoryIncomeAdd {Name = "Interest"}
            };
    }
}
