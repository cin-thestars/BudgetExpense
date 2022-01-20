using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetExpense.Model
{
    public class Transaction_Add
    {
        public string Type { get; set; } = "Expense"; // ComboBox
        public string ItemName { get; set; } = ""; //TextBox
        public string Note { get; set; } = ""; //TextBox
        public double Amount { get; set; } = 0;
        public DateTime Date { get; set; } = DateTime.Now;

    }
}
