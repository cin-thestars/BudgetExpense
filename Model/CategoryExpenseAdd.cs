using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetExpense.Model
{
    public class CategoryExpenseAdd
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    public class CategoryExpenseList
    {
        public List<CategoryExpenseAdd> CategoryModels { get; set; } =
            new List<CategoryExpenseAdd>
            {
                new CategoryExpenseAdd{Name = "Entertainment"},
                new CategoryExpenseAdd{Name = "Food"},
                new CategoryExpenseAdd{Name = "Drinks"}
            };
    }

}
