using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetExpense.Model
{
    public class ExpenseCategoryModel
    {
        public string expense { get; set; } = "";
        public override string ToString()
        {
            return expense;
        }
    }
    public class ExpenseList
    {
        public List<ExpenseCategoryModel> expenseCategories { get; set; } =
            new List<ExpenseCategoryModel>
            {
                new ExpenseCategoryModel{expense = "Entertainment"},
                new ExpenseCategoryModel{expense = "Food"},
                new ExpenseCategoryModel{expense = "Drinks"},
                new ExpenseCategoryModel{expense = "Housing"},
                new ExpenseCategoryModel{expense = "Lifestyle"},
                new ExpenseCategoryModel{expense = "Transportation"}
            };
    }
}
